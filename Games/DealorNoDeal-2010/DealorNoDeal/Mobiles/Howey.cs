using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Gumps;

namespace Server.Mobiles
{
	public class Howey : BaseCreature
	{
		private int i_al;
		private int i_cnt;
		private int i_Cash;
		private int i_Replay;
		private bool m_DealOrNot = false;
		private bool m_Banker = false;
		private bool m_DeBug = false;
		private Item i_Stone;
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
		private bool m_CD1 = false;
		private bool m_CD2 = false;
		private bool m_CD3 = false;
		private bool m_CD4 = false;
		private bool m_CD5 = false;
		private bool m_CD6 = false;
		private bool m_CD7 = false;
		private bool m_CD8 = false;
		private bool m_CD9 = false;
		private bool m_CD10 = false;
		private bool m_CD11 = false;
		private bool m_CD12 = false;
		private bool m_CD13 = false;
		private bool m_CD14 = false;
		private bool m_CD15 = false;
		private bool m_CD16 = false;
		private bool m_CD17 = false;
		private bool m_CD18 = false;
		private bool m_CD19 = false;
		private bool m_CD20 = false;
		private bool m_CD21 = false;
		private bool m_CD22 = false;
		private bool m_CD23 = false;
		private bool m_CD24 = false;
		private bool m_CD25 = false;
		private bool m_CD26 = false;

		public int AL
		{
			get{ return i_al; }
			set{ i_al = value; }
		}

		public int cnt
		{
			get{ return i_cnt; }
			set{ i_cnt = value; }
		}

		public int Cash
		{
			get{ return i_Cash; }
			set{ i_Cash = value; }
		}

		public int MReplay
		{
			get{ return i_Replay; }
			set{ i_Replay = value; }
		}

		public bool DealOn
		{
			get{ return m_DealOrNot; }
			set{ m_DealOrNot = value; }
		}

		public bool Banker
		{
			get{ return m_Banker; }
			set{ m_Banker = value; }
		}

		public bool DeBugger
		{
			get{ return m_DeBug; }
			set{ m_DeBug = value; }
		}

		public Item Stone
		{
			get{ return i_Stone; }
			set{ i_Stone = value; }
		}

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

		public bool CD1
		{
			get{ return m_CD1; }
			set{ m_CD1 = value; }
		}

		public bool CD2
		{
			get{ return m_CD2; }
			set{ m_CD2 = value; }
		}

		public bool CD3
		{
			get{ return m_CD3; }
			set{ m_CD3 = value; }
		}

		public bool CD4
		{
			get{ return m_CD4; }
			set{ m_CD4 = value; }
		}

		public bool CD5
		{
			get{ return m_CD5; }
			set{ m_CD5 = value; }
		}

		public bool CD6
		{
			get{ return m_CD6; }
			set{ m_CD6 = value; }
		}

		public bool CD7
		{
			get{ return m_CD7; }
			set{ m_CD7 = value; }
		}

		public bool CD8
		{
			get{ return m_CD8; }
			set{ m_CD8 = value; }
		}

		public bool CD9
		{
			get{ return m_CD9; }
			set{ m_CD9 = value; }
		}

		public bool CD10
		{
			get{ return m_CD10; }
			set{ m_CD10 = value; }
		}

		public bool CD11
		{
			get{ return m_CD11; }
			set{ m_CD11 = value; }
		}

		public bool CD12
		{
			get{ return m_CD12; }
			set{ m_CD12 = value; }
		}

		public bool CD13
		{
			get{ return m_CD13; }
			set{ m_CD13 = value; }
		}

		public bool CD14
		{
			get{ return m_CD14; }
			set{ m_CD14 = value; }
		}

		public bool CD15
		{
			get{ return m_CD15; }
			set{ m_CD15 = value; }
		}

		public bool CD16
		{
			get{ return m_CD16; }
			set{ m_CD16 = value; }
		}

		public bool CD17
		{
			get{ return m_CD17; }
			set{ m_CD17 = value; }
		}

		public bool CD18
		{
			get{ return m_CD18; }
			set{ m_CD18 = value; }
		}

		public bool CD19
		{
			get{ return m_CD19; }
			set{ m_CD19 = value; }
		}

		public bool CD20
		{
			get{ return m_CD20; }
			set{ m_CD20 = value; }
		}

		public bool CD21
		{
			get{ return m_CD21; }
			set{ m_CD21 = value; }
		}

		public bool CD22
		{
			get{ return m_CD22; }
			set{ m_CD22 = value; }
		}

