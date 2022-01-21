using Decal.Adapter.Wrappers;
using System;

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
            // Core.WorldFilter.ResetTrade += new EventHandler<ResetTradeEventArgs>(WorldFilter_ResetTrade);

            // Initialize the ReleaseObject event handler
            // Core.WorldFilter.ReleaseObject += new EventHandler<ReleaseObjectEventArgs>(WorldFilter_ReleaseObject);

            // Initialize the ReleaseDone event handler
            // Core.WorldFilter.ReleaseDone += new EventHandler(WorldFilter_ReleaseDone);

            // Initialize the MoveObject event handler
            // Core.WorldFilter.MoveObject += new EventHandler<MoveObjectEventArgs>(WorldFilter_MoveObject);

            // Initialize the FailToCompleteTrade event handler
            // Core.WorldFilter.FailToCompleteTrade += new EventHandler(WorldFilter_FailToCompleteTrade);

            // Initialize the FailToAddTradeItem event handler
            // Core.WorldFilter.FailToAddTradeItem += new EventHandler<FailToAddTradeItemEventArgs>(WorldFilter_FailToAddTradeItem);

            // Initialize the EnterTrade event handler
            // Core.WorldFilter.EnterTrade += new EventHandler<EnterTradeEventArgs>(WorldFilter_EnterTrade);

            // Initialize the EndTrade event handler
            // Core.WorldFilter.EndTrade += new EventHandler<EndTradeEventArgs>(WorldFilter_EndTrade);

            // Initialize the DeclineTrade event handler
            // Core.WorldFilter.DeclineTrade += new EventHandler<DeclineTradeEventArgs>(WorldFilter_DeclineTrade);

            // Initialize the CreateObject event handler
            Core.WorldFilter.CreateObject += new EventHandler<CreateObjectEventArgs>(WorldFilter_CreateObject);

            // Initialize the ChangeObject event handler
            Core.WorldFilter.ChangeObject += new EventHandler<ChangeObjectEventArgs>(WorldFilter_ChangeObject);

            // Initialize the ApproachVendor event handler
            // Core.WorldFilter.ApproachVendor += new EventHandler<ApproachVendorEventArgs>(WorldFilter_ApproachVendor);

            // Initialize the AddTradeItem event handler
            // Core.WorldFilter.AddTradeItem += new EventHandler<AddTradeItemEventArgs>(WorldFilter_AddTradeItem);

            // Initialize the AcceptTrade event handler
            // Core.WorldFilter.AcceptTrade += new EventHandler<AcceptTradeEventArgs>(WorldFilter_AcceptTrade);
        }

        void WorldFilter_AcceptTrade(object sender, AcceptTradeEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_AddTradeItem(object sender, AddTradeItemEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_ApproachVendor(object sender, ApproachVendorEventArgs e)
        {
            // DO STUFF HERE
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
            if (o.ActiveSpellCount > 0) {
                for (int i = 0; i < o.ActiveSpellCount; i++)
                {
                    WriteToChat(o.ActiveSpell(i).ToString());
                }
            }
            WriteToChat("----- /ActiveSpells -----");
            WriteToChat("o.ToString: " + o.ToString());
            WriteToChat("o.Type.ToString(): " + o.Type.ToString());
            WriteToChat("--- StringKeys ---");
            foreach (int key in o.StringKeys) {
                WriteToChat(key.ToString());
            }
            WriteToChat("--- End StringKeys ---");
            // So, o.Values() is _odd_...
            // o.Values() takes a BoolValueKey index... huh?
            // I'm assuming it's like '10010010' like a boolean "Key index" mask.
            WriteToChat("--------------E - N - D-------------------------------------");
        }

        void WorldFilter_ChangeObject(object sender, ChangeObjectEventArgs e)
        {
            WriteToChat("WorldFilter_ChangeObject");
            WriteToChat("e.Change.ToString(): " + e.Change.ToString());
            try
            {
                outputObjectPropsToChat(e.Changed);
            }
            catch (Exception ex)
            {
                WriteToChat(ex.Message);
            }
        }

        void WorldFilter_CreateObject(object sender, CreateObjectEventArgs e)
        {
            WriteToChat("WorldFilter_CreateObject");
            WriteToChat("e.New.ToString(): " + e.New.ToString());
            outputObjectPropsToChat(e.New);
        }

        void WorldFilter_DeclineTrade(object sender, DeclineTradeEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_EndTrade(object sender, EndTradeEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_EnterTrade(object sender, EnterTradeEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_FailToAddTradeItem(object sender, FailToAddTradeItemEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_FailToCompleteTrade(object sender, EventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_MoveObject(object sender, MoveObjectEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_ReleaseDone(object sender, EventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_ReleaseObject(object sender, ReleaseObjectEventArgs e)
        {
            // DO STUFF HERE
        }

        void WorldFilter_ResetTrade(object sender, ResetTradeEventArgs e)
        {
            // DO STUFF HERE
        }

        private void destroyWorldFilter()
        {
            // UnInitialize the ResetTrade event handler
            // Core.WorldFilter.ResetTrade -= new EventHandler<ResetTradeEventArgs>(WorldFilter_ResetTrade);

            // UnInitialize the ReleaseObject event handler
            // Core.WorldFilter.ReleaseObject -= new EventHandler<ReleaseObjectEventArgs>(WorldFilter_ReleaseObject);

            // UnInitialize the ReleaseDone event handler
            // Core.WorldFilter.ReleaseDone -= new EventHandler(WorldFilter_ReleaseDone);

            // UnInitialize the MoveObject event handler
            // Core.WorldFilter.MoveObject -= new EventHandler<MoveObjectEventArgs>(WorldFilter_MoveObject);

            // UnInitialize the FailToCompleteTrade event handler
            // Core.WorldFilter.FailToCompleteTrade -= new EventHandler(WorldFilter_FailToCompleteTrade);

            // UnInitialize the FailToAddTradeItem event handler
            // Core.WorldFilter.FailToAddTradeItem -= new EventHandler<FailToAddTradeItemEventArgs>(WorldFilter_FailToAddTradeItem);

            // UnInitialize the EnterTrade event handler
            // Core.WorldFilter.EnterTrade -= new EventHandler<EnterTradeEventArgs>(WorldFilter_EnterTrade);

            // UnInitialize the EndTrade event handler
            // Core.WorldFilter.EndTrade -= new EventHandler<EndTradeEventArgs>(WorldFilter_EndTrade);

            // UnInitialize the DeclineTrade event handler
            // Core.WorldFilter.DeclineTrade -= new EventHandler<DeclineTradeEventArgs>(WorldFilter_DeclineTrade);

            // UnInitialize the CreateObject event handler
            Core.WorldFilter.CreateObject -= new EventHandler<CreateObjectEventArgs>(WorldFilter_CreateObject);

            // UnInitialize the ChangeObject event handler
            Core.WorldFilter.ChangeObject -= new EventHandler<ChangeObjectEventArgs>(WorldFilter_ChangeObject);

            // UnInitialize the ApproachVendor event handler
            // Core.WorldFilter.ApproachVendor -= new EventHandler<ApproachVendorEventArgs>(WorldFilter_ApproachVendor);

            // UnInitialize the AddTradeItem event handler
            // Core.WorldFilter.AddTradeItem -= new EventHandler<AddTradeItemEventArgs>(WorldFilter_AddTradeItem);

            // UnInitialize the AcceptTrade event handler
            // Core.WorldFilter.AcceptTrade -= new EventHandler<AcceptTradeEventArgs>(WorldFilter_AcceptTrade);
        }
    }
}