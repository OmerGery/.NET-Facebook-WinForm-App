using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Logic
{
    public sealed class AppSettings : IExitObserver
    {
        public string LastAccessToken { get; set; }

        public bool RememberUser { get; }

        public bool IsMockState { get; set; }

        public Size LastWindowsSize { get; set; }

        public Point LastWindowsLocation { get; set; }

        private static readonly string sr_AppSettingsFilePath = Directory.GetCurrentDirectory() + "\\appsettings.xml";
        private ExitNotifier m_ExitNotifer = new ExitNotifier();
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
            m_ExitNotifer.ExitClicked += UpdateExited;
            RememberUser = false;
            LastAccessToken = null;
            LastWindowsSize = new Size(870, 650);
            LastWindowsLocation = new Point(50, 50);
        }

        public void UpdateExited()
        {
            using(Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