		public bool CD23
		{
			get{ return m_CD23; }
			set{ m_CD23 = value; }
		}

		public bool CD24
		{
			get{ return m_CD24; }
			set{ m_CD24 = value; }
		}

		public bool CD25
		{
			get{ return m_CD25; }
			set{ m_CD25 = value; }
		}

		public bool CD26
		{
			get{ return m_CD26; }
			set{ m_CD26 = value; }
		}

		private static bool m_Talked;

          	string[]GameSay = new string[]
          	{
			"Double Click me to redeem Game Ticket!",
			"Buy a Game Ticket to start game!",
			"Win a Million Gold!",
			"Try your luck, Play Deal or No Deal!",
			"Play Deal or No Deal Here!",
			"Tickets can be bought for 50k gold!",
			"Win collectable dolls!",
			"Don't let the Banker Scare you, come and play!",
           	};

          	string[]PreGameSay = new string[]
          	{
			"Lets see how your first six case's go!",
			"Try not to pick high amounts!",
			"The Bankers getting ready to low ball you an offer!",
			"Today Might be your lucky day!",
			"Pick small amounts!",
			"Don't get to upset if you hit a few big amounts!",
			"The Bankers offer reflects what amounts are left!",
			"I'm feeling that you just might win today!",
           	};

          	string[]PosSay = new string[]
          	{
			"Your looking good, keep it up!",
			"Alot of big money amounts left!",
			"Its your lucky day!",
			"You'll be walking out with alot today!",
			"Your lucky today!",
			"You just might be our biggest winner today!",
			"What are you going to do with all the money you win today!",
			"I feel your positive attitude is paying off!",
           	};

          	string[]NegSay = new string[]
          	{
			"It was fun playing the game even if you don't win!",
			"The Banker's happy your not on your game today!",
			"You can always try again!",
			"One day you'll get the Million!",
			"IThe Banker likes you today!",
			"Maybe you'll get better luck next time!",
			"Still some money up there!",
			"You won't be a millionaire today!",
           	};

          	string[]BankPosSay = new string[]
          	{
			"The Banker thinks you might be lucky today!",
			"The Banker doesn't like to see alot of big money left on the board!",
			"It might be the Bankers unlucky day!",
			"The Banker said you might walk out of here with alot of money!",
			"The Banker feels abit uneasy with you!",
			"The Banker wants you to give up your lucky shoes so you might lose today!",
			"I think the Banker will have to write a huge check today!",
			"What do you plan to do with all the money you win today!",
           	};

          	string[]BankNegSay = new string[]
          	{
			"Banker says, hope you had fun, he knows he will with your lost winnings!",
			"The Banker's happy your not on your game today!",
			"Banker says you can always try again when you feel like losing more money!",
			"Banker says you'll never win the million!",
			"Banker says, how does it feel to lose!",
			"The Banker's going to have a party tonight with the money you didn't win!",
			"Banker says you can always pay me again to take your money!",
			"Banker says your not fit enuff to win a million here!",
           	};

		[Constructable]
		public Howey( Item i ) : base( AIType.AI_Animal, FightMode.Aggressor, 20, 1, 0.2, 0.4 )
		{
			DoNDAdminStone si = i as DoNDAdminStone;

			if ( si == null )
				return;

			Stone = si;

			MReplay = si.Replay;

			Name = "Howey Mandel";
			Title = "the gameshow host";

			Body = 0x190;
			Hue = 1002;
                 	SpeechHue = 1161;

			CantWalk = true;
			Blessed = true;
			Frozen = true;
			
			AddItem( new HoweyShoes() );
			AddItem( new HoweyPants() );
			AddItem( new HoweyShirt() );
			AddItem( new HoweyJacket() );

			Direction = Direction.South;
		}

		public Howey( Serial serial ) : base( serial )
		{
		}

            	public override void OnMovement( Mobile m, Point3D oldLocation )
            	{
			Direction = Direction.South;
			
			if ( Frozen == false )
				Frozen = true;

			if ( DealOn == true )
				return;

                 	if( m_Talked == false && AL == 0 )
                 	{
                      		if ( m.InRange( this, 10 ) && m is PlayerMobile)
                      		{
					m_Talked = true;
                             		SayRandom(GameSay, this );
                             		GameSpamTimer t = new GameSpamTimer();
                             		t.Start();
                        	}
                   	}
              	}

