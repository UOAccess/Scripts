using System;
using Server;
using Server.Network;
using Server.Mobiles;
using Server.Items;

namespace Server.Gumps
{
   	public class DoNDAdminGump : Gump
    	{
		private Item i_Stone;

		public Item Stone
		{
			get{ return i_Stone; }
			set{ i_Stone = value; }
		}

        	public DoNDAdminGump( Item i ) : base( 0, 0 )
        	{
			DoNDAdminStone si = i as DoNDAdminStone;

			if ( si == null )
				return;

			Stone = si;

            		Closable = true;
			Disposable = true;
			Dragable = true;

			AddPage(0);
			AddBackground(0, 0, 194, 204, 9200);
			AddBackground(44, 6, 100, 40, 9200);
			AddBackground(1, 47, 192, 64, 9200);
			AddBackground(2, 111, 191, 88, 9200);

			AddLabel(47, 5, 1160, @"Deal or No Deal");
			AddLabel(59, 25, 1160, @"Admin Menu");

			AddLabel(4, 50, 62, @"Total Games Played : " + si.Game);
			AddLabel(4, 70, 62, @"Total Gold Taken : " + si.Game*50000);
			AddLabel(4, 90, 33, @"Total Gold Given : " + si.Cash);

			AddLabel(4, 115, 52, @"DeBug Mode");
			AddButton(126, 115, 247, 248, 1, GumpButtonType.Reply, 0);

			if ( si.DeBugger == false )
				AddLabel(90, 115, 33, @"Off");
			if ( si.DeBugger == true )
				AddLabel(90, 115, 57, @"On");

			AddLabel(4, 140, 1161, @"MoTD Commercial");
			AddButton(126, 140, 247, 248, 2, GumpButtonType.Reply, 0);
			
			AddLabel(4, 165, 1161, @"Replay (hours)");
			AddTextEntry(90, 165, 25, 20, 33, 0, @"" + si.Replay);
			AddButton(126, 165, 247, 248, 3, GumpButtonType.Reply, 0);
        	}

        	public override void OnResponse(NetState sender, RelayInfo info)
        	{
            		Mobile from = sender.Mobile;

			PlayerMobile pm = from as PlayerMobile;

			if ( pm == null )
				return;

            		TextRelay entry0 = info.GetTextEntry(0);
			string text0 = (entry0 == null ? "" : entry0.Text.Trim());

			DoNDAdminStone si = Stone as DoNDAdminStone;

			if ( si == null )
				return;

           		switch(info.ButtonID)
            		{
                		case 0:
				{
					break;
				}
                		case 1:
				{
					if ( si.DeBugger == false )
					{
						pm.SendMessage(57, pm.Name + "DeBug turned On!");
						si.DeBugger = true;
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						if (pm.HasGump( typeof( DebugGump )))
							pm.CloseGump( typeof( DebugGump ) );
						pm.SendGump( new DebugGump( pm ) );
						break;
					}
					if ( si.DeBugger == true )
					{
						pm.SendMessage(33, pm.Name + "DeBug turned Off!");
						si.DeBugger = false;
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDCommercialGump( pm ) );
						if (pm.HasGump( typeof( DebugGump )))
							pm.CloseGump( typeof( DebugGump ) );
						break;
					}
					break;
				}
				case 2:
				{
					pm.SendMessage( pm.Name + ", Accessing the Commercial Text Editor!");
					if (pm.HasGump( typeof( DoNDCommercialGump )))
						pm.CloseGump( typeof( DoNDCommercialGump ) );
					pm.SendGump( new DoNDCommercialGump( pm ) );
					break;
				}
				case 3:
				{
					if ( text0 == null )
					{
						pm.SendMessage( pm.Name + ", you can only set it from 2 - 24 hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					}
					if ( text0 == "0" )
					{
						pm.SendMessage( pm.Name + ", you can only set it from 2 - 24 hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					}
					if ( text0 == "1" )
					{
						pm.SendMessage( pm.Name + ", you can only set it from 2 - 24 hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					}
					if ( text0 == "2" )
					{
						si.Replay = 2;
						pm.SendMessage( pm.Name + ", your replay is set for 2 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "3" )
					{
						si.Replay = 3;
						pm.SendMessage( pm.Name + ", your replay is set for 3 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "4" )
					{
						si.Replay = 4;
						pm.SendMessage( pm.Name + ", your replay is set for 4 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "5" )
					{
						si.Replay = 5;
						pm.SendMessage( pm.Name + ", your replay is set for 5 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "6" )
					{
						si.Replay = 6;
						pm.SendMessage( pm.Name + ", your replay is set for 6 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "7" )
					{
						si.Replay = 7;
						pm.SendMessage( pm.Name + ", your replay is set for 7 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "8" )
					{
						si.Replay = 8;
						pm.SendMessage( pm.Name + ", your replay is set for 8 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "9" )
					{
						si.Replay = 9;
						pm.SendMessage( pm.Name + ", your replay is set for 9 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "10" )
					{
						si.Replay = 10;
						pm.SendMessage( pm.Name + ", your replay is set for 10 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "11" )
					{
						si.Replay = 11;
						pm.SendMessage( pm.Name + ", your replay is set for 11 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "12" )
					{
						si.Replay = 12;
						pm.SendMessage( pm.Name + ", your replay is set for 12 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "13" )
					{
						si.Replay = 13;
						pm.SendMessage( pm.Name + ", your replay is set for 13 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "14" )
					{
						si.Replay = 14;
						pm.SendMessage( pm.Name + ", your replay is set for 14 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "15" )
					{
						si.Replay = 15;
						pm.SendMessage( pm.Name + ", your replay is set for 15 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "16" )
					{
						si.Replay = 16;
						pm.SendMessage( pm.Name + ", your replay is set for 16 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "17" )
					{
						si.Replay = 17;
						pm.SendMessage( pm.Name + ", your replay is set for 17 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "18" )
					{
						si.Replay = 18;
						pm.SendMessage( pm.Name + ", your replay is set for 18 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "19" )
					{
						si.Replay = 19;
						pm.SendMessage( pm.Name + ", your replay is set for 19 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "20" )
					{
						si.Replay = 20;
						pm.SendMessage( pm.Name + ", your replay is set for 20 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "21" )
					{
						si.Replay = 21;
						pm.SendMessage( pm.Name + ", your replay is set for 21 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "22" )
					{
						si.Replay = 22;
						pm.SendMessage( pm.Name + ", your replay is set for 22 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "23" )
					{
						si.Replay = 23;
						pm.SendMessage( pm.Name + ", your replay is set for 23 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					if ( text0 == "24" )
					{
						si.Replay = 24;
						pm.SendMessage( pm.Name + ", your replay is set for 24 game hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
						break;
					} 
					pm.SendMessage( pm.Name + ", you can only set it from 2 - 24 hours!");
						if (pm.HasGump( typeof( DoNDAdminGump )))
							pm.CloseGump( typeof( DoNDAdminGump ) );
						pm.SendGump( new DoNDAdminGump( si ) );
					break;
				}
            		}
        	}
    	}
}