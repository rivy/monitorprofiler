﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace MonitorProfiler.Win32
{
    public class NativeMethods
    {
        public delegate bool MonitorEnumDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref Rectangle lprcMonitor, IntPtr dwData);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("user32.dll")]
        public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumDelegate lpfnEnum, IntPtr dwData);

        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref NativeStructures.DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

        [DllImport("user32.dll")]
        public static extern bool GetMonitorInfo(IntPtr hmon, ref NativeStructures.MonitorInfoEx mi);
        
        [DllImport("user32.dll", EntryPoint = "MonitorFromWindow", SetLastError = true)]
        public static extern IntPtr MonitorFromWindow([In] IntPtr hwnd, uint dwFlags);

        [DllImport("user32.dll", EntryPoint = "MonitorFromPoint", SetLastError = true)]
        public static extern IntPtr MonitorFromPoint([In] Point pt, uint dwFlags);

        [DllImport("user32.dll", EntryPoint = "MonitorFromRect", SetLastError = true)]
        public static extern IntPtr MonitorFromRect(ref Rectangle lprect, uint dwFlags);

        [DllImport("dxva2.dll", EntryPoint = "GetNumberOfPhysicalMonitorsFromHMONITOR", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, ref uint pdwNumberOfPhysicalMonitors);

        [DllImport("dxva2.dll", EntryPoint = "GetPhysicalMonitorsFromHMONITOR", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] NativeStructures.PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitors", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyPhysicalMonitors(uint dwPhysicalMonitorArraySize, [Out] NativeStructures.PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitor", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyPhysicalMonitor(IntPtr hMonitor);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorTechnologyType", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorTechnologyType(IntPtr hMonitor, ref NativeStructures.MC_DISPLAY_TECHNOLOGY_TYPE pdtyDisplayTechnologyType);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorCapabilities", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorCapabilities(IntPtr hMonitor, ref uint pdwMonitorCapabilities, ref uint pdwSupportedColorTemperatures);

        [DllImport("dxva2.dll", EntryPoint = "SetMonitorBrightness", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMonitorBrightness([In]IntPtr hMonitor, [In]uint pdwNewBrightness);
        
        [DllImport("dxva2.dll", EntryPoint = "GetMonitorBrightness", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorBrightness([In]IntPtr hMonitor, ref uint pdwMinimumBrightness, ref uint pdwCurrentBrightness, ref uint pdwMaximumBrightness);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorBrightness", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorBrightness(IntPtr hMonitor, ref short pdwMinimumBrightness, ref short pdwCurrentBrightness, ref short pdwMaximumBrightness);

        [DllImport("dxva2.dll", EntryPoint = "SetMonitorContrast", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMonitorContrast([In]IntPtr hMonitor, [In]uint pdwNewContrast);
        
        [DllImport("dxva2.dll", EntryPoint = "GetMonitorContrast", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorContrast([In]IntPtr hMonitor, ref uint pdwMinimumContrast, ref uint pdwCurrentContrast, ref uint pdwMaximumContrast);

        [DllImport("dxva2.dll", EntryPoint = "SetMonitorRedGreenOrBlueDrive", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMonitorRedGreenOrBlueDrive([In]IntPtr hMonitor, [In]NativeStructures.MC_DRIVE_TYPE dtDriveType, [In]uint pdwNewDrive);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorRedGreenOrBlueDrive", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorRedGreenOrBlueDrive([In]IntPtr hMonitor, [In]NativeStructures.MC_DRIVE_TYPE dtDriveType, ref uint pdwMinimumDrive, ref uint pdwCurrentDrive, ref uint pdwMaximumDrive);

        [DllImport("dxva2.dll", EntryPoint = "SetMonitorRedGreenOrBlueGain", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMonitorRedGreenOrBlueGain([In]IntPtr hMonitor, [In]NativeStructures.MC_GAIN_TYPE dtDriveType, [In]uint pdwNewGain);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorRedGreenOrBlueGain", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorRedGreenOrBlueGain([In]IntPtr hMonitor, [In]NativeStructures.MC_GAIN_TYPE dtDriveType, ref uint pdwMinimumGain, ref uint pdwCurrentGain, ref uint pdwMaximumGain);

        [DllImport("Dxva2.dll", EntryPoint = "GetCapabilitiesStringLength", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCapabilitiesStringLength(IntPtr hMonitor, out uint numCharacters);

        [DllImport("dxva2.dll", EntryPoint = "CapabilitiesRequestAndCapabilitiesReply", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CapabilitiesRequestAndCapabilitiesReply(IntPtr hMonitor, StringBuilder capabilities, uint capabilitiesLength);

        [DllImport("dxva2.dll", EntryPoint = "SetVCPFeature", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVCPFeature([In]IntPtr hMonitor, byte bVCPCode, uint dwNewValue);

        [DllImport("dxva2.dll", EntryPoint = "GetVCPFeatureAndVCPFeatureReply", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVCPFeatureAndVCPFeatureReply([In]IntPtr hMonitor, byte bVCPCode, [Out]IntPtr pvct, ref uint pdwCurrentValue, ref uint pdwMaximumValue);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
    
        public static void ScrollToBottom(System.Windows.Forms.TextBox txtBox)
        {
            // Scroll to the bottom, without moving the caret position.
            NativeMethods.SendMessage(txtBox.Handle, NativeConstants.WM_VSCROLL, (IntPtr) NativeConstants.SB_BOTTOM, IntPtr.Zero);
        }
    }
    
    public class NativeConstants
    {
        public const int MONITOR_DEFAULTTOPRIMARY = 1;
        public const int MONITOR_DEFAULTTONEAREST = 2;
        public const int MONITOR_DEFAULTTONULL = 0;
        
        public const int WM_VSCROLL = 0x115;
        public const int WM_HSCROLL = 0x114;
        public const int WM_SYSCOMMAND = 0x112;

        public const byte SC_MONITORINPUT = 0x60;
        public const byte SC_MONITORVOLUME = 0x62;
        public const byte SC_MONITORPOWER = 0xD6;
        public const int SC_MONITORSHARPNESS = 0x87;
        public const int SC_MONITORSLEEP = 0xF170;

        public const int SB_LINEDOWN = 1;
        public const int SB_LINEUP = 0;
        public const int SB_TOP = 6;
        public const int SB_BOTTOM = 7;
        public const int SB_PAGEUP = 2;
        public const int SB_PAGEDOWN = 3;

        public const int MONITOR_ON = -1;
        public const int MONITOR_OFF = 2;
        public const int MONITOR_STANBY = 1;

        public int HWND_BROADCAST = 0xffff;
        //the message is sent to all 
        //top-level windows in the system

        public int HWND_TOPMOST = -1;
        //the message is sent to one 
        //top-level window in the system

        public int HWND_TOP = 0; //
        public int HWND_BOTTOM = 1; //limited use
        public int HWND_NOTOPMOST = -2; //

        public static readonly string modelPattern = @"model\((.*?)\)";
        // Operates on result of CapabilitiesRequestAndCapabilitiesReply(). Extracts vcp code 60 values into capture group 1.
        public static readonly string vcp60ValuesPattern = @"vcp\((?:.*?\(.*?\))*[^\(\)]*?60 ?\((.*?)\)";
        // Operates on result of CapabilitiesRequestAndCapabilitiesReply(). Extracts the MCCS version.
        public static readonly string mccsVersionPattern = @"mccs_ver\((.*?)\)";
        public static readonly Regex modelRegex = new Regex(modelPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static readonly Regex vcp60ValuesRegex = new Regex(vcp60ValuesPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static readonly Regex mccsVersionRegex = new Regex(mccsVersionPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // Sources in MCCS v2.0 == v2.1, and both are a subset of 2.2, so we use a single array to cover them all.
        // Note that the standards use one-based indexing, so we just add a dummy element at the start.
        public static readonly string[] sourceNamesMccsV2 = {
            "**undefined**",
            "VGA 1",
            "VGA 2",
            "DVI 1",
            "DVI 2",
            "Composite 1",
            "Composite 2",
            "S-video 1",
            "S-video 2",
            "Tuner 1",
            "Tuner 2",
            "Tuner 3",
            "Component 1",
            "Component 2",
            "Component 3",
            "DisplayPort 1",
            "DisplayPort 2",
            "HDMI 1",
            "HDMI 2"
        };

        // Note that MCCS v3.0 was not well adopted, so 2.2a has become the active standard.
        // Note that the standards use one-based indexing, so we just add a dummy element at the start.
        public static readonly string[] sourceNamesMccsV3 = {
            "**undefined**",
            "VGA 1",
            "VGA 2",
            "DVI 1",
            "DVI 2",
            "Composite 1",
            "Composite 2",
            "S-video 1",
            "S-video 2",
            "Tuner - Analog 1",
            "Tuner - Analog 2",
            "Tuner - Digital 1",
            "Tuner - Digital 2",
            "Component 1",
            "Component 2",
            "Component 3",
            "**Unrecognized**",
            "DisplayPort 1",
            "DisplayPort 2"
        };
    }

    public class NativeStructures
    {
        internal struct MonitorSource
        {
            public int code;
            public string name;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct PHYSICAL_MONITOR
        {
            public IntPtr hPhysicalMonitor;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szPhysicalMonitorDescription;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class MonitorInfoEx
        {
            public int cbSize;
            public RECT rcMonitor; // Total area  
            public RECT rcWork; // Working area  
            public int dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szDeviceName; 
        }

        public enum MC_DISPLAY_TECHNOLOGY_TYPE
        {
            MC_SHADOW_MASK_CATHODE_RAY_TUBE,
            MC_APERTURE_GRILL_CATHODE_RAY_TUBE,
            MC_THIN_FILM_TRANSISTOR,
            MC_LIQUID_CRYSTAL_ON_SILICON,
            MC_PLASMA,
            MC_ORGANIC_LIGHT_EMITTING_DIODE,
            MC_ELECTROLUMINESCENT,
            MC_MICROELECTROMECHANICAL,
            MC_FIELD_EMISSION_DEVICE,
        }

        public enum MC_VCP_CODE_TYPE
        {
            MC_MOMENTARY,
            MC_SET_PARAMETER,
        }

        public enum MC_MONITOR_CAPABILITIES
        {
            MC_CAPS_NONE = 0x00000000,
            MC_CAPS_MONITOR_TECHNOLOGY_TYPE = 0x00000001,
            MC_CAPS_BRIGHTNESS = 0x00000002,
            MC_CAPS_CONTRAST = 0x00000004,
            MC_CAPS_COLOR_TEMPERATURE = 0x00000008,
            MC_CAPS_RED_GREEN_BLUE_GAIN = 0x00000010,
            MC_CAPS_RED_GREEN_BLUE_DRIVE = 0x00000020,
            MC_CAPS_DEGAUSS = 0x00000040,
            MC_CAPS_DISPLAY_AREA_POSITION = 0x00000080,
            MC_CAPS_DISPLAY_AREA_SIZE = 0x00000100,
            MC_CAPS_RESTORE_FACTORY_DEFAULTS = 0x00000400,
            MC_CAPS_RESTORE_FACTORY_COLOR_DEFAULTS = 0x00000800,
            MC_RESTORE_FACTORY_DEFAULTS_ENABLES_MONITOR_SETTINGS = 0x00001000
        }

        public enum MC_DRIVE_TYPE
        {
            MC_RED_DRIVE = 0,
            MC_GREEN_DRIVE = 1,
            MC_BLUE_DRIVE = 2
        }

        public enum MC_GAIN_TYPE
        {
            MC_RED_GAIN = 0,
            MC_GREEN_GAIN = 1,
            MC_BLUE_GAIN = 2
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DISPLAY_DEVICE
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cb;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DeviceName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceString;
            [MarshalAs(UnmanagedType.U4)]
            public DisplayDeviceStateFlags StateFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceKey;
        }

        [Flags()]
        public enum DisplayDeviceStateFlags : int
        {
            /// <summary>The device is part of the desktop.</summary>
            AttachedToDesktop = 0x1,
            MultiDriver = 0x2,
            /// <summary>The device is part of the desktop.</summary>
            PrimaryDevice = 0x4,
            /// <summary>Represents a pseudo device used to mirror application drawing for remoting or other purposes.</summary>
            MirroringDriver = 0x8,
            /// <summary>The device is VGA compatible.</summary>
            VGACompatible = 0x16,
            /// <summary>The device is removable; it cannot be the primary display.</summary>
            Removable = 0x20,
            /// <summary>The device has more display modes than its output devices support.</summary>
            ModesPruned = 0x8000000,
            Remote = 0x4000000,
            Disconnect = 0x2000000
        }
    }
}