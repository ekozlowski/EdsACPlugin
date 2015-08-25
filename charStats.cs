using Decal.Adapter;
using Decal.Adapter.Wrappers;
using System;

namespace $safeprojectname$
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
            // Core.CharacterFilter.StatusMessage += new EventHandler<StatusMessageEventArgs>(CharacterFilter_StatusMessage);
            
            // Initialize the SpellbookChange event handler
            // Core.CharacterFilter.SpellbookChange += new EventHandler<SpellbookEventArgs>(CharacterFilter_SpellbookChange);
            
            // Initialize the Logoff event handler
            // Core.CharacterFilter.Logoff += new EventHandler<LogoffEventArgs>(CharacterFilter_Logoff);
            
            // Initialize the LoginComplete event handler
            Core.CharacterFilter.LoginComplete += new EventHandler(CharacterFilter_LoginComplete);
            
            // Initialize the Login event handler
            // Core.CharacterFilter.Login += new EventHandler<LoginEventArgs>(CharacterFilter_Login);
            
            // Initialize the Death event handler
            // Core.CharacterFilter.Death += new EventHandler<DeathEventArgs>(CharacterFilter_Death);
            
            // Initialize the ChangeExperience event handler
            // Core.CharacterFilter.ChangeExperience += new EventHandler<ChangeExperienceEventArgs>(CharacterFilter_ChangeExperience);
            
            // Initialize the ChangeVital event handler
            // Core.CharacterFilter.ChangeVital += new EventHandler<ChangeVitalEventArgs>(CharacterFilter_ChangeVital);

            // Initialize the ChageSpellbar event handler
            // Core.CharacterFilter.ChangeSpellbar += new EventHandler<ChangeSpellbarEventArgs>(CharacterFilter_ChangeSpellbar);

            // Initialize the ChangeShortcut event handler
            // Core.CharacterFilter.ChangeShortcut += new EventHandler<ChangeShortcutEventArgs>(CharacterFilter_ChangeShortcut);

            // Initialize the ChageSettings event handler
            // Core.CharacterFilter.ChangeSettings += new EventHandler<SettingsEventArgs>(CharacterFilter_ChangeSettings);

            // Initialize the ChangePortalMode event handler
            // Core.CharacterFilter.ChangePortalMode += new EventHandler<ChangePortalModeEventArgs>(CharacterFilter_ChangePortalMode);

            // Initialize the ChangePlayer event handler
            // Core.CharacterFilter.ChangePlayer += new EventHandler<ChangePlayerEventArgs>(CharacterFilter_ChangePlayer);

            // Initialize the ChangeFellowship event handler
            // Core.CharacterFilter.ChangeFellowship += new EventHandler<ChangeFellowshipEventArgs>(CharacterFilter_ChangeFellowship);

            // Initialize the ChangeEnchantments event handler
            // Core.CharacterFilter.ChangeEnchantments += new EventHandler<ChangeEnchantmentsEventArgs>(CharacterFilter_ChangeEnchantments);

            // Initialize the SpellCast event handler
            // Core.CharacterFilter.SpellCast += new EventHandler<SpellCastEventArgs>(CharacterFilter_SpellCast);

            // Initialize the ActionComplete event handler
            // Core.CharacterFilter.ActionComplete += new EventHandler(CharacterFilter_ActionComplete);
        }

        private void destroyCharStats()
        {
            // UnInitialize the StatusMessage event handler
            // Core.CharacterFilter.StatusMessage -= new EventHandler<StatusMessageEventArgs>(CharacterFilter_StatusMessage);

            // UnInitialize the SpellbookChange event handler
            // Core.CharacterFilter.SpellbookChange -= new EventHandler<SpellbookEventArgs>(CharacterFilter_SpellbookChange);

            // UnInitialize the Logoff event handler
            // Core.CharacterFilter.Logoff -= new EventHandler<LogoffEventArgs>(CharacterFilter_Logoff);

            // UnInitialize the LoginComplete event handler
            Core.CharacterFilter.LoginComplete -= new EventHandler(CharacterFilter_LoginComplete);

            // UnInitialize the Login event handler
            // Core.CharacterFilter.Login -= new EventHandler<LoginEventArgs>(CharacterFilter_Login);

            // UnInitialize the Death event handler
            // Core.CharacterFilter.Death -= new EventHandler<DeathEventArgs>(CharacterFilter_Death);

            // UnInitialize the ChangeExperience event handler
            // Core.CharacterFilter.ChangeExperience -= new EventHandler<ChangeExperienceEventArgs>(CharacterFilter_ChangeExperience);

            // UnInitialize the ChangeVital event handler
            // Core.CharacterFilter.ChangeVital -= new EventHandler<ChangeVitalEventArgs>(CharacterFilter_ChangeVital);

            // UnInitialize the ChageSpellbar event handler
            // Core.CharacterFilter.ChangeSpellbar -= new EventHandler<ChangeSpellbarEventArgs>(CharacterFilter_ChangeSpellbar);

            // UnInitialize the ChangeShortcut event handler
            // Core.CharacterFilter.ChangeShortcut -= new EventHandler<ChangeShortcutEventArgs>(CharacterFilter_ChangeShortcut);

            // UnInitialize the ChageSettings event handler
            // Core.CharacterFilter.ChangeSettings -= new EventHandler<SettingsEventArgs>(CharacterFilter_ChangeSettings);

            // UnInitialize the ChangePortalMode event handler
            // Core.CharacterFilter.ChangePortalMode -= new EventHandler<ChangePortalModeEventArgs>(CharacterFilter_ChangePortalMode);

            // UnInitialize the ChangePlayer event handler
            // Core.CharacterFilter.ChangePlayer -= new EventHandler<ChangePlayerEventArgs>(CharacterFilter_ChangePlayer);

            // UnInitialize the ChangeFellowship event handler
            // Core.CharacterFilter.ChangeFellowship -= new EventHandler<ChangeFellowshipEventArgs>(CharacterFilter_ChangeFellowship);

            // UnInitialize the ChangeEnchantments event handler
            // Core.CharacterFilter.ChangeEnchantments -= new EventHandler<ChangeEnchantmentsEventArgs>(CharacterFilter_ChangeEnchantments);

            // UnInitialize the SpellCast event handler
            // Core.CharacterFilter.SpellCast -= new EventHandler<SpellCastEventArgs>(CharacterFilter_SpellCast);

            // UnInitialize the ActionComplete event handler
            // Core.CharacterFilter.ActionComplete -= new EventHandler(CharacterFilter_ActionComplete);
        }

        void CharacterFilter_ActionComplete(object sender, EventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_SpellCast(object sender, SpellCastEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangeEnchantments(object sender, ChangeEnchantmentsEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangeFellowship(object sender, ChangeFellowshipEventArgs e)
        {
            // DO STUFF HERE        
        }

        void CharacterFilter_ChangePlayer(object sender, ChangePlayerEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangePortalMode(object sender, ChangePortalModeEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangeSettings(object sender, SettingsEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangeShortcut(object sender, ChangeShortcutEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangeSpellbar(object sender, ChangeSpellbarEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangeVital(object sender, ChangeVitalEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_ChangeExperience(object sender, ChangeExperienceEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_Death(object sender, DeathEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_Login(object sender, LoginEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_LoginComplete(object sender, EventArgs e)
        {
            loadSettings();
            // DO STUFF HERE
        }

        void CharacterFilter_Logoff(object sender, LogoffEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_SpellbookChange(object sender, SpellbookEventArgs e)
        {
            // DO STUFF HERE
        }

        void CharacterFilter_StatusMessage(object sender, StatusMessageEventArgs e)
        {
            // DO STUFF HERE
        }
    }
}