using Decal.Adapter.Wrappers;
using System;

namespace EdsACPlugin
{
    public partial class PluginCore
    {
        private void initCharStats()
        {
            //////////////////////////////////////////////////////////////
            // To initialize any of the CharacterStats Filter Events,   //
            // simply uncomment the appropriate initialization          //
            // statement(s) below to enable the event handler           //
            //                                                          //
            // Don't forget to uncomment the UnInit statement in the    //
            // destroyCharStats() function if you uncomment the init    //
            // function                                                 //
            //////////////////////////////////////////////////////////////

            // Initialize the StatusMessage event handler
            Core.CharacterFilter.StatusMessage += new EventHandler<StatusMessageEventArgs>(CharacterFilter_StatusMessage);
            
            // Initialize the SpellbookChange event handler
            Core.CharacterFilter.SpellbookChange += new EventHandler<SpellbookEventArgs>(CharacterFilter_SpellbookChange);
            
            // Initialize the Logoff event handler
            Core.CharacterFilter.Logoff += new EventHandler<LogoffEventArgs>(CharacterFilter_Logoff);
            
            // Initialize the LoginComplete event handler
            Core.CharacterFilter.LoginComplete += new EventHandler(CharacterFilter_LoginComplete);
            
            // Initialize the Login event handler
            Core.CharacterFilter.Login += new EventHandler<LoginEventArgs>(CharacterFilter_Login);
            
            // Initialize the Death event handler
            Core.CharacterFilter.Death += new EventHandler<DeathEventArgs>(CharacterFilter_Death);
            
            // Initialize the ChangeExperience event handler
            Core.CharacterFilter.ChangeExperience += new EventHandler<ChangeExperienceEventArgs>(CharacterFilter_ChangeExperience);
            
            // Initialize the ChangeVital event handler
            Core.CharacterFilter.ChangeVital += new EventHandler<ChangeVitalEventArgs>(CharacterFilter_ChangeVital);

            // Initialize the ChageSpellbar event handler
            Core.CharacterFilter.ChangeSpellbar += new EventHandler<ChangeSpellbarEventArgs>(CharacterFilter_ChangeSpellbar);

            // Initialize the ChangeShortcut event handler
            Core.CharacterFilter.ChangeShortcut += new EventHandler<ChangeShortcutEventArgs>(CharacterFilter_ChangeShortcut);

            // Initialize the ChageSettings event handler
            Core.CharacterFilter.ChangeSettings += new EventHandler<SettingsEventArgs>(CharacterFilter_ChangeSettings);

            // Initialize the ChangePortalMode event handler
            Core.CharacterFilter.ChangePortalMode += new EventHandler<ChangePortalModeEventArgs>(CharacterFilter_ChangePortalMode);

            // Initialize the ChangePlayer event handler
            Core.CharacterFilter.ChangePlayer += new EventHandler<ChangePlayerEventArgs>(CharacterFilter_ChangePlayer);

            // Initialize the ChangeFellowship event handler
            Core.CharacterFilter.ChangeFellowship += new EventHandler<ChangeFellowshipEventArgs>(CharacterFilter_ChangeFellowship);

            // Initialize the ChangeEnchantments event handler
            Core.CharacterFilter.ChangeEnchantments += new EventHandler<ChangeEnchantmentsEventArgs>(CharacterFilter_ChangeEnchantments);

            // Initialize the SpellCast event handler
            Core.CharacterFilter.SpellCast += new EventHandler<SpellCastEventArgs>(CharacterFilter_SpellCast);

            // Initialize the ActionComplete event handler
            Core.CharacterFilter.ActionComplete += new EventHandler(CharacterFilter_ActionComplete);
        }