              	private class GameSpamTimer : Timer
              	{
                   	public GameSpamTimer() : base( TimeSpan.FromSeconds( 20 ) )
                   	{
                        	Priority = TimerPriority.OneSecond;
                   	}

                   	protected override void OnTick()
                   	{
                           	m_Talked = false;
                   	}
               	}

               	private static void SayRandom( string[] say, Mobile m )
               	{
                   	m.Say( say[Utility.Random( say.Length )] );
               	}

		public override void OnThink()
		{
			DoNDAdminStone st = Stone as DoNDAdminStone;

			if ( st == null )
				return;

			if ( st.DeBugger == true )
				DeBugger = true;
			if ( st.DeBugger == false )
				DeBugger = false;

			if ( Hidden == true )
			{
				st.SHowey = false;
				st.Cash +=Cash;
				Stone.Name = "Deal or No Deal : System On : Howey Not Spawned";
				Timer hr_timer = new HoweyResetTimer( Stone, this ); 
    				hr_timer.Start();
				Delete();
			}
			if ( DealOn == true )
				cnt +=1;

			if ( DealOn == false )
			{
				base.OnThink();
				return;
			}
	
			if ( AL == 0 && cnt >= 15 )
			{
                      		SayRandom(PreGameSay, this );
				cnt = 0;
				base.OnThink();
				return;
			}

			if ( Banker == true && cnt >= 15  )
			{
				if ( AL >= 1000000 ) 
                 		{
                      			SayRandom(BankPosSay, this );
					cnt = 0;
					base.OnThink();
					return;
				}
                 		if ( AL <= 999999 ) 
                 		{
                      			SayRandom(BankNegSay, this );
					cnt = 0;
					base.OnThink();
					return;
				}
			}
                 	if ( AL >= 1000000 && cnt >= 30 ) 
                 	{
                      		SayRandom(PosSay, this );
				cnt = 0;
                   	}
                 	if ( AL <= 999999 && cnt >= 30 ) 
                 	{
                      		SayRandom(NegSay, this );
				cnt = 0;
                   	}
			base.OnThink();
		}

		public override void OnDoubleClick( Mobile from )
		{
			DoNDAdminStone st = Stone as DoNDAdminStone;

			if ( st == null )
				return;

			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Item ri = pm.Backpack.FindItemByType(typeof(DoNDReplayDeed) );

			Item ti = pm.Backpack.FindItemByType(typeof(DoNDGameTicket) );

			Item di = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( ri != null )
			{
				DoNDReplayDeed rd = ri as DoNDReplayDeed;

				if ( rd == null )
					return;
	
				if ( rd.RP1 >= rd.RReplay )
				{
					rd.Delete();
					Say( pm.Name + ", Please double tap me again!");
					return;
				}

				Say( pm.Name + ", You need to wait {0} to play again!", rd.RReplay );
				Say( "Hours you've waited : {0} Hrs and {1} mins", rd.RP1, rd.RPM1 );
				return;
			}

			if ( ti != null )
			{
				if ( DealOn == true && di == null )
				{
					pm.SendMessage( pm.Name + ", Please wait for the game to end!");

					if ( DeBugger == true )
						Console.WriteLine( "DeBug : Howey, OnDoubleClick, Ticket Found, DealOn Default False" );
					return;
				}
				
				if ( DeBugger == true )
					Console.WriteLine( "DeBug : Howey, OnDoubleClick, Ticket Found, DealOn True" );
	
				DoNDGameTicket gt = ti as DoNDGameTicket;

				if ( gt == null )
					return;

				gt.Delete();
				st.Game +=1;
				GameSystem.StartDDGame( pm, this );
				return;
			}

			if ( di != null )
			{
				DoNDGameDeed gd = di as DoNDGameDeed;

				if ( gd == null )
					return;
			
				if ( gd.DealOn == false )
					pm.SendMessage( pm.Name + ", Please log out to reset your character!");
				if ( gd.DealOn == true )
					Say( pm.Name + ", Please don't touch me while we are playing!");

				if ( DeBugger == true )
					Console.WriteLine( "DeBug : Howey, OnDoubleClick, Deed Found" );
				return;
			}
			
			if ( ti == null )
			{
				Say( pm.Name + ", Please go buy a Game Ticket!");

				if ( DeBugger == true )
					Console.WriteLine( "DeBug : Howey, OnDoubleClick, Deed or Ticket null Found" );
				return;
			}
		}

		public override bool HandlesOnSpeech( Mobile from )
		{
			if ( from.InRange( this.Location, 3 ) )
				return true;

			return base.HandlesOnSpeech( from );
		}

