/*
# Login/Logout/New Player Broadcast
# * Author: mordero
# * Email: mordero@gmail.com
# * Description: Will broadcast to current online players when someone has logged in/out. If the person who has logged in/out is above the player access level, it only broadcasts to the staff.
# * Description of Edit: When a new character is created, a message with their name, will be broadcasted to current online players. 
# * Additional Info: You may edit the New Player Message to your liking. Remember that the {0} denotes the player's name.
# * Installation: Just drag into your custom scripts folder.
# * Additional edits made by Orbit Storm to include a New Player Login Broadcast (and cleanup of wording for easier understanding).
# * All credit goes to mordero for developing this script and releasing it on RunUO. Please leave this header intact if you redistribute!
*/
using System;
using System.Text;
using Server;
using Server.Commands;

namespace mordero.Custom
{
    class Broadcast
    {
        //{0} is the name of the player
        private readonly static string m_staffLoginMessage = "Staff Member {0} has Logged In.";
        private readonly static string m_staffLogoutMessage = "Staff Member {0} has Logged Out.";
        private readonly static int m_staffLoginHue = 0x482;//Login Message Hue
        private readonly static int m_staffLogoutHue = 0x482;//Logout Message Hue
        private readonly static string m_LoginMessage = "{0} has Logged In.";//Login Message
        private readonly static string m_LogoutMessage = "{0} has Logged Out.";//Logout Message
        private readonly static int m_LoginHue = 0x482;//Login Message Hue
        private readonly static int m_LogoutHue = 0x482;//Logout Message Hue
        private readonly static string m_NewPlayerMessage = "{0}, Welcome to LumyrUO!"; //New Player Message
        private readonly static int m_NewPlayerHue = 33; //New Player Message Hue
        //maximum access level to announce
        private static AccessLevel m_AnnounceLevel = AccessLevel.Player;
        private static AccessLevel m_AnnounceStaffLevel = AccessLevel.GameMaster;


        public static void Initialize()
        {
            EventSink.Login += new LoginEventHandler(EventSink_Login);
            EventSink.Logout += new LogoutEventHandler(EventSink_Logout);
            EventSink.CharacterCreated += new CharacterCreatedEventHandler(EventSink_CharacterCreated);
        }

        public static void EventSink_Logout( LogoutEventArgs e )
        {
            if ( e.Mobile.Player )
            {
                if ( e.Mobile.AccessLevel == m_AnnounceLevel )
                    CommandHandlers.BroadcastMessage(AccessLevel.Player, m_LogoutHue, String.Format(m_LogoutMessage, e.Mobile.Name));
                else// if( e.Mobile.AccessLevel <= m_AnnounceLevel )
                {
                    CommandHandlers.BroadcastMessage(AccessLevel.Player, m_LogoutHue, String.Format(m_staffLogoutMessage, e.Mobile.Name));
                }
                //else
                    //broadcast any other level to the staff
                    //CommandHandlers.BroadcastMessage(AccessLevel.Player, m_LogoutHue, String.Format(m_staffLoginMessage, e.Mobile.Name));
            }
        }

        public static void EventSink_Login( LoginEventArgs e )
        {
            if ( e.Mobile.Player )
            {
                if ( e.Mobile.AccessLevel <= m_AnnounceLevel )
                    CommandHandlers.BroadcastMessage(AccessLevel.Player, m_LoginHue, String.Format(m_LoginMessage, e.Mobile.Name));
                else //broadcast any other level to the staff
                    CommandHandlers.BroadcastMessage(AccessLevel.Player, m_LoginHue, String.Format(m_staffLoginMessage, e.Mobile.Name));
            }
        }

        public static void EventSink_CharacterCreated( CharacterCreatedEventArgs e )
        {
            if ( e.Mobile != null )
            {
                if ( e.Mobile.AccessLevel == AccessLevel.Player )
                {
                    CommandHandlers.BroadcastMessage(AccessLevel.Player, m_NewPlayerHue, String.Format(m_NewPlayerMessage, e.Mobile.Name));
                }
            }
        }
    }
}