        private void destroyCharStats()
        {
            // UnInitialize the StatusMessage event handler
            Core.CharacterFilter.StatusMessage -= new EventHandler<StatusMessageEventArgs>(CharacterFilter_StatusMessage);

            // UnInitialize the SpellbookChange event handler
            Core.CharacterFilter.SpellbookChange -= new EventHandler<SpellbookEventArgs>(CharacterFilter_SpellbookChange);

            // UnInitialize the Logoff event handler
            Core.CharacterFilter.Logoff -= new EventHandler<LogoffEventArgs>(CharacterFilter_Logoff);

            // UnInitialize the LoginComplete event handler
            Core.CharacterFilter.LoginComplete -= new EventHandler(CharacterFilter_LoginComplete);

            // UnInitialize the Login event handler
            Core.CharacterFilter.Login -= new EventHandler<LoginEventArgs>(CharacterFilter_Login);

            // UnInitialize the Death event handler
            Core.CharacterFilter.Death -= new EventHandler<DeathEventArgs>(CharacterFilter_Death);

            // UnInitialize the ChangeExperience event handler
            Core.CharacterFilter.ChangeExperience -= new EventHandler<ChangeExperienceEventArgs>(CharacterFilter_ChangeExperience);

            // UnInitialize the ChangeVital event handler
            Core.CharacterFilter.ChangeVital -= new EventHandler<ChangeVitalEventArgs>(CharacterFilter_ChangeVital);

            // UnInitialize the ChageSpellbar event handler
            Core.CharacterFilter.ChangeSpellbar -= new EventHandler<ChangeSpellbarEventArgs>(CharacterFilter_ChangeSpellbar);

            // UnInitialize the ChangeShortcut event handler
            Core.CharacterFilter.ChangeShortcut -= new EventHandler<ChangeShortcutEventArgs>(CharacterFilter_ChangeShortcut);

            // UnInitialize the ChageSettings event handler
            Core.CharacterFilter.ChangeSettings -= new EventHandler<SettingsEventArgs>(CharacterFilter_ChangeSettings);

            // UnInitialize the ChangePortalMode event handler
            Core.CharacterFilter.ChangePortalMode -= new EventHandler<ChangePortalModeEventArgs>(CharacterFilter_ChangePortalMode);

            // UnInitialize the ChangePlayer event handler
            Core.CharacterFilter.ChangePlayer -= new EventHandler<ChangePlayerEventArgs>(CharacterFilter_ChangePlayer);

            // UnInitialize the ChangeFellowship event handler
            Core.CharacterFilter.ChangeFellowship -= new EventHandler<ChangeFellowshipEventArgs>(CharacterFilter_ChangeFellowship);

            // UnInitialize the ChangeEnchantments event handler
            Core.CharacterFilter.ChangeEnchantments -= new EventHandler<ChangeEnchantmentsEventArgs>(CharacterFilter_ChangeEnchantments);

            // UnInitialize the SpellCast event handler
            Core.CharacterFilter.SpellCast -= new EventHandler<SpellCastEventArgs>(CharacterFilter_SpellCast);

            // UnInitialize the ActionComplete event handler
            Core.CharacterFilter.ActionComplete -= new EventHandler(CharacterFilter_ActionComplete);
        }

        void CharacterFilter_ActionComplete(object sender, EventArgs e)
        {
            wtc("CF_ActionComplete");
            wtc($"e: {e}");
            wtc($"e.GetType: {e.GetType()}");
            wtc($"e.GetHashCode: {e.GetHashCode()}");
            
        }

        void CharacterFilter_SpellCast(object sender, SpellCastEventArgs e)
        {
            wtc("CF_SpellCast");
            wtc(e.ToString());
        }

        void CharacterFilter_ChangeEnchantments(object sender, ChangeEnchantmentsEventArgs e)
        {
            wtc("CF_ChangeEnchantments");
            // I bet I can do this:
            //
            int spellIdChanging = e.Enchantment.SpellId;
            wtc("e.Type: " + e.Type.ToString());
            wtc("e.Enchantment: " + e.Enchantment.ToString());
            try
            {

                wtc($"Looked up spell: {spells.getByID(e.Enchantment.SpellId)}");
            } catch (Exception ex)
            {
                wtc(ex.Message);
            }
        }