		public override void OnSpeech( SpeechEventArgs e )
		{
			if ( !e.Handled && e.Mobile.InRange( this.Location, 3 ) )
			{
				PlayerMobile pm = e.Mobile as PlayerMobile;

				if (pm == null || pm.Backpack == null)
    					return;

				Item di = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

				if ( di == null )
					return;

				DoNDGameDeed gd = di as DoNDGameDeed;

				if ( gd == null )
					return;

				if ( gd.Commercial == true )
				{
					Say( pm.Name + ", Please press Okay on the Shard Info Gump!");
					return;
				}

				List<Mobile> toDelete = new List<Mobile>();

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

					if ( DeBugger == true )
						Console.WriteLine( "DeBug : Howey, OnSpeech, Girls Found" );
					continue;
				}
				toDelete.Clear();
				
                  		string keyword = e.Speech;

				switch ( keyword )
				{
					case "Deal":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Banker == true )
						{
							pm.PlaySound( 1051 );
							if ( gd.Deal == false )
								gd.PO = 0;

							Banker = false;
							gd.Banker = false;
							gd.Deal = true;
							gd.NoDeal = false;
							gd.CaseSel = true;
							gd.OfferSel = false;
							GameSystem.PrizeCheck( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Deal OK" );

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );
							break;
						}
						Say( pm.Name + ", It's not time to make a Deal yet!");
						break;
					}
					case "NoDeal":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Banker == true  )
						{
							pm.PlaySound( 1051 );
							Banker = false;
							gd.Banker = false;
							gd.Deal = false;
							gd.NoDeal = true;
							gd.OfferSel = false;
							gd.CaseSel = true;
							gd.PO = 0;

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
								Say( pm.Name + ", Its time to see if you want to keep your case or trade for the last remaining case!");
								gd.OfferSel = true;
								gd.CaseSel = false;

								if ( DeBugger == true )
									Console.WriteLine( "DeBug : Howey, OnSpeech, NoDeal Trade OR OK" );

								if (pm.HasGump( typeof( DoNDMainGump )))
									pm.CloseGump( typeof( DoNDMainGump ) );
								pm.SendGump( new DoNDMainGump( pm, gd ) );
								break;
							}
							
