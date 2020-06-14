using System;
using Server.Items;
using Server.Commands;

namespace Server.Commands
{
    public class UOGatewayVote
    {
        string URL;
        public static void Initialize()
        {
            CommandSystem.Register("Vote", AccessLevel.Player, new CommandEventHandler(UOGatewayVote_OnCommand));
        }
        [Usage("Vote")]
        public static void UOGatewayVote_OnCommand(CommandEventArgs e)
        {
            string URL = "https://www.uogateway.com/shard.php?id=1246&act=vote";
            Mobile from = e.Mobile;
            from.SendMessage("Thank you for voteing");
            from.LaunchBrowser(URL);

        }
    }
}
