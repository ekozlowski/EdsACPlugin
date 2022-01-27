using Decal.Adapter;
using Decal.Adapter.Wrappers;
using System;

namespace EdsACPlugin
{
    public partial class PluginCore
    {
        // 10 = Red-pink?  MOAR red pink?
        // 9 = Red-pink
        // 8 = Reddish-pink
        // 7 = BLUE
        // 6 = RED
        // 5 = pink / purplish?
        // 4 = "gold?  Yellow?  not sure"
        // 3 = VERY yellow
        // 2 = WHITE
        // 1 = GREEN
        private int MessageColor = 3; 
        private void initChatEvents()
        {
            // Initialize incoming chat message event handler
            Core.ChatBoxMessage += new EventHandler<Decal.Adapter.ChatTextInterceptEventArgs>(Core_ChatBoxMessage);
            
            // Initialize the outgoing chat/command message event handler
            Core.CommandLineText += new EventHandler<Decal.Adapter.ChatParserInterceptEventArgs>(Core_CommandLineText);
        }

        void Core_CommandLineText(object sender, Decal.Adapter.ChatParserInterceptEventArgs e)
        {
            //TODO: outgoing chat handling code or command handling
        }

        void Core_ChatBoxMessage(object sender, Decal.Adapter.ChatTextInterceptEventArgs e)
        {
            //TODO: incoming chat handling code
        }
        private void destroyChatEvents()
        {
            Core.ChatBoxMessage -= new EventHandler<Decal.Adapter.ChatTextInterceptEventArgs>(Core_ChatBoxMessage);
            Core.CommandLineText -= new EventHandler<Decal.Adapter.ChatParserInterceptEventArgs>(Core_CommandLineText);
        }

        private void wtc(string message)
        {
            WriteToChat(message);
        }

        private void WriteToChat(string message)
        {
            try
            {
                Host.Actions.AddChatText(message, MessageColor);
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(errorLogFile, ex);
            }
        }
    }
}