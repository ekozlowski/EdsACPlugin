using Decal.Adapter;
using Decal.Adapter.Wrappers;
using System;

namespace EdsACPlugin
{
    [View("EdsACPlugin.ViewXML.mainView.xml")]
    [WireUpControlEvents]
    public partial class PluginCore
    {
        [ControlReference("TestButton")]
        private ButtonWrapper TestButton;

        [ControlReference("TestEdit")]
        private TextBoxWrapper TestEdit;

        [ControlReference("instructions")]
        private StaticWrapper instructions;

        [ControlEvent("TestButton", "Click")]
        private void onClick(object sender, ControlEventArgs args)
        {
            try
            {
                if (this.TestEdit.Text != null)
                {
                    WriteToChat(this.TestEdit.Text);
                }
                else
                {
                    WriteToChat("There is no text in the edit box.");
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(errorLogFile, ex);
            }
        }
    }
}