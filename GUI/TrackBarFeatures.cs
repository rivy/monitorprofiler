﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MonitorProfiler.Win32;
using MonitorProfiler.Models.Display;

namespace MonitorProfiler.GUI
{
    public class TrackBarFeatures
    {
        private Label _label;
        private FeatureType _type;

        // Constructor
        public TrackBarFeatures(FeatureType type, Label label)
        {
            _type = type;
            _label = label;
        }
        
        // Update objects with new value from trackbar
        public void UpdateScreenWithBarValue(TrackBar bar, Monitor currentMonitor)
        {
            _label.Text = string.Format("{0}%", bar.Value);
            uint newValue = (uint) bar.Value;
            switch (_type)
            {
                case FeatureType.Brightness:
                    currentMonitor.Brightness.Current = newValue;
                    NativeMethods.SetMonitorBrightness(currentMonitor.HPhysicalMonitor, newValue);
                    break;
                case FeatureType.Contrast:
                    currentMonitor.Contrast.Current = newValue;
                    NativeMethods.SetMonitorContrast(currentMonitor.HPhysicalMonitor, newValue);
                    break;
            }
        }
    }

    public class TrackBarCollection: Dictionary <TrackBar, TrackBarFeatures>
    {
        public void TriggerChanges(object sender, Monitor currentMonitor)
        {
            TrackBar bar = sender as TrackBar;
            if (bar == null) return;

            TrackBarFeatures feature = this[bar];
            if (feature != null) feature.UpdateScreenWithBarValue(bar, currentMonitor);
        }
    }
}
