/* Plugin template by Timo 'lino' Kissing <http://ac.ranta.info/DecalDev> */
/* Original template by Lonewolf <http://www.the-lonewolf.com> */

using Decal.Adapter;
using Decal.Adapter.Wrappers;
using System;
using System.IO;

namespace EdsACPlugin
{

    public partial class PluginCore : PluginBase
    {
        // FEELING_CHEEKY enables all the "oddities" in the plugin... like displaying your character's playtime
        // every time it receives the event... just fun "odd" things....
        private static bool FEELING_CHEEKY = false;  
        private static Spells spells;
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
                spells = new Spells();
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

        private void outputObjectPropsToChat(WorldObject o)
        {
            // so far, I know o.Type is the weenieId of the object.
            WriteToChat("--------------B - E - G - I - N -----------------------------");
            WriteToChat("          o.Name: " + o.Name);
            WriteToChat("            o.Id: " + o.Id);
            WriteToChat("          o.Type: " + o.Type); // <-- I bet this is the "WeenieId"
            WriteToChat("   Active Spells:");
            WriteToChat("  --------------");
            for (int i = 0; i < o.ActiveSpellCount; i++)
            {
                WriteToChat(o.ActiveSpell(i).ToString());
            }
            WriteToChat("  --------------");
            WriteToChat("      o.Behavior: " + o.Behavior.ToString());
            WriteToChat("      o.BoolKeys: " + o.BoolKeys.ToString());
            WriteToChat("--- o.BoolKeys ---");
            foreach (int x in o.BoolKeys)
            {
                WriteToChat(x.ToString());
            }
            WriteToChat("---");
            WriteToChat("      o.Category: " + o.Category.ToString());
            // Alinco has some logic about "container" ... like Chests and Toon...
            WriteToChat("     o.Container: " + o.Container.ToString());
            WriteToChat("   o.Coordinates: " + o.Coordinates().ToString());
            //WriteToChat("o.CreateObjRef looks like a _utility_ method I might need....");
            //WriteToChat("o." + o.Dispose());  o.Dispose() looks like utility.
            WriteToChat("    o.DoubleKeys: " + o.DoubleKeys.ToString());
            WriteToChat("--- o.DoubleKeys ---");
            foreach (int x in o.DoubleKeys)
            {
                WriteToChat(x.ToString());
            }
            WriteToChat("---");
            // DoubleKeys and BoolKeys might be _collections_... like in the Tank attrs...
            WriteToChat("o.GameDataFlags1: " + o.GameDataFlags1.ToString());
            WriteToChat("     o.HasIdData: " + o.HasIdData.ToString()); // alinco has some logic around hasIdData
            WriteToChat("          o.Icon: " + o.Icon.ToString());
            WriteToChat("    o.LastIdTime: " + o.LastIdTime.ToString());
            WriteToChat("----- LongKeys -----");
            foreach (long x in o.LongKeys)
            {
                WriteToChat(x.ToString());
            }
            WriteToChat("----- /LongKeys -----");
            WriteToChat("      o.LongKeys: " + o.LongKeys.ToString()); // probably another place spells and such are...
            WriteToChat("   o.ObjectClass: " + o.ObjectClass.ToString());
            /// Alinco has a "If this object is in the world detection..."
            //
            if (o.Container == 0)  // container = 0 if it's in the "game world" 
            {
                WriteToChat("      o.Offset(): " + o.Offset().ToString()); // offset in Landblock
                WriteToChat(" o.Orientation(): " + o.Orientation().ToString());
            }
            WriteToChat("o.PhysicsDataFlags(): " + o.PhysicsDataFlags.ToString());
            WriteToChat("o.RawCoordinates(): " + o.RawCoordinates().ToString());
            WriteToChat("o.SpellCount.ToString():" + o.SpellCount.ToString());
            WriteToChat("----- ActiveSpells -----");
            if (o.ActiveSpellCount > 0)
            {
                for (int i = 0; i < o.ActiveSpellCount; i++)
                {
                    WriteToChat(o.ActiveSpell(i).ToString());
                }
            }
            WriteToChat("----- /ActiveSpells -----");
            WriteToChat("o.ToString: " + o.ToString());
            WriteToChat("o.Type.ToString(): " + o.Type.ToString());
            WriteToChat("--- StringKeys ---");
            foreach (int key in o.StringKeys)
            {
                WriteToChat(key.ToString());
            }
            WriteToChat("--- End StringKeys ---");
            // So, o.Values() is _odd_...
            // o.Values() takes a BoolValueKey index... huh?
            // I'm assuming it's like '10010010' like a boolean "Key index" mask.
            WriteToChat("--------------E - N - D-------------------------------------");
        }

    }
}