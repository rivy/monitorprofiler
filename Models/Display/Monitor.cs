using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonitorProfiler.Win32;

namespace MonitorProfiler.Models.Display
{
    public class Monitor
    {
        #region Declarations

        public IntPtr HPhysicalMonitor { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }

        public bool SupportsDDC { get; set; }
        public MonitorFeature Brightness;
        public MonitorFeature Contrast;
        public MonitorFeature RgbDrive;
        public MonitorFeature RgbGain;
        public MonitorFeature RedGain;
        public MonitorFeature GreenGain;
        public MonitorFeature BlueGain;
        public MonitorFeature Volume;
        public MonitorFeature VCPFeature;

        private uint _monitorCapabilities = 0u;
        private uint _supportedColorTemperatures = 0u;

        #endregion

        public Monitor(NativeStructures.PHYSICAL_MONITOR physicalMonitor)
        {
            HPhysicalMonitor = physicalMonitor.hPhysicalMonitor;
            Name = physicalMonitor.szPhysicalMonitorDescription;
            CheckCapabilities();
        }

        private void CheckCapabilities()
        {
            //NativeMethods.GetMonitorCapabilities(HPhysicalMonitor, ref _monitorCapabilities, ref _supportedColorTemperatures);

            //SupportsDDC = (_monitorCapabilities > 0);
            //if (SupportsDDC)
            //{
            CheckBrightness();
            CheckContrast();
            CheckRgbDrive();
            CheckRgbGain();
            CheckVolume();
            //}
        }

        private void CheckBrightness()
        {
           // Brightness.Supported = ((int)NativeStructures.MC_MONITOR_CAPABILITIES.MC_CAPS_BRIGHTNESS & _monitorCapabilities) > 0;
            //if (Brightness.Supported)
            //{
                //short Current = -1, Min = -1, Max = -1;
            NativeMethods.GetMonitorBrightness(HPhysicalMonitor, ref Brightness.Min, ref Brightness.Current, ref Brightness.Max);
            Brightness.Original = Brightness.Current;
           // }
        }
        private void CheckContrast()
        {
            //Contrast.Supported = ((int)NativeStructures.MC_MONITOR_CAPABILITIES.MC_CAPS_CONTRAST & _monitorCapabilities) > 0;
            //if (Contrast.Supported)
            //{
            NativeMethods.GetMonitorContrast(HPhysicalMonitor, ref Contrast.Min, ref Contrast.Current, ref Contrast.Max);
            Contrast.Original = Contrast.Current;
            //}
        }

        private void CheckRgbDrive()
        {
            //RgbDrive.Supported = ((int)NativeStructures.MC_MONITOR_CAPABILITIES.MC_CAPS_RED_GREEN_BLUE_DRIVE) > 0;
            //if (RgbDrive.Supported)
            //{
            NativeMethods.GetMonitorRedGreenOrBlueDrive(HPhysicalMonitor, NativeStructures.MC_DRIVE_TYPE.MC_BLUE_DRIVE, ref RgbDrive.Min, ref RgbDrive.Current, ref RgbDrive.Max);
            //}
        }

        private void CheckRgbGain()
        {
            //RgbGain.Supported = ((int)NativeStructures.MC_MONITOR_CAPABILITIES.MC_CAPS_RED_GREEN_BLUE_GAIN) > 0;
            //if (RgbGain.Supported)
            //{
            NativeMethods.GetMonitorRedGreenOrBlueGain(HPhysicalMonitor, NativeStructures.MC_GAIN_TYPE.MC_RED_GAIN, ref RedGain.Min, ref RedGain.Current, ref RedGain.Max);
            NativeMethods.GetMonitorRedGreenOrBlueGain(HPhysicalMonitor, NativeStructures.MC_GAIN_TYPE.MC_GREEN_GAIN, ref GreenGain.Min, ref GreenGain.Current, ref GreenGain.Max);
            NativeMethods.GetMonitorRedGreenOrBlueGain(HPhysicalMonitor, NativeStructures.MC_GAIN_TYPE.MC_BLUE_GAIN, ref BlueGain.Min, ref BlueGain.Current, ref BlueGain.Max);
            RedGain.Original = RedGain.Current;
            GreenGain.Original = GreenGain.Current;
            BlueGain.Original = BlueGain.Current;
            //}
        }

        private void CheckVolume()
        {
            //RgbGain.Supported = ((int)NativeStructures.MC_MONITOR_CAPABILITIES.MC_CAPS_RED_GREEN_BLUE_GAIN) > 0;
            //if (RgbGain.Supported)
            //{
            IntPtr volume = new IntPtr();
            NativeMethods.GetVCPFeatureAndVCPFeatureReply(HPhysicalMonitor, NativeConstants.SC_MONITORVOLUME, volume, ref Volume.Current, ref Volume.Max);
            Volume.Original = Volume.Current;
            //}
        }
    }
}
