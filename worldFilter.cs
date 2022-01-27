using Decal.Adapter.Wrappers;
using Decal.Interop.D3DService;
using System;
using System.Media;

namespace EdsACPlugin
{
    public partial class PluginCore
    {
        private void initWorldFilter()
        {
            //////////////////////////////////////////////////////////////
            // To initialize any of the World Filter Events,            //
            // simply uncomment the appropriate initialization          //
            // statement(s) below to enable the event handler           //
            //////////////////////////////////////////////////////////////

            // Initialize the ResetTrade event handler
            Core.WorldFilter.ResetTrade += new EventHandler<ResetTradeEventArgs>(WorldFilter_ResetTrade);

            // Initialize the ReleaseObject event handler
            Core.WorldFilter.ReleaseObject += new EventHandler<ReleaseObjectEventArgs>(WorldFilter_ReleaseObject);

            // Initialize the ReleaseDone event handler
            Core.WorldFilter.ReleaseDone += new EventHandler(WorldFilter_ReleaseDone);

            // Initialize the MoveObject event handler
            Core.WorldFilter.MoveObject += new EventHandler<MoveObjectEventArgs>(WorldFilter_MoveObject);

            // Initialize the FailToCompleteTrade event handler
            Core.WorldFilter.FailToCompleteTrade += new EventHandler(WorldFilter_FailToCompleteTrade);

            // Initialize the FailToAddTradeItem event handler
            Core.WorldFilter.FailToAddTradeItem += new EventHandler<FailToAddTradeItemEventArgs>(WorldFilter_FailToAddTradeItem);

            // Initialize the EnterTrade event handler
            Core.WorldFilter.EnterTrade += new EventHandler<EnterTradeEventArgs>(WorldFilter_EnterTrade);

            // Initialize the EndTrade event handler
            Core.WorldFilter.EndTrade += new EventHandler<EndTradeEventArgs>(WorldFilter_EndTrade);

            // Initialize the DeclineTrade event handler
            Core.WorldFilter.DeclineTrade += new EventHandler<DeclineTradeEventArgs>(WorldFilter_DeclineTrade);

            // Initialize the CreateObject event handler
            Core.WorldFilter.CreateObject += new EventHandler<CreateObjectEventArgs>(WorldFilter_CreateObject);

            // Initialize the ChangeObject event handler
            Core.WorldFilter.ChangeObject += new EventHandler<ChangeObjectEventArgs>(WorldFilter_ChangeObject);

            // Initialize the ApproachVendor event handler
            Core.WorldFilter.ApproachVendor += new EventHandler<ApproachVendorEventArgs>(WorldFilter_ApproachVendor);

            // Initialize the AddTradeItem event handler
            Core.WorldFilter.AddTradeItem += new EventHandler<AddTradeItemEventArgs>(WorldFilter_AddTradeItem);

            // Initialize the AcceptTrade event handler
            Core.WorldFilter.AcceptTrade += new EventHandler<AcceptTradeEventArgs>(WorldFilter_AcceptTrade);
        }

