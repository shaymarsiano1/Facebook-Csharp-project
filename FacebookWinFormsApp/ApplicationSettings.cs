using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class ApplicationSettings
    {
        public bool RememberUser { get; set; }
        public Size LastWindowSize { get; set; }
        public Point LastWindowLocation { get; set; }
        public string LastUserAccessToken { get; set; }

        private ApplicationSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1000, 500);
            RememberUser = false;
            LastUserAccessToken = null;
        }

        public void SaveSettingsToFile()
        {
            string path = Path.Combine(Application.StartupPath, "AppSettings.xml");

            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static ApplicationSettings LoadSettingFromFile()
        {
            ApplicationSettings settings = new ApplicationSettings();
            string path = Path.Combine(Application.StartupPath, "AppSettings.xml");

            if (File.Exists(path) == true) 
            {
                try
                {
                    using (Stream stream = new FileStream(path, FileMode.Open))
                    {
                        XmlSerializer deserializer = new XmlSerializer(typeof(ApplicationSettings));
                        settings = deserializer.Deserialize(stream) as ApplicationSettings;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading settings, default settings will be used.");
                }
            }

            return settings;
        }
    }
}