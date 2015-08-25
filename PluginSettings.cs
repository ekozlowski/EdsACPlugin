/* Plugin created by $username$ $year$ */

using System;
using System.IO;
using System.Xml.Serialization;

namespace $safeprojectname$
{
    public partial class PluginCore
    {
        public PluginSettings pluginSettings;

        private void loadSettings()
        {
            pluginSettings = PluginSettings.load(settingsFolder + DIR_SEP + FILENAME_SETTINGS, errorLogFile);
            initSettings();
        }

        private void saveSettings()
        {
            pluginSettings.save(settingsFolder + DIR_SEP + FILENAME_SETTINGS, errorLogFile);
        }
    
        private void initSettings()
        {
            /* INITIALISE THE STATE OF VIEW ELEMENTS HERE */            
        }
    }

    public class PluginSettings
    {
        /* ADD PUBLIC PROPERTIES FOR PERSISTABLE SETTINGS HERE */
        
        public PluginSettings()
        {
            /* SET DEFAULTS FOR THE PROPERTIES HERE */
        }

        public static PluginSettings load(string file, string errorLogFile)
        {
            try
            {
                if (File.Exists(file))
                {
                    using (FileStream myFileStream = new FileStream(file, FileMode.Open))
                    {
                        XmlSerializer mySerializer = new XmlSerializer(typeof(PluginSettings));
                        PluginSettings mySettings = (PluginSettings)mySerializer.Deserialize(myFileStream);
                        myFileStream.Close();
                        return mySettings;
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(errorLogFile, ex);
            }
            return new PluginSettings();
        }

        public void save(string file, string errorLogFile)
        {
            try
            {
                using (StreamWriter myWriter = new StreamWriter(file))
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(PluginSettings));
                    myWriter.AutoFlush = true;
                    mySerializer.Serialize(myWriter, this);
                    myWriter.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(errorLogFile, ex);
            }
        }
    }
}