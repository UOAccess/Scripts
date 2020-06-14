using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Mobiles;
using Server.Items;
using Server.Network;

namespace Server.Gumps
{
    	public class DoNDCommercialGump : Gump
    	{
		private Item i_Stone;

		public Item Stone
		{
			get{ return i_Stone; }
			set{ i_Stone = value; }
		}

        	public DoNDCommercialGump( Mobile m ) : base( 0, 0 )
        	{
			PlayerMobile pm = m as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			List<Item> toCheck = new List<Item>();

            		foreach (Item item in World.Items.Values)
            		{
                		if (item is Item)
                		{
                    			if (item is DoNDAdminStone)
                    			{
                        			toCheck.Add(item);
                    				continue;
                    			}
                		}
            		}

			for ( int i = 0; i < toCheck.Count; i++ )
			{
				if ( toCheck[i] != null )
					Stone = toCheck[i];
					
			}
			Item di = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			DoNDGameDeed gd = di as DoNDGameDeed;

			DoNDAdminStone si = Stone as DoNDAdminStone;

			if ( si == null )
				return;

			toCheck.Clear();

            		Closable = false;
			Disposable = false;
			Dragable = false;

			AddPage(0);
			AddBackground(2, 2, 796, 558, 9200);
			AddBackground(349, 10, 100, 61, 9200);

			AddLabel(352, 16, 47, @"Deal or No Deal");
			AddLabel(363, 39, 47, @"Shard News");

			if ( gd != null )
				AddHtml( 19, 83, 765, 439, @si.SCommercial, (bool)true, (bool)true);
			if ( gd != null )
				AddButton(368, 533, 247, 244, 0, GumpButtonType.Reply, 0);
				
			if ( gd == null && pm.AccessLevel > AccessLevel.GameMaster )
				AddTextEntry(18, 83, 765, 436, 1161, 0, @"" + si.SCommercial);
			if ( gd == null &&  pm.AccessLevel > AccessLevel.GameMaster )
				AddButton(368, 533, 247, 244, 1, GumpButtonType.Reply, 0);
		}

        	public override void OnResponse(NetState sender, RelayInfo info)
        	{
            		Mobile from = sender.Mobile;

            		TextRelay entry0 = info.GetTextEntry(0);
			string text0 = (entry0 == null ? "" : entry0.Text.Trim());

			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Item di = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			DoNDGameDeed gd = di as DoNDGameDeed;

			DoNDAdminStone si = Stone as DoNDAdminStone;

           		switch(info.ButtonID)
            		{
                		case 0:
				{
					if ( gd == null )
						return;
					gd.Commercial = false;
					if (pm.HasGump( typeof( DoNDCommercialGump )))
						pm.CloseGump( typeof( DoNDCommercialGump ) );
					break;
				}
				case 1:
				{
					if ( si == null )
						break;
					if ( text0 == null )
					{
						pm.SendMessage( pm.Name + ", you've not entered any text, please type something!");
						if (pm.HasGump( typeof( DoNDCommercialGump )))
							pm.CloseGump( typeof( DoNDCommercialGump ) );
						pm.SendGump( new DoNDCommercialGump( pm ) );
						break;
					}
					si.SCommercial = text0;
					pm.SendMessage( pm.Name + ", your text has been saved and will be used for the commercial!");
					if (pm.HasGump( typeof( DoNDCommercialGump )))
						pm.CloseGump( typeof( DoNDCommercialGump ) );
					break;
				}
			}
        	}
    	}
}