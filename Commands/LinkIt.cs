/*     Scripted By
 █▀▀▀ █▀▀ █▀▀█ █▀▀ █▀▀ ▀█ █▀ █▀▀█ █▀▀█ 
 █▀▀▀ ▀▀█ █  █ █   █▀▀  █▄█  █▄▄█ █  █ 
 █▄▄▄ ▀▀▀ █▀▀▀ ▀▀▀ ▀▀▀   ▀   ▀  ▀ ▀  ▀
          █
*/
using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Commands
{
	public class LinkIt
	{
        public static int X1;
        public static int Y1;
        public static int Z1;
        public static int X2;
        public static int Y2;
        public static int Z2;
        public static Moongate moonGate1;
        public static Moongate moonGate2;
        public static Teleporter telePorter1;
        public static Teleporter telePorter2;

        public static void Initialize()
        {
            moonGate1 = null;
            moonGate2 = null;
            telePorter1 = null;
            telePorter2 = null;
            CommandSystem.Register("LinkIt", AccessLevel.Counselor, new CommandEventHandler(LinkIt_OnCommand));
        }

        [Usage("LinkIt")]
        [Description("Links Gates and Teleporters.")]
		public static void LinkIt_OnCommand( CommandEventArgs e )
		{
			e.Mobile.Target = new LinkItTarget1( e.Mobile );
		}
        private class LinkItTarget1 : Target
		{
            public LinkItTarget1( Mobile m)
				: base( -1, true, TargetFlags.None )
			{
			}
			protected override void OnTarget( Mobile from, object o )
			{
                PlayerMobile player = (PlayerMobile)from;
                if (o == null)
                {
                    return;
                }
                else if ( !Generic.BaseCommand.IsAccessible( from, o ))
				{
					from.SendMessage(37, "That is not accessible." );
				}
				else if(o is Teleporter)
				{
                    Teleporter tele1 = (Teleporter)o;
                    telePorter1 = tele1;
                    X1 = tele1.X;
                    Y1 = tele1.Y;
                    Z1 = tele1.Z;
                    player.SendMessage(1150, String.Format("Teleporter1 X:{0} Y:{1} Z:{2}", X1.ToString() ,Y1.ToString(), Z1.ToString() ) );
                    player.Target = new LinkItTarget2(player);
				}
                else if ( o is Moongate)
                {
                    Moongate gate1 = (Moongate)o;
                    moonGate1 = gate1;
                    X1 = gate1.X;
                    Y1 = gate1.Y;
                    Z1 = gate1.Z;
                    player.SendMessage(1150, String.Format("Gate1 X:{0} Y:{1} Z:{2}", X1.ToString(), Y1.ToString(), Z1.ToString()));
                    player.Target = new LinkItTarget2(player);
                }
                else
                    from.SendMessage(37, "That is neither a Moongate or a Teleporter.");
            }
		}
        private class LinkItTarget2 : Target
        {
            public LinkItTarget2( Mobile m)
                : base(-1, true, TargetFlags.None)
            {
            }
            protected override void OnTarget(Mobile from, object p)
            {
                PlayerMobile player = (PlayerMobile)from;
                if ( p == null )
                {
                    return;
                }
                else if (!Generic.BaseCommand.IsAccessible(from, p))
                {
                    from.SendMessage(37, "That is not accessible.");
                }
                else if ( p is Teleporter && telePorter1 != null)
                {
                    Teleporter tele2 = (Teleporter)p;
                    telePorter2 = tele2;
                    Z2 = tele2.Z;
                    X2 = tele2.X;
                    Y2 = tele2.Y;
                    player.SendMessage(1150, String.Format("Teleporter2 X:{0} Y:{1} Z:{2}", X2.ToString(), Y2.ToString(), Z2.ToString()));
                    ApplyLink(player, telePorter1, telePorter2);

                }
                else if ( p is Moongate && moonGate1 != null )
                {
                    Moongate gate2 = (Moongate)p;
                    moonGate2 = gate2;
                    Z2 = gate2.Z;
                    X2 = gate2.X;
                    Y2 = gate2.Y;
                    player.SendMessage(1150, String.Format("Gate2 X:{0} Y:{1} Z:{2}", X2.ToString(), Y2.ToString(), Z2.ToString()));
                    ApplyLink(player, moonGate1, moonGate2);
                }
                else
                    player.SendMessage(37,"Something went wrong!");
            }
        }
        public static void ApplyLink( Mobile from, Item a, Item b )
        {
            PlayerMobile player = (PlayerMobile)from;
            if ( moonGate1 != null && moonGate2 != null )
            {
                moonGate1.Target = moonGate2.Location;
                moonGate1.TargetMap = moonGate2.Map;
                moonGate1.Dispellable = false;
                moonGate2.Target = moonGate1.Location;
                moonGate2.TargetMap = moonGate1.Map;
                moonGate2.Dispellable = false;
                player.SendMessage(72,"The Moongate Link was Successful");
                moonGate1 = null;
                moonGate2 = null;
                telePorter1 = null;
                telePorter2 = null;
            }
            else if ( telePorter1 != null && telePorter2 != null )
            {
                telePorter1.PointDest = telePorter2.Location;
                telePorter1.MapDest = telePorter2.Map;
                telePorter2.PointDest = telePorter1.Location;
                telePorter2.MapDest = telePorter1.Map;
                player.SendMessage(72,"The Teleporter Link was Successful");
                telePorter1 = null;
                telePorter2 = null;
                moonGate1 = null;
                moonGate2 = null;
            }
            else
                player.SendMessage(37, "Something went wrong!");
        }
    }
}
