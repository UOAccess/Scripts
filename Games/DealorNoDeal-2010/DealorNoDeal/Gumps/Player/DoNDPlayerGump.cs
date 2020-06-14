using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Gumps
{
    	public class DoNDPlayerGump : Gump
    	{
		private Mobile m_C1;
		private Mobile m_C2;
		private Mobile m_C3;
		private Mobile m_C4;
		private Mobile m_C5;
		private Mobile m_C6;
		private Mobile m_C7;
		private Mobile m_C8;
		private Mobile m_C9;
		private Mobile m_C10;
		private Mobile m_C11;
		private Mobile m_C12;
		private Mobile m_C13;
		private Mobile m_C14;
		private Mobile m_C15;
		private Mobile m_C16;
		private Mobile m_C17;
		private Mobile m_C18;
		private Mobile m_C19;
		private Mobile m_C20;
		private Mobile m_C21;
		private Mobile m_C22;
		private Mobile m_C23;
		private Mobile m_C24;
		private Mobile m_C25;
		private Mobile m_C26;
		private Mobile m_H1;

		public Mobile C1
		{
			get{ return m_C1; }
			set{ m_C1 = value; }
		}

		public Mobile C2
		{
			get{ return m_C2; }
			set{ m_C2 = value; }
		}

		public Mobile C3
		{
			get{ return m_C3; }
			set{ m_C3 = value; }
		}

		public Mobile C4
		{
			get{ return m_C4; }
			set{ m_C4 = value; }
		}

		public Mobile C5
		{
			get{ return m_C5; }
			set{ m_C5 = value; }
		}

		public Mobile C6
		{
			get{ return m_C6; }
			set{ m_C6 = value; }
		}

		public Mobile C7
		{
			get{ return m_C7; }
			set{ m_C7 = value; }
		}

		public Mobile C8
		{
			get{ return m_C8; }
			set{ m_C8 = value; }
		}

		public Mobile C9
		{
			get{ return m_C9; }
			set{ m_C9 = value; }
		}

		public Mobile C10
		{
			get{ return m_C10; }
			set{ m_C10 = value; }
		}

		public Mobile C11
		{
			get{ return m_C11; }
			set{ m_C11 = value; }
		}

		public Mobile C12
		{
			get{ return m_C12; }
			set{ m_C12 = value; }
		}

		public Mobile C13
		{
			get{ return m_C13; }
			set{ m_C13 = value; }
		}

		public Mobile C14
		{
			get{ return m_C14; }
			set{ m_C14 = value; }
		}

		public Mobile C15
		{
			get{ return m_C15; }
			set{ m_C15 = value; }
		}

		public Mobile C16
		{
			get{ return m_C16; }
			set{ m_C16 = value; }
		}

		public Mobile C17
		{
			get{ return m_C17; }
			set{ m_C17 = value; }
		}

		public Mobile C18
		{
			get{ return m_C18; }
			set{ m_C18 = value; }
		}

		public Mobile C19
		{
			get{ return m_C19; }
			set{ m_C19 = value; }
		}

		public Mobile C20
		{
			get{ return m_C20; }
			set{ m_C20 = value; }
		}

		public Mobile C21
		{
			get{ return m_C21; }
			set{ m_C21 = value; }
		}

		public Mobile C22
		{
			get{ return m_C22; }
			set{ m_C22 = value; }
		}

		public Mobile C23
		{
			get{ return m_C23; }
			set{ m_C23 = value; }
		}

		public Mobile C24
		{
			get{ return m_C24; }
			set{ m_C24 = value; }
		}

		public Mobile C25
		{
			get{ return m_C25; }
			set{ m_C25 = value; }
		}

		public Mobile C26
		{
			get{ return m_C26; }
			set{ m_C26 = value; }
		}

		public Mobile HM1
		{
			get{ return m_H1; }
			set{ m_H1 = value; }
		}

        	public DoNDPlayerGump() : base( 0, 0 )
        	{
            		Closable = false;
			Disposable = false;
			Dragable = true;

			AddPage(0);
			AddBackground(93, 0, 615, 76, 9270);

			AddLabel(106, 11, 1161, @"Case #");
			AddTextEntry(153, 12, 21, 20, 1161, 0, @"");
			AddButton(108, 36, 247, 248, 1, GumpButtonType.Reply, 0);

			AddLabel(182, 11, 1161, @"HearOffer");
			AddButton(182, 36, 247, 248, 2, GumpButtonType.Reply, 0);

			AddLabel(274, 11, 1161, @"Deal");
			AddButton(256, 36, 247, 248, 3, GumpButtonType.Reply, 0);

			AddLabel(341, 11, 1161, @"NoDeal");
			AddButton(330, 36, 247, 248, 4, GumpButtonType.Reply, 0);

			AddLabel(419, 11, 1161, @"Trade");
			AddButton(405, 36, 247, 248, 5, GumpButtonType.Reply, 0);

			AddLabel(486, 11, 1161, @"NoTrade");
			AddButton(480, 36, 247, 248, 6, GumpButtonType.Reply, 0);

			AddLabel(560, 11, 33, @"EndGame");
			AddButton(555, 36, 247, 248, 7, GumpButtonType.Reply, 0);

			AddLabel(647, 11, 57, @"Help");
			AddButton(629, 36, 247, 248, 8, GumpButtonType.Reply, 0);
        	}

        	public override void OnResponse(NetState sender, RelayInfo info)
        	{
            		Mobile from = sender.Mobile;

			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

            		TextRelay entry0 = info.GetTextEntry(0);
			string text0 = (entry0 == null ? "" : entry0.Text.Trim());

			Item di = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( di == null )
				return;

			DoNDGameDeed gd = di as DoNDGameDeed;

			if ( gd == null )
				return;

			if ( gd.Commercial == true )
			{
				pm.SendMessage( pm.Name + ", Please press Okay on the Shard Info Gump!");
				if (pm.HasGump( typeof( DoNDPlayerGump )))
					pm.CloseGump( typeof( DoNDPlayerGump ) );
				pm.SendGump( new DoNDPlayerGump() );
				return;
			}

			List<Mobile> toDelete = new List<Mobile>();
			List<Mobile> toCheck = new List<Mobile>();

            		foreach (Mobile mobile in World.Mobiles.Values)
            		{
                		if (mobile is PlayerMobile)
                		{
                    			continue;
                		}
                		if (mobile is BaseCreature)
                		{
                    			if (mobile is Girls)
                    			{
                        			toDelete.Add(mobile);
                    				continue;
                    			}
                    			if (mobile is Howey)
                    			{
                        			toCheck.Add(mobile);
                    				continue;
                    			}
                		}
            		}

			for ( int i = 0; i < toDelete.Count; i++ )
			{
				if ( toDelete[i].Name == "Claudia" )
				{
					C1 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Stacey" )
				{
					C2 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Lisa" )
				{
					C3 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Keltie" )
				{
					C4 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Ursula" )
				{
					C5 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Megan" )
				{
					C6 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Sara" )
				{
					C7 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Lauren" )
				{
					C8 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Patricia" )
				{
					C9 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Anya" )
				{
					C10 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Katie" )
				{
					C11 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Jill" )
				{
					C12 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Leyla" )
				{
					C13 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Pilar" )
				{
					C14 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Brooke" )
				{
					C15 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Krissy" )
				{
					C16 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Jenelle" )
				{
					C17 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Marisa" )
				{
					C18 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Mylinda" )
				{
					C19 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Alike" )
				{
					C20 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Tameka" )
				{
					C21 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Lianna" )
				{
					C22 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Aubrie" )
				{
					C23 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Kelly" )
				{
					C24 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Hayley Marie" )
				{
					C25 = toDelete[i];
					continue;
				}
				if ( toDelete[i].Name == "Lindsay" )
				{
					C26 = toDelete[i];
					continue;
				}
			}

			for ( int i = 0; i < toCheck.Count; i++ )
			{
				if ( toCheck[i].Name == "Howey Mandel" )
				{
					HM1 = toCheck[i];
					continue;
				}
			}

			Howey H1 = HM1 as Howey;

			if ( H1 == null )
				return;

			toDelete.Clear();

			toCheck.Clear();

            		switch(info.ButtonID)
            		{
                		case 0:
				{
					break;
				}
                		case 1:
				{
					if ( text0 == null )
					{
						pm.SendMessage( pm.Name + ", You need to enter in the number of the case you want!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "1" )
					{
						if ( H1.CD1 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								H1.Say("Claudia, Please open your case!");
							C1.Delete();
							H1.CD1 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case1");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "2" )
					{
						if ( H1.CD2 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								H1.Say("Stacey, Please open your case!");
							C2.Delete();
							H1.CD2 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case2");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "3" )
					{
						if ( H1.CD3 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Lisa, Please open your case!");
							C3.Delete();
							H1.CD3 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case3");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "4" )
					{
						if ( H1.CD4 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Keltie, Please open your case!");
							C4.Delete();
							H1.CD4 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case4");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "5" )
					{
						if ( H1.CD5 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Ursula, Please open your case!");
							C5.Delete();
							H1.CD5 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case5");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "6" )
					{
						if ( H1.CD6 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Megan, Please open your case!");
							C6.Delete();
							H1.CD6 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case6");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "7" )
					{
						if ( H1.CD7 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Sara, Please open your case!");
							C7.Delete();
							H1.CD7 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case7");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "8" )
					{
						if ( H1.CD8 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Lauren, Please open your case!");
							C8.Delete();
							H1.CD8 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case8");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "9" )
					{
						if ( H1.CD9 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Patricia, Please open your case!");
							C9.Delete();
							H1.CD9 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case9");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "10" )
					{
						if ( H1.CD10 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Anya, Please open your case!");
							C10.Delete();
							H1.CD10 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case10");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "11" )
					{
						if ( H1.CD11 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Katie, Please open your case!");
							C11.Delete();
							H1.CD11 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case11");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "12" )
					{
						if ( H1.CD12 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Jill, Please open your case!");
							C12.Delete();
							H1.CD12 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case12");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "13" )
					{
						if ( H1.CD13 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Leyla, Please open your case!");
							C13.Delete();
							H1.CD13 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case13");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "14" )
					{
						if ( H1.CD14 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Pilar, Please open your case!");
							C14.Delete();
							H1.CD14 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case14");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "15" )
					{
						if ( H1.CD15 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Brooke, Please open your case!");
							C15.Delete();
							H1.CD15 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case15");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "16" )
					{
						if ( H1.CD16 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Krissy, Please open your case!");
							C16.Delete();
							H1.CD16 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case16");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "17" )
					{
						if ( H1.CD17 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Jenelle, Please open your case!");
							C17.Delete();
							H1.CD17 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case17");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "18" )
					{
						if ( H1.CD18 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Marisa, Please open your case!");
							C18.Delete();
							H1.CD18 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case18");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "19" )
					{
						if ( H1.CD19 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Mylinda, Please open your case!");
							C19.Delete();
							H1.CD19 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case19");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "20" )
					{
						if ( H1.CD20 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Alike, Please open your case!");
							C20.Delete();
							H1.CD20 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case20");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( H1.CD20 == true )
							H1.Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "21" )
					{
						if ( H1.CD21 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Tameka, Please open your case!");
							C21.Delete();
							H1.CD21 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case21");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "22" )
					{
						if ( H1.CD22 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								H1.Say("Lianna, Please open your case!");
							C22.Delete();
							H1.CD22 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case22");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "23" )
					{
						if ( H1.CD23 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								H1.Say("Aubrie, Please open your case!");
							C23.Delete();
							H1.CD23 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case23");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "24" )
					{
						if ( H1.CD24 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								H1.Say("Kelly, Please open your case!");
							C24.Delete();
							H1.CD24 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case24");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "25" )
					{
						if ( H1.CD25 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								H1.Say("Hayley Marie, Please open your case!");
							C25.Delete();
							H1.CD25 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case25");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					if ( text0 == "26" )
					{
						if ( H1.CD26 == true )
						{
							H1.Say( pm.Name + ",You have already selected that case!");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}

						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								H1.Say("Lindsay, Please open your case!");
							C26.Delete();
							H1.CD26 = true;
							GameSystem.PickOrder( pm, H1 );
							pm.Say("Case26");

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );

							break;
						}
						if ( gd.CaseSel == false )
							H1.Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					pm.SendMessage( pm.Name + ", You need to enter in the number of the case thats left, check what girls are left!");

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );
					break;
				}
                		case 2:
				{
					gd.CloseCase = false;
					gd.DHelp = false;

					if ( gd.OfferSel == false )
					{
						H1.Say( pm.Name + ", You need to pick case's before Banker Calls!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}

					if ( gd.Banker == true )
					{
						H1.Say( pm.Name + ", You need to say Deal or NoDeal!");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					gd.Banker = true;
						
					GameSystem.PickOrder( pm, H1 );
						pm.Say("HearOffer");

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );

					break;
				}
                		case 3:
				{
					gd.CloseCase = false;
					gd.DHelp = false;

					if ( gd.Banker == true )
					{
						pm.PlaySound( 1051 );
						if ( gd.Deal == false )
							gd.PO = 0;

						H1.Banker = false;
						gd.Banker = false;
						gd.Deal = true;
						gd.NoDeal = false;
						gd.CaseSel = true;
						gd.OfferSel = false;
						GameSystem.PrizeCheck( pm, H1 );
						pm.Say("Deal");

						if (pm.HasGump( typeof( DoNDMainGump )))
							pm.CloseGump( typeof( DoNDMainGump ) );
						pm.SendGump( new DoNDMainGump( pm, gd ) );

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					H1.Say( pm.Name + ", It's not time to make a Deal yet!");

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );
					break;
				}
                		case 4:
				{
					gd.CloseCase = false;
					gd.DHelp = false;

					if ( gd.Banker == true )
					{
						pm.PlaySound( 1051 );
						H1.Banker = false;
						gd.Banker = false;
						gd.Deal = false;
						gd.NoDeal = true;
						gd.OfferSel = false;
						gd.CaseSel = true;
						gd.PO = 0;
						pm.Say("NoDeal");

						if ( gd.StageTwo == true )
							gd.SubStageOne2 = true;
						if ( gd.StageThree == true )
							gd.SubStageOne3 = true;
						if ( gd.StageFour == true )
							gd.SubStageOne4 = true;
						if ( gd.StageFive == true )
							gd.SubStageOne5 = true;
						if ( gd.StageSix == true )
							gd.SubStageOne6 = true;
						if ( gd.StageSeven == true )
							gd.SubStageOne7 = true;
						if ( gd.StageEight == true )
							gd.SubStageOne8 = true;
						if ( gd.StageNine == true )
							gd.SubStageOne9 = true;
						if ( gd.StageTen == true )
						{
							H1.Say( pm.Name + ", Its time to see if you want to keep your case or trade for the last remaining case!");
							gd.OfferSel = true;
							gd.CaseSel = false;

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );

							if (pm.HasGump( typeof( DoNDPlayerGump )))
								pm.CloseGump( typeof( DoNDPlayerGump ) );
							pm.SendGump( new DoNDPlayerGump() );
							break;
						}
							
						if ( gd.StageTwo == true && gd.SubStageOne2 == true )
							H1.Say( pm.Name + ", Please Pick Five Case's!");
						if ( gd.StageThree == true && gd.SubStageOne3 == true )
							H1.Say( pm.Name + ", Please Pick Four Case's!");
						if ( gd.StageFour == true && gd.SubStageOne4 == true )
							H1.Say( pm.Name + ", Please Pick Three Case's!");
						if ( gd.StageFive == true && gd.SubStageOne5 == true )
							H1.Say( pm.Name + ", Please Pick Two Case's!");
						if ( gd.StageSix == true && gd.SubStageOne6 == true )
							H1.Say( pm.Name + ", Please Pick One Case!");
						if ( gd.StageSeven == true && gd.SubStageOne7 == true )
							H1.Say( pm.Name + ", Please Pick One Case!");
						if ( gd.StageEight == true && gd.SubStageOne8 == true )
							H1.Say( pm.Name + ", Please Pick One Case!");
						if ( gd.StageNine == true && gd.SubStageOne9 == true )
							H1.Say( pm.Name + ", Please Pick One Case!");

						if (pm.HasGump( typeof( DoNDMainGump )))
							pm.CloseGump( typeof( DoNDMainGump ) );
						pm.SendGump( new DoNDMainGump( pm, gd ) );

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					H1.Say("Not time to make a Deal yet!");

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );
					break;
				}
                		case 5:
				{
					gd.CloseCase = false;
					gd.DHelp = false;

					if ( gd.OfferSel == true && gd.StageTen == true  )
					{
						pm.PlaySound( 1051 );
						H1.Banker = false;
						gd.Banker = false;
						gd.Trade = true;
						gd.NoTrade = false;
						gd.OfferSel = false;
						gd.CaseSel = false;
						GameSystem.PickOrder( pm, H1 );
						pm.Say("Trade");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					H1.Say( pm.Name + ", It's not time to make a Trade yet!");

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );
					break;
				}
                		case 6:
				{
					gd.CloseCase = false;
					gd.DHelp = false;

					if ( gd.OfferSel == true && gd.StageTen == true )
					{
						pm.PlaySound( 1051 );
						H1.Banker = false;
						gd.Banker = false;
						gd.Trade = false;
						gd.NoTrade = true;
						gd.OfferSel = false;
						gd.CaseSel = true;
						GameSystem.PickOrder( pm, H1 );
						pm.Say("NoTrade");

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );
						break;
					}
					H1.Say( pm.Name + ", It's not time to make a Trade yet!");

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );
					break;
				}
                		case 7:
				{
					if ( gd.GameOver == true )
						break;

					gd.CloseCase = false;
					gd.DHelp = false;
					pm.Say("EndGame");

					pm.PlaySound( pm.Female ? 783 : 1054 );
					gd.GameOver = true;
					GameSystem.EndDDGame( pm, H1 );

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );
					break;
				}
                		case 8:
				{
					if ( gd.DHelp == true )
					{
						gd.DHelp = false;

						if (pm.HasGump( typeof( DoNDMainGump )))
							pm.CloseGump( typeof( DoNDMainGump ) );
						pm.SendGump( new DoNDMainGump( pm, gd ) );

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );

						break;
					}
					if ( gd.DHelp == false )
					{
						gd.DHelp = true;

						pm.Say("Help");

						if (pm.HasGump( typeof( DoNDMainGump )))
							pm.CloseGump( typeof( DoNDMainGump ) );
						pm.SendGump( new DoNDMainGump( pm, gd ) );

						if (pm.HasGump( typeof( DoNDPlayerGump )))
							pm.CloseGump( typeof( DoNDPlayerGump ) );
						pm.SendGump( new DoNDPlayerGump() );

						break;
					}
					pm.SendMessage( pm.Name + ", Your not playing the game, wait your turn!");

					if (pm.HasGump( typeof( DoNDPlayerGump )))
						pm.CloseGump( typeof( DoNDPlayerGump ) );
					pm.SendGump( new DoNDPlayerGump() );
					break;
				}
            		}
        	}
    	}
}