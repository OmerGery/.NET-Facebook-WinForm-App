﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public string m_LastAccessToken { get; set; }
        public bool m_RememberUser { get; set; }
        public Size m_LastWindowsSize { get; set; }
        public Point m_LastWindowsLocation { get; set; }

        private static readonly string  sr_AppSettingsFilePath = Directory.GetCurrentDirectory() + "\\appsettings.xml";

        public AppSettings()
        {
            m_LastAccessToken = null;
            m_RememberUser = false;
            m_LastWindowsSize = new Size(870, 650);
            m_LastWindowsLocation = new Point(50, 50);
        }

        public void SaveSettingsToFile()
        { 
            using (Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Create, FileAccess.ReadWrite))
            { 
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize( stream, this);
            }
        }

        public static AppSettings LoadSettingsFromFile()
        {
            AppSettings appSettings = null;
            if(File.Exists(sr_AppSettingsFilePath))
            {
                using(Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }
    }
}
