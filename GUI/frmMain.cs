using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;
//using System.Threading;
using System.Windows.Forms;
using MonitorProfiler.GUI;
using MonitorProfiler.Win32;
using MonitorProfiler.Models.Display;
using MonitorProfiler.Models.Configuration;
using System.Xml.Serialization;
using System.IO;

namespace MonitorProfiler
{
    public partial class frmMain : Form
    {
        private readonly MonitorCollection _monitorCollection = new MonitorCollection();
        private Monitor _currentMonitor;
        private Dictionary<TrackBar, TrackBarFeatures> _bars;
        private Config _config;
            
        public frmMain()
        {
            InitializeComponent();
            InitialiseProfiles();
            InitialiseTrackBars();

            Log("Started.");

            var @delegate = new NativeMethods.MonitorEnumDelegate(MonitorEnum);
            NativeMethods.EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, @delegate, IntPtr.Zero);
            Log("Number of physical monitors: {0}", _monitorCollection.Count);

            foreach (Monitor monitor in _monitorCollection)
            {
                Log("-----");
                Log(monitor.Name);
                Log("DDC : {0}", monitor.SupportsDDC);
                Log("Brightness : {0}", monitor.Brightness.Supported);
                Log("Contrast : {0}", monitor.Contrast.Supported);
                Log("RGB Drive : {0}", monitor.RgbDrive.Supported);
                Log("RGB Gain : {0}", monitor.RgbGain.Supported);

                cboMonitors.Items.Add(monitor.Name);
            }
            if (cboMonitors.Items.Count > 0) cboMonitors.SelectedIndex = 0;

            Log("");
            Log("Ready...");
            return;
        }

        private void InitialiseProfiles()
        {
            var deserializer = new XmlSerializer(typeof(Config));
            using (var reader = new StreamReader("profiles.xml"))
            {
                _config = (Config)deserializer.Deserialize(reader);
            }
            foreach (var cfg in _config.Profiles)
                lstProfiles.Items.Add(cfg.Name);
        }

        ~frmMain()
        {
            foreach (Monitor monitor in _monitorCollection)
            {
                NativeMethods.DestroyPhysicalMonitor(monitor.HPhysicalMonitor);
            }
        }

        #region Private Methods

        // Writes message to a textbox and scroll it to bottom
        private void Log(string message, params object[] args)
        {
            txtLog.Text += Environment.NewLine + string.Format(message, args);
            NativeMethods.ScrollToBottom(txtLog);
        }

        private void InitialiseTrackBars()
        {
            _bars = new Dictionary<TrackBar, TrackBarFeatures>{
                {barBrightness, new TrackBarFeatures(FeatureType.Brightness, lblBrightness)},
                {barContrast, new TrackBarFeatures(FeatureType.Contrast, lblContrast)},
                {barRed, new TrackBarFeatures(FeatureType.RedDrive, lblRed)},
                {barGreen, new TrackBarFeatures(FeatureType.GreenDrive, lblGreen)},
                {barBlue, new TrackBarFeatures(FeatureType.BlueDrive, lblBlue)},
            };
        }

        // To be called by a delegate
        private bool MonitorEnum(IntPtr hMonitor, IntPtr hdcMonitor, ref Rectangle lprcMonitor, IntPtr dwData)
        {
            _monitorCollection.Add(hMonitor);
            return true;
        }

        private void RefreshSliders(Monitor m)
        {
            barBrightness.Enabled = m.Brightness.Supported;
            barBrightness.Minimum = (int) m.Brightness.Min;
            barBrightness.Maximum = (int) m.Brightness.Max;
            barBrightness.Value = (int) m.Brightness.Current;
            
            barContrast.Enabled = m.Contrast.Supported;
            barContrast.Minimum = (int) m.Contrast.Min;
            barContrast.Maximum = (int) m.Contrast.Max;
            barContrast.Value = (int) m.Contrast.Current;
        }

        #endregion

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            try
            {   // Assumes sender is a trackbar, and exists in the collection. Don't worry about errors :)
                _bars[sender as TrackBar].UpdateScreenWithBarValue(sender as TrackBar, _currentMonitor);
            }
            catch{}
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            barBrightness.Value = (int) _currentMonitor.Brightness.Original;
            barContrast.Value = (int) _currentMonitor.Contrast.Original;
        }

        private void cboMonitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMonitor = _monitorCollection[cboMonitors.SelectedIndex];
            RefreshSliders(_currentMonitor);
        }

        private void btnIdentifyMonitor_Click(object sender, EventArgs e)
        {
            // Dim the monitor
            NativeMethods.SetMonitorBrightness(_currentMonitor.HPhysicalMonitor, 0);
            NativeMethods.SetMonitorContrast(_currentMonitor.HPhysicalMonitor, 0);
            System.Threading.Thread.Sleep(100);
            // Revert
            NativeMethods.SetMonitorBrightness(_currentMonitor.HPhysicalMonitor, _currentMonitor.Brightness.Original); 
            NativeMethods.SetMonitorContrast(_currentMonitor.HPhysicalMonitor, _currentMonitor.Contrast.Original); 
        }

        private void lstProfiles_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedProfile = _config.Profiles.Where(p => p.Name == lstProfiles.SelectedItem.ToString()).FirstOrDefault();
            if (selectedProfile == null)
                return;

            else
                foreach (var monitorCfg in selectedProfile.MonitorConfigs)
                {

                }
        }
    }
}