							if ( gd.StageTwo == true && gd.SubStageOne2 == true )
								Say( pm.Name + ", Please Pick Five Case's!");
							if ( gd.StageThree == true && gd.SubStageOne3 == true )
								Say( pm.Name + ", Please Pick Four Case's!");
							if ( gd.StageFour == true && gd.SubStageOne4 == true )
								Say( pm.Name + ", Please Pick Three Case's!");
							if ( gd.StageFive == true && gd.SubStageOne5 == true )
								Say( pm.Name + ", Please Pick Two Case's!");
							if ( gd.StageSix == true && gd.SubStageOne6 == true )
								Say( pm.Name + ", Please Pick One Case!");
							if ( gd.StageSeven == true && gd.SubStageOne7 == true )
								Say( pm.Name + ", Please Pick One Case!");
							if ( gd.StageEight == true && gd.SubStageOne8 == true )
								Say( pm.Name + ", Please Pick One Case!");
							if ( gd.StageNine == true && gd.SubStageOne9 == true )
								Say( pm.Name + ", Please Pick One Case!");

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, NoDeal OK" );

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );
							break;
						}
						Say("Not time to make a Deal yet!");
						break;
					}
					case "Trade":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.OfferSel == true && gd.StageTen == true  )
						{
							pm.PlaySound( 1051 );
							Banker = false;
							gd.Banker = false;
							gd.Trade = true;
							gd.NoTrade = false;
							gd.OfferSel = false;
							gd.CaseSel = false;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Trade OK" );
							break;
						}
						Say( pm.Name + ", It's not time to make a Trade yet!");
						break;
					}
					case "NoTrade":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.OfferSel == true && gd.StageTen == true )
						{
							pm.PlaySound( 1051 );
							Banker = false;
							gd.Banker = false;
							gd.Trade = false;
							gd.NoTrade = true;
							gd.OfferSel = false;
							gd.CaseSel = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, NoTrade OK" );
							break;
						}
						Say( pm.Name + ", It's not time to make a Trade yet!");
						break;
					}
					case "Case1":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD1 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Claudia, Please open your case!");
							C1.Delete();
							CD1 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 1 OK" );
							break;
						}
						if ( CD1 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case2":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD2 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Stacey, Please open your case!");
							C2.Delete();
							CD2 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 2 OK" );
							break;
						}
						if ( CD2 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case3":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD3 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Lisa, Please open your case!");
							C3.Delete();
							CD3 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 3 OK" );
							break;
						}
						if ( CD3 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case4":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD4 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Keltie, Please open your case!");
							C4.Delete();
							CD4 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 4 OK" );
							break;
						}
						if ( CD4 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case5":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD5 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Ursula, Please open your case!");
							C5.Delete();
							CD5 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 5 OK" );
							break;
						}
						if ( CD5 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case6":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD6 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Megan, Please open your case!");
							C6.Delete();
							CD6 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 6 OK" );
							break;
						}
						if ( CD6 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case7":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD7 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Sara, Please open your case!");
							C7.Delete();
							CD7 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 7 OK" );
							break;
						}
						if ( CD7 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case8":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD8 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Lauren, Please open your case!");
							C8.Delete();
							CD8 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 8 OK" );
							break;
						}
						if ( CD8 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case9":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD9 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Patricia, Please open your case!");
							C9.Delete();
							CD9 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 9 OK" );
							break;
						}
						if ( CD9 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case10":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD10 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Anya, Please open your case!");
							C10.Delete();
							CD10 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 10 OK" );
							break;
						}
						if ( CD10 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case11":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD11 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Katie, Please open your case!");
							C11.Delete();
							CD11 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 11 OK" );
							break;
						}
						if ( CD11 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case12":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD12 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Jill, Please open your case!");
							C12.Delete();
							CD12 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 12 OK" );
							break;
						}
						if ( CD12 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case13":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD13 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Leyla, Please open your case!");
							C13.Delete();
							CD13 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 13 OK" );
							break;
						}
						if ( CD13 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case14":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD14 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Pilar, Please open your case!");
							C14.Delete();
							CD14 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 14 OK" );
							break;
						}
						if ( CD14 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case15":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD15 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Brooke, Please open your case!");
							C15.Delete();
							CD15 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 15 OK" );
							break;
						}
						if ( CD15 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case16":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD16 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Krissy, Please open your case!");
							C16.Delete();
							CD16 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 16 OK" );
							break;
						}
						if ( CD16 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case17":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD17 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Jenelle, Please open your case!");
							C17.Delete();
							CD17 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 17 OK" );
							break;
						}
						if ( CD17 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case18":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD18 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Marisa, Please open your case!");
							C18.Delete();
							CD18 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 18 OK" );
							break;
						}
						if ( CD18 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case19":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD19 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Mylinda, Please open your case!");
							C19.Delete();
							CD19 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 19 OK" );
							break;
						}
						if ( CD19 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case20":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD20 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Alike, Please open your case!");
							C20.Delete();
							CD20 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 20 OK" );
							break;
						}
						if ( CD20 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case21":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD21 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Tameka, Please open your case!");
							C21.Delete();
							CD21 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 21 OK" );
							break;
						}
						if ( CD21 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case22":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD22 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Lianna, Please open your case!");
							C22.Delete();
							CD22 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 22 OK" );
							break;
						}
						if ( CD22 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case23":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD23 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Aubrie, Please open your case!");
							C23.Delete();
							CD23 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 23 OK" );
							break;
						}
						if ( CD23 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case24":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD24 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Kelly, Please open your case!");
							C24.Delete();
							CD24 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 24 OK" );
							break;
						}
						if ( CD24 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case25":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD25 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Hayley Marie, Please open your case!");
							C25.Delete();
							CD25 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 25 OK" );
							break;
						}
						if ( CD25 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "Case26":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD26 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Lindsay, Please open your case!");
							C26.Delete();
							CD26 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 26 OK" );
							break;
						}
						if ( CD26 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "EndGame":
					{
						if ( gd.GameOver == true )
							break;

						gd.CloseCase = false;
						gd.DHelp = false;

						pm.PlaySound( pm.Female ? 783 : 1054 );
						gd.GameOver = true;
						GameSystem.EndDDGame( pm, this );

						if ( DeBugger == true )
							Console.WriteLine( "DeBug : Howey, OnSpeech, End Game OK" );
						break;
					}
					case "HearOffer":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.OfferSel == false )
						{
							Say( pm.Name + ", You need to pick case's before Banker Calls!");
							break;
						}

						if ( gd.Banker == true )
						{
							Say( pm.Name + ", You need to say Deal or NoDeal!");
							break;
						}
						gd.Banker = true;
						
						GameSystem.PickOrder( pm, this );

						if ( DeBugger == true )
							Console.WriteLine( "DeBug : Howey, OnSpeech, HearOffer OK" );
						break;
					}
					case "Help":
					{
						if ( gd.DHelp == true )
						{
							gd.DHelp = false;

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Help Off OK" );
							break;
						}
						if ( gd.DHelp == false )
						{
							gd.DHelp = true;

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Help On OK" );
							break;
						}
						pm.SendMessage( pm.Name + ", Your not playing the game, wait your turn!");
						break;
					}case "deal":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Banker == true && gd.StageTen != true  )
						{
							pm.PlaySound( 1051 );
							if ( gd.Deal == false )
								gd.PO = 0;

							Banker = false;
							gd.Banker = false;
							gd.Deal = true;
							gd.NoDeal = false;
							gd.CaseSel = true;
							gd.OfferSel = false;
							GameSystem.PrizeCheck( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Deal OK" );

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );
							break;
						}
						Say( pm.Name + ", It's not time to make a Deal yet!");
						break;
					}
					case "nodeal":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Banker == true  )
						{
							pm.PlaySound( 1051 );
							Banker = false;
							gd.Banker = false;
							gd.Deal = false;
							gd.NoDeal = true;
							gd.OfferSel = false;
							gd.CaseSel = true;
							gd.PO = 0;

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
								Say( pm.Name + ", Its time to see if you want to keep your case or trade for the last remaining case!");
								gd.OfferSel = true;
								gd.CaseSel = false;

								if ( DeBugger == true )
									Console.WriteLine( "DeBug : Howey, OnSpeech, NoDeal Trade OR OK" );

								if (pm.HasGump( typeof( DoNDMainGump )))
									pm.CloseGump( typeof( DoNDMainGump ) );
								pm.SendGump( new DoNDMainGump( pm, gd ) );
								break;
							}
							
							if ( gd.StageTwo == true && gd.SubStageOne2 == true )
								Say( pm.Name + ", Please Pick Five Case's!");
							if ( gd.StageThree == true && gd.SubStageOne3 == true )
								Say( pm.Name + ", Please Pick Four Case's!");
							if ( gd.StageFour == true && gd.SubStageOne4 == true )
								Say( pm.Name + ", Please Pick Three Case's!");
							if ( gd.StageFive == true && gd.SubStageOne5 == true )
								Say( pm.Name + ", Please Pick Two Case's!");
							if ( gd.StageSix == true && gd.SubStageOne6 == true )
								Say( pm.Name + ", Please Pick One Case!");
							if ( gd.StageSeven == true && gd.SubStageOne7 == true )
								Say( pm.Name + ", Please Pick One Case!");
							if ( gd.StageEight == true && gd.SubStageOne8 == true )
								Say( pm.Name + ", Please Pick One Case!");
							if ( gd.StageNine == true && gd.SubStageOne9 == true )
								Say( pm.Name + ", Please Pick One Case!");

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, NoDeal OK" );

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );
							break;
						}
						Say("Not time to make a Deal yet!");
						break;
					}
					case "trade":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.OfferSel == true && gd.StageTen == true  )
						{
							pm.PlaySound( 1051 );
							Banker = false;
							gd.Banker = false;
							gd.Trade = true;
							gd.NoTrade = false;
							gd.OfferSel = false;
							gd.CaseSel = false;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Trade OK" );
							break;
						}
						Say( pm.Name + ", It's not time to make a Trade yet!");
						break;
					}
					case "notrade":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.OfferSel == true && gd.StageTen == true )
						{
							pm.PlaySound( 1051 );
							Banker = false;
							gd.Banker = false;
							gd.Trade = false;
							gd.NoTrade = true;
							gd.OfferSel = false;
							gd.CaseSel = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, NoTrade OK" );
							break;
						}
						Say( pm.Name + ", It's not time to make a Trade yet!");
						break;
					}
					case "case1":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD1 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Claudia, Please open your case!");
							C1.Delete();
							CD1 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 1 OK" );
							break;
						}
						if ( CD1 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case2":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD2 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Stacey, Please open your case!");
							C2.Delete();
							CD2 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 2 OK" );
							break;
						}
						if ( CD2 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case3":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD3 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Lisa, Please open your case!");
							C3.Delete();
							CD3 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 3 OK" );
							break;
						}
						if ( CD3 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case4":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD4 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Keltie, Please open your case!");
							C4.Delete();
							CD4 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 4 OK" );
							break;
						}
						if ( CD4 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case5":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD5 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Ursula, Please open your case!");
							C5.Delete();
							CD5 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 5 OK" );
							break;
						}
						if ( CD5 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case6":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD6 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Megan, Please open your case!");
							C6.Delete();
							CD6 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 6 OK" );
							break;
						}
						if ( CD6 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case7":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD7 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Sara, Please open your case!");
							C7.Delete();
							CD7 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 7 OK" );
							break;
						}
						if ( CD7 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case8":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD8 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Lauren, Please open your case!");
							C8.Delete();
							CD8 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 8 OK" );
							break;
						}
						if ( CD8 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case9":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD9 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Patricia, Please open your case!");
							C9.Delete();
							CD9 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 9 OK" );
							break;
						}
						if ( CD9 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case10":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD10 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Anya, Please open your case!");
							C10.Delete();
							CD10 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 10 OK" );
							break;
						}
						if ( CD10 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case11":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD11 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Katie, Please open your case!");
							C11.Delete();
							CD11 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 11 OK" );
							break;
						}
						if ( CD11 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case12":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD12 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Jill, Please open your case!");
							C12.Delete();
							CD12 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 12 OK" );
							break;
						}
						if ( CD12 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case13":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD13 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Leyla, Please open your case!");
							C13.Delete();
							CD13 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 13 OK" );
							break;
						}
						if ( CD13 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case14":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD14 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Pilar, Please open your case!");
							C14.Delete();
							CD14 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 14 OK" );
							break;
						}
						if ( CD14 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case15":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD15 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Brooke, Please open your case!");
							C15.Delete();
							CD15 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 15 OK" );
							break;
						}
						if ( CD15 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case16":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD16 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Krissy, Please open your case!");
							C16.Delete();
							CD16 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 16 OK" );
							break;
						}
						if ( CD16 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case17":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD17 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Jenelle, Please open your case!");
							C17.Delete();
							CD17 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 17 OK" );
							break;
						}
						if ( CD17 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case18":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD18 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Marisa, Please open your case!");
							C18.Delete();
							CD18 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 18 OK" );
							break;
						}
						if ( CD18 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case19":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD19 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Mylinda, Please open your case!");
							C19.Delete();
							CD19 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 19 OK" );
							break;
						}
						if ( CD19 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case20":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD20 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Alike, Please open your case!");
							C20.Delete();
							CD20 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 20 OK" );
							break;
						}
						if ( CD20 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case21":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD21 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Tameka, Please open your case!");
							C21.Delete();
							CD21 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 21 OK" );
							break;
						}
						if ( CD21 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case22":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD22 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )		
								Say("Lianna, Please open your case!");
							C22.Delete();
							CD22 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 22 OK" );
							break;
						}
						if ( CD22 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case23":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD23 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Aubrie, Please open your case!");
							C23.Delete();
							CD23 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 23 OK" );
							break;
						}
						if ( CD23 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case24":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD24 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Kelly, Please open your case!");
							C24.Delete();
							CD24 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 24 OK" );
							break;
						}
						if ( CD24 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case25":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD25 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Hayley Marie, Please open your case!");
							C25.Delete();
							CD25 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 25 OK" );
							break;
						}
						if ( CD25 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "case26":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.Deal != true )
							gd.PO = 1;

						if ( gd.CaseSel == true && CD26 == false )
						{
							pm.PlaySound( 1051 );
							if ( gd.PA != 0 )	
								Say("Lindsay, Please open your case!");
							C26.Delete();
							CD26 = true;
							GameSystem.PickOrder( pm, this );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Case 26 OK" );
							break;
						}
						if ( CD26 == true )
							Say( pm.Name + ", That case is already Picked, Please pick another case!");
						if ( gd.CaseSel == false )
							Say( pm.Name + ", You can't pick a case yet, check game info window for next step of game!");
						break;
					}
					case "endgame":
					{
						if ( gd.GameOver == true )
							break;

						gd.CloseCase = false;
						gd.DHelp = false;

						pm.PlaySound( pm.Female ? 783 : 1054 );
						gd.GameOver = true;
						GameSystem.EndDDGame( pm, this );

						if ( DeBugger == true )
							Console.WriteLine( "DeBug : Howey, OnSpeech, End Game OK" );
						break;
					}
					case "hearoffer":
					{
						gd.CloseCase = false;
						gd.DHelp = false;

						if ( gd.OfferSel == false )
						{
							Say( pm.Name + ", You need to pick case's before Banker Calls!");
							break;
						}

						if ( gd.Banker == true )
						{
							Say( pm.Name + ", You need to say Deal or NoDeal!");
							break;
						}
						gd.Banker = true;
						
						GameSystem.PickOrder( pm, this );

						if ( DeBugger == true )
							Console.WriteLine( "DeBug : Howey, OnSpeech, HearOffer OK" );
						break;
					}
					case "help":
					{
						if ( gd.DHelp == true )
						{
							gd.DHelp = false;

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Help Off OK" );
							break;
						}
						if ( gd.DHelp == false )
						{
							gd.DHelp = true;

							if (pm.HasGump( typeof( DoNDMainGump )))
								pm.CloseGump( typeof( DoNDMainGump ) );
							pm.SendGump( new DoNDMainGump( pm, gd ) );

							if ( DeBugger == true )
								Console.WriteLine( "DeBug : Howey, OnSpeech, Help On OK" );
							break;
						}
						pm.SendMessage( pm.Name + ", Your not playing the game, wait your turn!");
						break;
					}
				}
			}
			base.OnSpeech( e );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( (int)i_al );
			writer.Write( (int)i_cnt );
			writer.Write( (int)i_Cash );
			writer.Write( (int)i_Replay );
			writer.Write( (bool)m_DealOrNot);
			writer.Write( (bool)m_Banker);
			writer.Write( (bool)m_DeBug);
			writer.Write( (Item)i_Stone);
			writer.Write( (bool)m_CD1);
			writer.Write( (bool)m_CD2);
			writer.Write( (bool)m_CD3);
			writer.Write( (bool)m_CD4);
			writer.Write( (bool)m_CD5);
			writer.Write( (bool)m_CD6);
			writer.Write( (bool)m_CD7);
			writer.Write( (bool)m_CD8);
			writer.Write( (bool)m_CD9);
			writer.Write( (bool)m_CD10);
			writer.Write( (bool)m_CD11);
			writer.Write( (bool)m_CD12);
			writer.Write( (bool)m_CD13);
			writer.Write( (bool)m_CD14);
			writer.Write( (bool)m_CD15);
			writer.Write( (bool)m_CD16);
			writer.Write( (bool)m_CD17);
			writer.Write( (bool)m_CD18);
			writer.Write( (bool)m_CD19);
			writer.Write( (bool)m_CD20);
			writer.Write( (bool)m_CD21);
			writer.Write( (bool)m_CD22);
			writer.Write( (bool)m_CD23);
			writer.Write( (bool)m_CD24);
			writer.Write( (bool)m_CD25);
			writer.Write( (bool)m_CD26);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					i_al = (int)reader.ReadInt();
					i_cnt = (int)reader.ReadInt();
					i_Cash = (int)reader.ReadInt();
					i_Replay = (int)reader.ReadInt();
					m_DealOrNot = (bool)reader.ReadBool();
					m_Banker = (bool)reader.ReadBool();
					m_DeBug = (bool)reader.ReadBool();
					i_Stone = (Item)reader.ReadItem();
					m_CD1 = (bool)reader.ReadBool();
					m_CD2 = (bool)reader.ReadBool();
					m_CD3 = (bool)reader.ReadBool();
					m_CD4 = (bool)reader.ReadBool();
					m_CD5 = (bool)reader.ReadBool();
					m_CD6 = (bool)reader.ReadBool();
					m_CD7 = (bool)reader.ReadBool();
					m_CD8 = (bool)reader.ReadBool();
					m_CD9 = (bool)reader.ReadBool();
					m_CD10 = (bool)reader.ReadBool();
					m_CD11 = (bool)reader.ReadBool();
					m_CD12 = (bool)reader.ReadBool();
					m_CD13 = (bool)reader.ReadBool();
					m_CD14 = (bool)reader.ReadBool();
					m_CD15 = (bool)reader.ReadBool();
					m_CD16 = (bool)reader.ReadBool();
					m_CD17 = (bool)reader.ReadBool();
					m_CD18 = (bool)reader.ReadBool();
					m_CD19 = (bool)reader.ReadBool();
					m_CD20 = (bool)reader.ReadBool();
					m_CD21 = (bool)reader.ReadBool();
					m_CD22 = (bool)reader.ReadBool();
					m_CD23 = (bool)reader.ReadBool();
					m_CD24 = (bool)reader.ReadBool();
					m_CD25 = (bool)reader.ReadBool();
					m_CD26 = (bool)reader.ReadBool();
					break;
				}
			}		
		}
	}
}