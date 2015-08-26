/* Plugin template by Timo 'lino' Kissing <http://ac.ranta.info/DecalDev> */
/* Original template by Lonewolf <http://www.the-lonewolf.com> */

using Decal.Adapter;
using System;
using System.IO;

namespace EdsACPlugin
{
    public partial class PluginCore : PluginBase
    {
        
        private static string DIR_SEP = "\\";
        private static string PLUGIN = "EdsACPlugin";

        private static string FILENAME_ERRORLOG = "errorlog.txt";
        private static string FILENAME_SETTINGS = "settings.xml";
        
        public string settingsFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + DIR_SEP + "Decal Plugins" + DIR_SEP + PLUGIN;
            }
        }

        public string errorLogFile { get { return settingsFolder + DIR_SEP + FILENAME_ERRORLOG; } }        

        protected override void Startup()
        {
            try
            {
                initCharStats();
                initWorldFilter();
                initChatEvents();
                
                initPath();
                
                //TODO: Code for startup events
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(errorLogFile, ex);
            }
        }

        protected override void Shutdown()
        {
            try
            {
                saveSettings();
                
                destroyChatEvents();
                destroyCharStats();
                destroyWorldFilter();
                //TODO: Code for shutdown events
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(errorLogFile, ex);
            }
        }
    
        protected void initPath()
        {
            if (!Directory.Exists(settingsFolder))
            {
                try
                {
                    Directory.CreateDirectory(settingsFolder);
                }
                catch(Exception ex)
                {
                    ErrorLogging.LogError("c:\\EdsACPlugin-errorlog.txt", ex);
                }
                
            }            
        }    
    
    }
}