        void CharacterFilter_ChangeFellowship(object sender, ChangeFellowshipEventArgs e)
        {
            wtc("CF_ChangeFellowship");
            wtc(e.ToString());
        }

        void CharacterFilter_ChangePlayer(object sender, ChangePlayerEventArgs e)
        {
            
            // Notes for usages:
            // Look under PlayerModifyEventType ... that will come here as e.Type.
            // e.Stat will map to a <type>Key enum, that will tell you what it is that changed.

            if (e.Type == PlayerModifyEventType.Statistic)
            {
                if (e.Stat == (int)LongValueKey.Age)
                {
                    // This is updating Core.CharFilter.Age.
                    // If you wanted to:
                    // Character age in seconds is given by:
                    // Core.CharacterFilter.Age
                    // for giggles...
                    // TODO: Add something in config to enable / disable this display...
                    // for now, just enable it with debug...
                    if (FEELING_CHEEKY)
                    {
                        int ageInSeconds = Core.CharacterFilter.Age;
                        int hours = (int)Math.Floor(ageInSeconds / (60.0 * 60.0));
                        int minutes = (int)Math.Floor(ageInSeconds / 60.0) - (60 * hours);
                        int seconds = ageInSeconds - (60 * minutes) - (60 * 60 * hours);
                        wtc($"You have played for {hours} hour(s) {minutes} minutes {seconds} seconds.");
                    }
                }
            } else
            {
                wtc("CF_ChangePlayer");
                wtc("e.Type: " + e.Type.ToString());
                wtc("e.Stat: " + e.Stat.ToString());
            }
        }

        void CharacterFilter_ChangePortalMode(object sender, ChangePortalModeEventArgs e)
        {
            wtc("CF_ChangePortalMode");
            wtc(e.ToString());
        }

        void CharacterFilter_ChangeSettings(object sender, SettingsEventArgs e)
        {
            wtc("CF_ChangeSettings");
            wtc(e.ToString());
        }

        void CharacterFilter_ChangeShortcut(object sender, ChangeShortcutEventArgs e)
        {
            wtc("CF_ChangeShortcut");
            wtc(e.ToString());
        }

        void CharacterFilter_ChangeSpellbar(object sender, ChangeSpellbarEventArgs e)
        {
            wtc("CF_ChangeSpellbar");
            wtc(e.ToString());
        }

        void CharacterFilter_ChangeVital(object sender, ChangeVitalEventArgs e)
        {
            wtc("CF_ChangeVital");
            wtc(e.ToString());
        }

        void CharacterFilter_ChangeExperience(object sender, ChangeExperienceEventArgs e)
        {
            wtc("CF_ChangeExperience");
            wtc(e.ToString());
        }

        void CharacterFilter_Death(object sender, DeathEventArgs e)
        {
            wtc("CF_Death");
            wtc(e.ToString());
        }

        void CharacterFilter_Login(object sender, LoginEventArgs e)
        {
            wtc("CF_Login");
            wtc(e.ToString());
        }

        void CharacterFilter_LoginComplete(object sender, EventArgs e)
        {
            loadSettings();
            wtc("CF_LoginComplete");
            wtc(e.ToString());
        }

        void CharacterFilter_Logoff(object sender, LogoffEventArgs e)
        {
            wtc("CF_Logoff");
            wtc(e.ToString());
        }

        void CharacterFilter_SpellbookChange(object sender, SpellbookEventArgs e)
        {
            wtc("CF_SpellbookChange");
            wtc(e.ToString());
        }

        void CharacterFilter_StatusMessage(object sender, StatusMessageEventArgs e)
        {
            wtc("CF_StatusMessage");
            wtc(e.ToString());
        }
    }
}