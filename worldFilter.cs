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
            wtc("WorldFilter_AcceptTrade");
            wtc(e.ToString());
        }

        void WorldFilter_AddTradeItem(object sender, AddTradeItemEventArgs e)
        {
            wtc("WorldFilter_AddTradeItem");
            wtc(e.ToString());
        }

        void WorldFilter_ApproachVendor(object sender, ApproachVendorEventArgs e)
        {
            wtc("WorldFilter_ApproaceVendor");
            wtc(e.ToString());
        }



        void WorldFilter_ChangeObject(object sender, ChangeObjectEventArgs e)
        {
            wtc("WorldFilter_ChangeObject");
            wtc(e.ToString());
        }

        void WorldFilter_CreateObject(object sender, CreateObjectEventArgs e)
        {
            wtc("WorldFilter_CreateObject");
            wtc(e.ToString());
        }

        void WorldFilter_DeclineTrade(object sender, DeclineTradeEventArgs e)
        {
            wtc("WorldFilter_DeclineTrade");
            wtc(e.ToString());
        }

        void WorldFilter_EndTrade(object sender, EndTradeEventArgs e)
        {
            wtc("WorldFilter_EndTrade");
            wtc(e.ToString());
        }

        void WorldFilter_EnterTrade(object sender, EnterTradeEventArgs e)
        {
            wtc("WorldFilter_EnterTrade");
            wtc(e.ToString());
        }

        void WorldFilter_FailToAddTradeItem(object sender, FailToAddTradeItemEventArgs e)
        {
            wtc("WorldFilter_FailToAddTradeItem");
            wtc(e.ToString());
        }

        void WorldFilter_FailToCompleteTrade(object sender, EventArgs e)
        {
            wtc("WorldFilter_FailToCompleteTrade");
            wtc(e.ToString());
        }

        void WorldFilter_MoveObject(object sender, MoveObjectEventArgs e)
        {
            wtc("WorldFilter_MoveObject");
            wtc(e.ToString());
        }

        void WorldFilter_ReleaseDone(object sender, EventArgs e)
        {
            wtc("WorldFilter_ReleaseDone");
            wtc(e.ToString());
        }

        void WorldFilter_ReleaseObject(object sender, ReleaseObjectEventArgs e)
        {
            wtc("WorldFilter_ReleaseObject");
            wtc(e.ToString());
        }

        void WorldFilter_ResetTrade(object sender, ResetTradeEventArgs e)
        {
            wtc("WorldFilter_ResetTrade");
            wtc(e.ToString());
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