using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonitorProfiler.Models.Configuration;
using System.Xml.Serialization;
using System.IO;
using MonitorProfiler.Win32;
using System.Runtime.InteropServices;

namespace TestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var device = new NativeStructures.DISPLAY_DEVICE();
            device.cb = Marshal.SizeOf(device);
            for (uint id = 0; NativeMethods.EnumDisplayDevices(null, id, ref device, 0); id++)
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", 
                    id, device.DeviceName, device.DeviceString, device.StateFlags, device.DeviceID, device.DeviceKey));
                Console.WriteLine();
                device.cb = Marshal.SizeOf(device);

                NativeMethods.EnumDisplayDevices(device.DeviceName, 0, ref device, 0);

                Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", 
                    id, device.DeviceName, device.DeviceString, device.StateFlags, device.DeviceID, device.DeviceKey));
                device.cb = Marshal.SizeOf(device);

                Console.WriteLine("--------------");
                //return;
            }

            Console.ReadKey();
        }
    }
}
