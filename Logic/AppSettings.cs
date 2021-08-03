using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Logic
{
    public sealed class AppSettings
    {
        public static AppSettings Instance { get; } = new AppSettings();

        public string m_LastAccessToken { get; set; }

        public bool m_RememberUser { get; set; }

        public Size m_LastWindowsSize { get; set; }

        public Point m_LastWindowsLocation { get; set; }

        private static readonly string sr_AppSettingsFilePath = Directory.GetCurrentDirectory() + "\\appsettings.xml";

        public static AppSettings LoadSettingsFromFile()
        {
            AppSettings appSettings; 
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

        private AppSettings()
        {
            m_LastAccessToken = null;
            m_RememberUser = false;
            m_LastWindowsSize = new Size(870, 650);
            m_LastWindowsLocation = new Point(50, 50);
        }

        public void SaveSettingsToFile()
        {
            using(Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
