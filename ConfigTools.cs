using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Werbas_ConfigEditor
{
    public class ConfigTools
    {
        public static Config LoadConfig(string Filename)
        {
            if (!File.Exists("config.xml"))
                return null;

            XmlSerializer serializer = new(typeof(Config));

            using FileStream fs = new(Filename, FileMode.Open);
            return (Config)serializer.Deserialize(fs);
        }

        public static void SaveConfig(Config cfg, string Filename)
        {
            XmlSerializer serializer = new(typeof(Config));

            using (TextWriter tw = new StreamWriter(Filename))
            {
                serializer.Serialize(tw, cfg);
                tw.Close();
            }

        }

    }
}