        void WorldFilter_AcceptTrade(object sender, AcceptTradeEventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        void WorldFilter_AddTradeItem(object sender, AddTradeItemEventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        void WorldFilter_ApproachVendor(object sender, ApproachVendorEventArgs e)
        {
            Vendor vendor = e.Vendor;
            // The vendor obj has neat attributes about their buy and sell rates.
            wtc($"{vendor} triggered WorldFilter_ApproachVendor.");
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        private void pointArrowAt(int id)
        {
            try
            {
                ID3DService d3d = (ID3DService)Host.GetObject("services\\D3DService.Service");
                d3d.PointToObject(id, -32900);
            }
            catch (Exception ex)
            {
                WriteToChat(ex.Message);
            }
        }

        private void bark()
        {
            try
            {
                string wav = "C:/Users/ekozl/plugins/EdsACPlugin/bin/Debug/wav/monster_02.wav";
                SoundPlayer s = new SoundPlayer(wav);
                s.Play();
            }
            catch (Exception ex)
            {
                WriteToChat(ex.Message);
            }
        }

        private void scanIt(WorldObject o)
        {
            try
            {
                // For now, detect if this is a mob.  If it's any kind of Golem anything, bark, and point
                // an arrow at it.
                // 
                if (o.ObjectClass == ObjectClass.Monster)
                {
                    if (o.Name.IndexOf("Golem") != -1)
                    {
                        wtc($"Found {o.Name} - Coords: ({o.Coordinates()})");
                        // bark
                        bark();
                        // point
                        pointArrowAt(o.Id);
                    }
                }

                /*  hide all this...
                 *  
                WriteToChat($"I see: {o.Name} - Id: {o.Id}");
                WriteToChat($"This item is type: {o.Type}");  // <-- TYPE is the WeenieId
                if (o.Name.IndexOf("Scroll") != -1)
                {
                    WriteToChat($"Scroll detected - {o.Name} - Attempting to loot it.");
                    WriteToChat($"Scroll is in container: {o.Container}");
                    shouldLoot.Add(o);
                }

                bool isWand = o.ObjectClass == ObjectClass.WandStaffOrb;
                bool isArmor = o.ObjectClass == ObjectClass.Armor;
                bool isCloting = o.ObjectClass == ObjectClass.Clothing;
                if (isArmor | isCloting)
                {
                    handleArmorDisplay(o);
                }
                if (isWand)
                {
                    handleWandDisplay(o);
                }
                WriteToChat($"Is this a wand?:   {isWand}");
                WriteToChat($"Is this Armor?:    {isArmor}");
                WriteToChat($"Is this Clothing?: {isCloting}");

                detectedObjects.Contains(o.Id);
                WriteToChat($"Have I seen this before? {detectedObjects.Contains(o.Id)}");

                if (detectedObjects.Contains(o.Id))
                {
                    // do nothing
                }
                else
                {
                    detectedObjects.Add(o.Id, o);
                }
                */
            }
            catch (Exception ex)
            {
                WriteToChat(ex.Message);
            }
        }

        void WorldFilter_ChangeObject(object sender, ChangeObjectEventArgs e)
        {
            WorldObject wo = e.Changed;
            wtc($"{wo.Name} triggered WorldFilter_ChangeObject");
        }

        void WorldFilter_CreateObject(object sender, CreateObjectEventArgs e)
        {
            WorldObject wo = e.New;
            wtc($"{wo.Name} triggered WorldFilter_CreateObject");
            scanIt(wo);
        }

        void WorldFilter_DeclineTrade(object sender, DeclineTradeEventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        void WorldFilter_EndTrade(object sender, EndTradeEventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        void WorldFilter_EnterTrade(object sender, EnterTradeEventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        void WorldFilter_FailToAddTradeItem(object sender, FailToAddTradeItemEventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        void WorldFilter_FailToCompleteTrade(object sender, EventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        void WorldFilter_MoveObject(object sender, MoveObjectEventArgs e)
        {
            // If this is a Monster, or Player... don't echo _anything_.
            WorldObject wo = e.Moved;
            if (wo.Type != (int)ObjectClass.Monster && wo.Type != (int)ObjectClass.Player)
            {
                wtc($"{wo.Name} fired WorldFilter_MoveObject");
            }
        }

        void WorldFilter_ReleaseDone(object sender, EventArgs e)
        {
            wtc($"WorldFilter_ReleaseDone - e is: {e}");
        }

        void WorldFilter_ReleaseObject(object sender, ReleaseObjectEventArgs e)
        {
            WorldObject wo = e.Released;
            wtc($"{wo.Name} triggered WorldFilter_ReleaseObject");
        }

        void WorldFilter_ResetTrade(object sender, ResetTradeEventArgs e)
        {
            wtc($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }

        private void destroyWorldFilter()
        {

            // UnInitialize the ResetTrade event handler
            Core.WorldFilter.ResetTrade -= new EventHandler<ResetTradeEventArgs>(WorldFilter_ResetTrade);

            // UnInitialize the ReleaseObject event handler
            Core.WorldFilter.ReleaseObject -= new EventHandler<ReleaseObjectEventArgs>(WorldFilter_ReleaseObject);

            // UnInitialize the ReleaseDone event handler
            Core.WorldFilter.ReleaseDone -= new EventHandler(WorldFilter_ReleaseDone);

            // UnInitialize the MoveObject event handler
            Core.WorldFilter.MoveObject -= new EventHandler<MoveObjectEventArgs>(WorldFilter_MoveObject);

            // UnInitialize the FailToCompleteTrade event handler
            Core.WorldFilter.FailToCompleteTrade -= new EventHandler(WorldFilter_FailToCompleteTrade);

            // UnInitialize the FailToAddTradeItem event handler
            Core.WorldFilter.FailToAddTradeItem -= new EventHandler<FailToAddTradeItemEventArgs>(WorldFilter_FailToAddTradeItem);

            // UnInitialize the EnterTrade event handler
            Core.WorldFilter.EnterTrade -= new EventHandler<EnterTradeEventArgs>(WorldFilter_EnterTrade);

            // UnInitialize the EndTrade event handler
            Core.WorldFilter.EndTrade -= new EventHandler<EndTradeEventArgs>(WorldFilter_EndTrade);

            // UnInitialize the DeclineTrade event handler
            Core.WorldFilter.DeclineTrade -= new EventHandler<DeclineTradeEventArgs>(WorldFilter_DeclineTrade);

            // UnInitialize the CreateObject event handler
            Core.WorldFilter.CreateObject -= new EventHandler<CreateObjectEventArgs>(WorldFilter_CreateObject);

            // UnInitialize the ChangeObject event handler
            Core.WorldFilter.ChangeObject -= new EventHandler<ChangeObjectEventArgs>(WorldFilter_ChangeObject);

            // UnInitialize the ApproachVendor event handler
            Core.WorldFilter.ApproachVendor -= new EventHandler<ApproachVendorEventArgs>(WorldFilter_ApproachVendor);

            // UnInitialize the AddTradeItem event handler
            Core.WorldFilter.AddTradeItem -= new EventHandler<AddTradeItemEventArgs>(WorldFilter_AddTradeItem);

            // UnInitialize the AcceptTrade event handler
            Core.WorldFilter.AcceptTrade -= new EventHandler<AcceptTradeEventArgs>(WorldFilter_AcceptTrade);
        }
    }
}