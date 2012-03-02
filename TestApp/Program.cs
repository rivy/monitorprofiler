using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonitorProfiler.Models.Configuration;
using System.Xml.Serialization;
using System.IO;

namespace TestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var config = new Config
            {
                Profiles = new List<Profile>
                {
                    new Profile{ Name = "One", MonitorConfigs = new List<MonitorConfig>
                    {
                        new MonitorConfig{Index = 0, Brightness = 30, Contrast = 18}} 
                    },
                    new Profile{ Name = "Two", MonitorConfigs = new List<MonitorConfig>
                    {
                        new MonitorConfig{Index = 0, Brightness = 15, Contrast = 18}} 
                    },
                }
            };


            var xmlSerializer = new XmlSerializer(typeof(Config));
            using (var stream = new MemoryStream())
            {
                xmlSerializer.Serialize(stream, config);
                stream.Position = 0;
                var reader = new StreamReader(stream);

                var s = reader.ReadToEnd();
            }
        }
    }
}
