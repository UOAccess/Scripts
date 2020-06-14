using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Gumps;
using Server.Items;

namespace Server.Mobiles
{
	public class GameSystem
	{
		public static void PickOrder( PlayerMobile from, Mobile m )
		{
			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return; 

			Howey bc = m as Howey;

			if ( bc == null )
				return;

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			if ( gd.PA == 0 )
			{
				CaseSelection( pm, bc );
				if (pm.HasGump( typeof( DoNDMainGump )))
					pm.CloseGump( typeof( DoNDMainGump ) );
				pm.SendGump( new DoNDMainGump( pm, gd ) );

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, PickOrder, Pick Your Case OK" );
				return;
			}

			if ( gd.Deal == true )
			{
				CaseSelection( pm, bc );
				PrizeCheck( pm, bc );
				BankOffer( pm, bc );
				if (pm.HasGump( typeof( DoNDMainGump )))
					pm.CloseGump( typeof( DoNDMainGump ) );
				pm.SendGump( new DoNDMainGump( pm, gd ) );

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, PickOrder, Deal By Pass OK" );
				return;
			}	

			if ( gd.StageOne == true )
			{
				if ( gd.SubStageOne == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Five Case's!");
					gd.SubStageOne = false;
					gd.SubStageTwo = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage one/one OK" );
					return;
				}
				if ( gd.SubStageTwo == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Four Case's!");
					gd.SubStageTwo = false;
					gd.SubStageThree = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage one/two OK" );
					return;
				}
				if ( gd.SubStageThree == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Three Case's!");
					gd.SubStageThree = false;
					gd.SubStageFour = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage one/three OK" );
					return;
				}
				if ( gd.SubStageFour == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Two Case's!");
					gd.SubStageFour = false;
					gd.SubStageFive = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage one/four OK" );
					return;
				}
				if ( gd.SubStageFive == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick One Case!");
					gd.SubStageFive = false;
					gd.SubStageSix = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage one/five OK" );
					return;
				}
				if ( gd.SubStageSix == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageSix = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage one/six OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageOne = false;
					gd.StageTwo = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage one/banker OK" );
					return;
				}
			}
			if ( gd.StageTwo == true )
			{
				if ( gd.SubStageOne2 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Four Case's!");
					gd.SubStageOne2 = false;
					gd.SubStageTwo2 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage two/one OK" );
					return;
				}
				if ( gd.SubStageTwo2 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Three Case's!");
					gd.SubStageTwo2 = false;
					gd.SubStageThree2 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage two/two OK" );
					return;
				}
				if ( gd.SubStageThree2 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Two Case's!");
					gd.SubStageThree2 = false;
					gd.SubStageFour2 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage two/three OK" );
					return;
				}
				if ( gd.SubStageFour2 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick One Case!");
					gd.SubStageFour2 = false;
					gd.SubStageFive2 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage two/four OK" );
					return;
				}
				if ( gd.SubStageFive2 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageFive2 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage two/five OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageTwo = false;
					gd.StageThree = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage two/banker OK" );
					return;
				}
			}
			if ( gd.StageThree == true )
			{
				if ( gd.SubStageOne3 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Three Case's!");
					gd.SubStageOne3 = false;
					gd.SubStageTwo3 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage three/one OK" );
					return;
				}
				if ( gd.SubStageTwo3 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Two Case's!");
					gd.SubStageTwo3 = false;
					gd.SubStageThree3 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage three/two OK" );
					return;
				}
				if ( gd.SubStageThree3 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick One Case!");
					gd.SubStageThree3 = false;
					gd.SubStageFour3 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage three/three OK" );
					return;
				}
				if ( gd.SubStageFour3 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageFour3 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage three/four OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageThree = false;
					gd.StageFour = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage three/banker OK" );
					return;
				}
			}
			if ( gd.StageFour == true )
			{
				if ( gd.SubStageOne4 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick Two Case's!");
					gd.SubStageOne4 = false;
					gd.SubStageTwo4 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage four/one OK" );
					return;
				}
				if ( gd.SubStageTwo4 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick One Case!");
					gd.SubStageTwo4 = false;
					gd.SubStageThree4 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage four/two OK" );
					return;
				}
				if ( gd.SubStageThree4 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;
					gd.Commercial = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageThree4 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage four/three OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageFour = false;
					gd.StageFive = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage four/banker OK" );
					return;
				}
			}
			if ( gd.StageFive == true )
			{
				if ( gd.SubStageOne5 == true )
				{
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Please Pick One Case!");
					gd.SubStageOne5 = false;
					gd.SubStageTwo5 = true;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage five/one OK" );
					return;
				}
				if ( gd.SubStageTwo5 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageTwo5 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage five/two OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageFive = false;
					gd.StageSix = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage five/banker OK" );
					return;
				}
			}
			if ( gd.StageSix == true )
			{
				if ( gd.SubStageOne6 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageOne6 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage six/one OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageSix = false;
					gd.StageSeven = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage six/banker OK" );
					return;
				}
			}
			if ( gd.StageSeven == true )
			{
				if ( gd.SubStageOne7 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageOne7 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage seven/one OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageSeven = false;
					gd.StageEight = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage seven/banker OK" );
					return;
				}
			}
			if ( gd.StageEight == true )
			{
				if ( gd.SubStageOne8 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageOne8 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage eight/one OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageEight = false;
					gd.StageNine = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage eight/banker OK" );
					return;
				}
			}
			if ( gd.StageNine == true )
			{
				if ( gd.SubStageOne9 == true )
				{
					CaseSelection( pm, bc );
					gd.OfferSel = true;
					gd.CaseSel = false;
					bc.Banker = true;

					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );
					bc.Say( pm.Name + ", Banker's Calling!");
					gd.SubStageOne9 = false;
					pm.PlaySound( 1447 );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage nine/one OK" );
					return;
				}
				if ( gd.Banker == true )
				{
					BankOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					gd.StageNine = false;
					gd.StageTen = true;
					bc.Say( pm.Name + ", Lets hear the Banker's offer!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage nine/banker OK" );
					return;
				}
			}
			if ( gd.StageTen == true )
			{
				gd.PO = 0;

				if ( gd.Trade == true )
				{
					TradeOffer( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage ten/trade OK" );
					return;
				}
				if ( gd.NoTrade == true )
				{
					bc.Say( pm.Name + ", The Last case had....!");
					CaseSelection( pm, bc );
					if (pm.HasGump( typeof( DoNDMainGump )))
						pm.CloseGump( typeof( DoNDMainGump ) );
					pm.SendGump( new DoNDMainGump( pm, gd ) );

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : System, PickOrder, Stage ten/NoTrade OK" );

					Timer g_timer = new CloseGameTimer( pm, bc, gd ); 
    						g_timer.Start();
					return;
				}
			}
		}

		public static void CaseSelection( PlayerMobile from, Mobile m )
		{
			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Howey bc = m as Howey;

			if ( bc == null )
				return;

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			if ( gd.CaseSel == false )
				return;

			if ( gd.PA == 0 )
			{
				gd.PA = Utility.Random( 1, 26 );
				gd.StageOne = true;
				gd.SubStageOne = true;
				gd.GameStart = true;
				bc.Say( pm.Name + ", You have Picked your case, lets start the game by picking six case's!");

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Case Selection, Player Case OK" );
				return;
			}

			gd.PC = 0;
			gd.PC = Utility.Random( 1, 26 );
			CaseAmount( pm, bc );

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Case Selection, Case Amount OK" );
		}

		public static void CaseAmount( PlayerMobile from, Mobile m )
		{
			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Howey bc = m as Howey;

			if ( bc == null )
				return;

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			if ( gd.PA == gd.PC )
			{
				CaseSelection( pm, bc );
				return;
			}

			if ( gd.OneMil == false && gd.PC == 1 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.SevFiveHT == false && gd.PC == 2 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.FiveHT == false && gd.PC == 3 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.FourHT == false && gd.PC == 4 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.ThreeHT == false && gd.PC == 5 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.TwoHT == false && gd.PC == 6 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.OneHT == false && gd.PC == 7 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.SevFiveTH == false && gd.PC == 8 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.FiftyTH == false && gd.PC == 9 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.TweFiveTH == false && gd.PC == 10 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.TenTH == false && gd.PC == 11 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.FiveTH == false && gd.PC == 12 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.OneTH == false && gd.PC == 13 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.SevFiveH == false && gd.PC == 14 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.FiveH == false && gd.PC == 15 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.FourH == false && gd.PC == 16 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.ThreeH == false && gd.PC == 17 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.TwoH == false && gd.PC == 18 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.OneH == false && gd.PC == 19 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.SevFive == false && gd.PC == 20 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.Fifty == false && gd.PC == 21 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.TweFive == false && gd.PC == 22 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.Ten == false && gd.PC == 23 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.Five == false && gd.PC == 24 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.One == false && gd.PC == 25 )
			{
				CaseSelection( pm, bc );
				return;
			}
			if ( gd.Zero == false && gd.PC == 26 )
			{
				CaseSelection( pm, bc );
				return;
			}

			if ( gd.Deal == true )
				gd.PO +=1;

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Case Selection OK" );

			if ( gd.OneMil == true && gd.PC == 1 )
			{
				pm.PlaySound( 1372 );
				bc.Say("The case has One Million Gold!");
				gd.OneMil = false;
				return;
			}
			if ( gd.SevFiveHT == true && gd.PC == 2 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Sevent Hundread and Fifty Thousand Gold!");
				gd.SevFiveHT = false;
				return;
			}
			if ( gd.FiveHT == true && gd.PC == 3 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Five Hundred Thousand Gold!");
				gd.FiveHT = false;
				return;
			}
			if ( gd.FourHT == true && gd.PC == 4 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Four Hundred Thousand Gold!");
				gd.FourHT = false;
				return;
			}
			if ( gd.ThreeHT == true && gd.PC == 5 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Three Hundred Thousand Gold!");
				gd.ThreeHT = false;
				return;
			}
			if ( gd.TwoHT == true && gd.PC == 6 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Two Hundred Thousand Gold!");
				gd.TwoHT = false;
				return;
			}
			if ( gd.OneHT == true && gd.PC == 7 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has One Hundred Thousand Gold!");
				gd.OneHT = false;
				return;
			}
			if ( gd.SevFiveTH == true && gd.PC == 8 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Seventy Five Thousand Gold!");
				gd.SevFiveTH = false;
				return;
			}
			if ( gd.FiftyTH == true && gd.PC == 9 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Fifty Thousand Gold!");
				gd.FiftyTH = false;
				return;
			}
			if ( gd.TweFiveTH == true && gd.PC == 10 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Twenty Five Thousand Gold!");
				gd.TweFiveTH = false;
				return;
			}
			if ( gd.TenTH == true && gd.PC == 11 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Ten Thousand Gold!");
				gd.TenTH = false;
				return;
			}
			if ( gd.FiveTH == true && gd.PC == 12 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has Five Thousand Gold!");
				gd.FiveTH = false;
				return;
			}
			if ( gd.OneTH == true && gd.PC == 13 )
			{
				pm.PlaySound( pm.Female ? 795 : 1067 );
				bc.Say("The case has One Thousand Gold!");
				gd.OneTH = false;
				return;
			}
			if ( gd.SevFiveH == true && gd.PC == 14 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Seven Hundred and Fifty Gold!");
				gd.SevFiveH = false;
				return;
			}
			if ( gd.FiveH == true && gd.PC == 15 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Five Hundred Gold!");
				gd.FiveH = false;
				return;
			}
			if ( gd.FourH == true && gd.PC == 16 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Four Hundred Gold!");
				gd.FourH = false;
				return;
			}
			if ( gd.ThreeH == true && gd.PC == 17 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Three Hundred Gold!");
				gd.ThreeH = false;
				return;
			}
			if ( gd.TwoH == true && gd.PC == 18 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Two Hundred Gold!");
				gd.TwoH = false;
				return;
			}
			if ( gd.OneH == true && gd.PC == 19 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has One Hundred Gold!");
				gd.OneH = false;
				return;
			}
			if ( gd.SevFive == true && gd.PC == 20 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Seventy Five Gold!");
				gd.SevFive = false;
				return;
			}
			if ( gd.Fifty == true && gd.PC == 21 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Fifty Gold!");
				gd.Fifty = false;
				return;
			}
			if ( gd.TweFive == true && gd.PC == 22 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Twenty Five Gold!");
				gd.TweFive = false;
				return;
			}
			if ( gd.Ten == true && gd.PC == 23 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Ten Gold!");
				gd.Ten = false;
				return;
			}
			if ( gd.Five == true && gd.PC == 24 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has Five Gold!");
				gd.Five = false;
				return;
			}
			if ( gd.One == true && gd.PC == 25 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has One Gold!");
				gd.One = false;
				return;
			}
			if ( gd.Zero == true && gd.PC == 26 )
			{
				pm.PlaySound( pm.Female ? 783 : 1054 );
				bc.Say("The case has a Prize!");
				gd.Zero = false;
				return;
			}
			CaseSelection( pm, bc );
		}

		public static void TradeOffer( PlayerMobile from, Mobile m )
		{
			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Howey bc = m as Howey;

			if ( bc == null )
				return;

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			if ( gd.Trade == false )
				return;

			gd.PC = gd.PA;
			
			pm.PlaySound( 1051 );

			if ( gd.OneMil == true && gd.PA != 1 )
				gd.PA = 1;
			if ( gd.SevFiveHT == true && gd.PA != 2 )
				gd.PA = 2;
			if ( gd.FiveHT == true && gd.PA != 3 )
				gd.PA = 3;
			if ( gd.FourHT == true && gd.PA != 4 )
				gd.PA = 4;
			if ( gd.ThreeHT == true && gd.PA != 5 )
				gd.PA = 5;
			if ( gd.TwoHT == true && gd.PA != 6 )
				gd.PA = 6;
			if ( gd.OneHT == true && gd.PA != 7 )
				gd.PA = 7;
			if ( gd.SevFiveTH == true && gd.PA != 8 )
				gd.PA = 8;
			if ( gd.FiftyTH == true && gd.PA != 9 )
				gd.PA = 9;
			if ( gd.TweFiveTH == true && gd.PA != 10 )
				gd.PA = 10;
			if ( gd.TenTH == true && gd.PA != 11 )
				gd.PA = 11;
			if ( gd.FiveTH == true && gd.PA != 12 )
				gd.PA = 12;
			if ( gd.OneTH == true && gd.PA != 13 )
				gd.PA = 13;
			if ( gd.SevFiveH == true && gd.PA != 14 )
				gd.PA = 14;
			if ( gd.FiveH == true && gd.PA != 15 )
				gd.PA = 15;
			if ( gd.FourH == true && gd.PA != 16 )
				gd.PA = 16;
			if ( gd.ThreeH == true && gd.PA != 17 )
				gd.PA = 17;
			if ( gd.TwoH == true && gd.PA != 18 )
				gd.PA = 18;
			if ( gd.OneH == true && gd.PA != 19 )
				gd.PA = 19;
			if ( gd.SevFive == true && gd.PA != 20 )
				gd.PA = 20;
			if ( gd.Fifty == true && gd.PA != 21 )
				gd.PA = 21;
			if ( gd.TweFive == true && gd.PA != 22 )
				gd.PA = 22;
			if ( gd.Ten == true && gd.PA != 23 )
				gd.PA = 23;
			if ( gd.Five == true && gd.PA != 24 )
				gd.PA = 24;
			if ( gd.One == true && gd.PA != 25 )
				gd.PA = 25;
			if ( gd.Zero == true && gd.PA != 26 )
				gd.PA = 26;

			if ( gd.PC > gd.PA )
			{
				bc.Say( pm.Name + ", You traded for Less!");
				pm.PlaySound( pm.Female ? 795 : 1067 );
			}
			if ( gd.PC < gd.PA )
			{
				bc.Say( pm.Name + ", You traded for More!");
				pm.PlaySound( pm.Female ? 783 : 1054 );
			}

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Trade Offer OK" );

			PrizeCheck( pm, bc );
		}

		public static void BankOffer( PlayerMobile from, Mobile m )
		{
			int offer = 3418416;

			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Howey bc = m as Howey;

			if ( bc == null )
				return;

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			gd.DA9 = 0;

			if ( gd.OneMil == false )
				offer -=gd.CA26;
			if ( gd.SevFiveHT == false )
				offer -=gd.CA25;
			if ( gd.FiveHT == false )
				offer -=gd.CA24;
			if ( gd.FourHT == false )
				offer -=gd.CA23;
			if ( gd.ThreeHT == false )
				offer -=gd.CA22;
			if ( gd.TwoHT == false )
				offer -=gd.CA21;
			if ( gd.OneHT == false )
				offer -=gd.CA20;
			if ( gd.SevFiveTH == false )
				offer -=gd.CA19;
			if ( gd.FiftyTH == false )
				offer -=gd.CA18;
			if ( gd.TweFiveTH == false )
				offer -=gd.CA17;
			if ( gd.TenTH == false )
				offer -=gd.CA16;
			if ( gd.FiveTH == false )
				offer -=gd.CA15;
			if ( gd.OneTH == false )
				offer -=gd.CA14;
			if ( gd.SevFiveH == false )
				offer -=gd.CA13;
			if ( gd.FiveH == false )
				offer -=gd.CA12;
			if ( gd.FourH == false )
				offer -=gd.CA11;
			if ( gd.ThreeH == false )
				offer -=gd.CA10;
			if ( gd.TwoH == false )
				offer -=gd.CA9;
			if ( gd.OneH == false )
				offer -=gd.CA8;
			if ( gd.SevFive == false )
				offer -=gd.CA7;
			if ( gd.Fifty == false )
				offer -=gd.CA6;
			if ( gd.TweFive == false )
				offer -=gd.CA5;
			if ( gd.Ten == false )
				offer -=gd.CA4;
			if ( gd.Five == false )
				offer -=gd.CA3;
			if ( gd.One == false )
				offer -=gd.CA2;
			if ( gd.Zero == false )
				offer -=gd.CA1;

			gd.DA9 = offer;

			if ( gd.Deal == false )
				bc.AL = gd.DA9;

			if ( bc.AL >= 1000000 &&  gd.Deal == false )
				pm.PlaySound( pm.Female ? 783 : 1054 );
			if ( bc.AL <= 999999 && gd.Deal == false )
				pm.PlaySound( pm.Female ? 795 : 1067 );

			if ( gd.GO == 19 && gd.Deal == true )
			{
				if ( gd.PO == 19 )
					gd.DA9 = gd.DA9/2;
				if ( gd.PO == 18 )
					gd.DA8 = gd.DA9/5;
				if ( gd.PO == 17 )
					gd.DA7 = gd.DA9/10;
				if ( gd.PO == 16 )
					gd.DA6 = gd.DA9/20;
				if ( gd.PO == 15 )
					gd.DA5 = gd.DA9/30;
				if ( gd.PO == 13 )
					gd.DA4 = gd.DA9/40;
				if ( gd.PO == 10 )
					gd.DA3 = gd.DA9/50;
				if ( gd.PO == 6 )
					gd.DA2 = gd.DA9/60;

				if ( gd.PO == 19 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);
				if ( gd.PO == 18 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/5);
				if ( gd.PO == 17 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/10);
				if ( gd.PO == 16 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/20);
				if ( gd.PO == 15 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/30);
				if ( gd.PO == 13 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/40);
				if ( gd.PO == 10 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/50);
				if ( gd.GO == 6 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/60);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 2 Caculation OK" );
				return;
			}

			if ( gd.GO == 14 && gd.Deal == true )
			{
				if ( gd.PO == 14 )
					gd.DA9 = gd.DA9/2;
				if ( gd.PO == 13 )
					gd.DA8 = gd.DA9/5;
				if ( gd.PO == 12 )
					gd.DA7 = gd.DA9/10;
				if ( gd.PO == 11 )
					gd.DA6 = gd.DA9/20;
				if ( gd.PO == 10 )
					gd.DA5 = gd.DA9/30;
				if ( gd.PO == 8 )
					gd.DA4 = gd.DA9/40;
				if ( gd.PO == 5 )
					gd.DA3 = gd.DA9/50;

				if ( gd.PO == 14 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);
				if ( gd.PO == 13 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/5);
				if ( gd.PO == 12 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/10);
				if ( gd.PO == 11 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/20);
				if ( gd.PO == 10 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/30);
				if ( gd.PO == 8 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/40);
				if ( gd.PO == 5 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/50);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 3 Caculation OK" );
				return;
			}

			if ( gd.GO == 10 && gd.Deal == true )
			{
				if ( gd.PO == 10 )
					gd.DA9 = gd.DA9/2;
				if ( gd.PO == 9 )
					gd.DA8 = gd.DA9/5;
				if ( gd.PO == 8 )
					gd.DA7 = gd.DA9/10;
				if ( gd.PO == 7 )
					gd.DA6 = gd.DA9/20;
				if ( gd.PO == 6 )
					gd.DA5 = gd.DA9/30;
				if ( gd.PO == 4 )
					gd.DA4 = gd.DA9/40;

				if ( gd.PO == 10 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);
				if ( gd.PO == 9 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/5);
				if ( gd.PO == 8 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/10);
				if ( gd.PO == 7 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/20);
				if ( gd.PO == 6 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/30);
				if ( gd.PO == 4 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/40);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 4 Caculation OK" );
				return;
			}

			if ( gd.GO == 7 && gd.Deal == true )
			{
				if ( gd.PO == 7 )
					gd.DA9 = gd.DA9/2;
				if ( gd.PO == 6 )
					gd.DA8 = gd.DA9/5;
				if ( gd.PO == 5 )
					gd.DA7 = gd.DA9/10;
				if ( gd.PO == 4 )
					gd.DA6 = gd.DA9/20;
				if ( gd.PO == 3 )
					gd.DA5 = gd.DA9/30;

				if ( gd.PO == 7 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);
				if ( gd.PO == 6 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/5);
				if ( gd.PO == 5 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/10);
				if ( gd.PO == 4 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/20);
				if ( gd.PO == 3 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/30);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 5 Caculation OK" );
				return;
			}

			if ( gd.GO == 5 && gd.Deal == true )
			{
				if ( gd.PO == 5 )
					gd.DA9 = gd.DA9/2;
				if ( gd.PO == 4 )
					gd.DA8 = gd.DA9/5;
				if ( gd.PO == 3 )
					gd.DA7 = gd.DA9/10;
				if ( gd.PO == 2 )
					gd.DA6 = gd.DA9/20;

				if ( gd.PO == 5 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);
				if ( gd.PO == 4 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/5);
				if ( gd.PO == 3 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/10);
				if ( gd.PO == 2 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/20);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 6 Caculation OK" );
				return;
			}

			if (  gd.GO == 4 && gd.Deal == true )
			{
				if ( gd.PO == 4 )
					gd.DA9 = gd.DA9/2;
				if ( gd.PO == 3 )
					gd.DA8 = gd.DA9/5;
				if ( gd.PO == 2 )
					gd.DA7 = gd.DA9/10;

				if ( gd.PO == 4 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);
				if ( gd.PO == 3 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/5);
				if ( gd.PO == 2 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/10);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 7 Caculation OK" );
				return;
			}

			if ( gd.GO == 3 && gd.Deal == true )
			{
				if ( gd.PO == 3 )
					gd.DA9 = gd.DA9/2;
				if ( gd.PO == 2 )
					gd.DA8 = gd.DA9/5;

				if ( gd.PO == 3 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);
				if ( gd.PO == 2 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/5);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 8 Caculation OK" );
				return;
			}

			if ( gd.GO == 2 && gd.Deal == true )
			{
				if ( gd.PO == 2 )
					gd.DA9 = gd.DA9/2;

				if ( gd.PO == 2 )
					bc.Say( pm.Name + ", You missed the offer of " + gd.DA9/2);

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Missed Deal 9 Caculation OK" );
				return;
			}
			
			if ( gd.OfferSel == true && gd.Banker == true )
			{
				if ( gd.StageOne == true )
					gd.DA1 = gd.DA9/70;
				if ( gd.StageTwo == true )
					gd.DA2 = gd.DA9/60;
				if ( gd.StageThree == true )
					gd.DA3 = gd.DA9/50;
				if ( gd.StageFour == true )
					gd.DA4 = gd.DA9/40;
				if ( gd.StageFive == true )
					gd.DA5 = gd.DA9/30;
				if ( gd.StageSix == true )
					gd.DA6 = gd.DA9/20;
				if ( gd.StageSeven == true )
					gd.DA7 = gd.DA9/10;
				if ( gd.StageEight == true )
					gd.DA8 = gd.DA9/5;
				if ( gd.StageNine == true )
					gd.DA9 = gd.DA9/2;

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Offer Caculation OK" );
				return;
			}

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, No Offer Caculation OK" );
		}

		public static void PrizeCheck( PlayerMobile from, Mobile m )
		{
			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Howey bc = m as Howey;

			if ( bc == null )
				return;

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			if ( gd.DealOn == false )
				return;

			if ( gd.Deal == true )
			{
				if ( gd.GO == 0 )
				{
					if ( gd.OneMil == true )
						gd.GO +=1;
					if ( gd.SevFiveHT == true )
						gd.GO +=1;
					if ( gd.FiveHT == true )
						gd.GO +=1;
					if ( gd.FourHT == true )
						gd.GO +=1;
					if ( gd.ThreeHT == true )
						gd.GO +=1;
					if ( gd.TwoHT == true )
						gd.GO +=1;
					if ( gd.OneHT == true )
						gd.GO +=1;
					if ( gd.SevFiveTH == true )
						gd.GO +=1;
					if ( gd.FiftyTH == true )
						gd.GO +=1;
					if ( gd.TweFiveTH == true )
						gd.GO +=1;
					if ( gd.TenTH == true )
						gd.GO +=1;
					if ( gd.FiveTH == true )
						gd.GO +=1;
					if ( gd.OneTH == true )
						gd.GO +=1;
					if ( gd.SevFiveH == true )
						gd.GO +=1;
					if ( gd.FiveH == true )
						gd.GO +=1;
					if ( gd.FourH == true )
						gd.GO +=1;
					if ( gd.ThreeH == true )
						gd.GO +=1;
					if ( gd.TwoH == true )
						gd.GO +=1;
					if ( gd.OneH == true )
						gd.GO +=1;
					if ( gd.SevFive == true )
						gd.GO +=1;
					if ( gd.Fifty == true )
						gd.GO +=1;
					if ( gd.TweFive == true )
						gd.GO +=1;
					if ( gd.Ten == true )
						gd.GO +=1;
					if ( gd.Five == true )
						gd.GO +=1;
					if ( gd.One == true )
						gd.GO +=1;
					if ( gd.Zero == true )
						gd.GO +=1;
					gd.GO -=1;

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : Howey, Prize Check, Deal Girl Check OK" );
				}

				if ( gd.PO < gd.GO )
				{ 
					bc.Say( pm.Name + ", Please select another case to see what you missed!");

					if ( bc.DeBugger == true )
						Console.WriteLine( "DeBug : Howey, Prize Check, Deal Girl Reject OK" );
					return;
				}

				pm.PlaySound( 1051 );

				if ( gd.StageTwo == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA1) );
					bc.Cash +=gd.DA1;
				}
				if ( gd.StageThree == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA2) );
					bc.Cash +=gd.DA2;
				}
				if ( gd.StageFour == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA3) );
					bc.Cash +=gd.DA3;
				}
				if ( gd.StageFive == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA4) );
					bc.Cash +=gd.DA4;
				}
				if ( gd.StageSix == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA5) );
					bc.Cash +=gd.DA5;
				}
				if ( gd.StageSeven == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA6) );
					bc.Cash +=gd.DA6;
				}
				if ( gd.StageEight == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA7) );
					bc.Cash +=gd.DA7;
				}
				if ( gd.StageNine == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA8) );
					bc.Cash +=gd.DA8;
				}
				if ( gd.StageTen == true )
				{
					pm.AddToBackpack( new BankCheck(gd.DA9) );
					bc.Cash +=gd.DA9;
				}
				if ( gd.StageTwo == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA1 );
				if ( gd.StageThree == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA2 );
				if ( gd.StageFour == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA3 );
				if ( gd.StageFive == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA4 );
				if ( gd.StageSix == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA5 );
				if ( gd.StageSeven == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA6 );
				if ( gd.StageEight == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA7 );
				if ( gd.StageNine == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA8 );
				if ( gd.StageTen == true )
					bc.Say( pm.Name + ", You took the offer of.....$" + gd.DA9 );

				gd.GameOver = true;
				EndDDGame( pm, bc );

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Prize Check, Deal OK" );
				return;
			}

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Prize Check, NoDeal OK" );

			if ( gd.OneMil == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $1,000,000");
				pm.AddToBackpack( new BankCheck(1000000) );
				bc.Cash +=1000000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.SevFiveHT == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $750,000");
				pm.AddToBackpack( new BankCheck(750000) );
				bc.Cash +=750000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.FiveHT == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $500,000");
				pm.AddToBackpack( new BankCheck(500000) );
				bc.Cash +=500000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.FourHT == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $400,000");
				pm.AddToBackpack( new BankCheck(400000) );
				bc.Cash +=400000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.ThreeHT == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $300,000");
				pm.AddToBackpack( new BankCheck(300000) );
				bc.Cash +=300000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.TwoHT == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $200,000");
				pm.AddToBackpack( new BankCheck(200000) );
				bc.Cash +=200000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.OneHT == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $100,000");
				pm.AddToBackpack( new BankCheck(100000) );
				bc.Cash +=100000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.SevFiveTH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $75,000");
				pm.AddToBackpack( new BankCheck(75000) );
				bc.Cash +=75000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.FiftyTH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $50,000");
				pm.AddToBackpack( new BankCheck(50000) );
				bc.Cash +=50000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.TweFiveTH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $25,000");
				pm.AddToBackpack( new BankCheck(25000) );
				bc.Cash +=25000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.TenTH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $10,000");
				pm.AddToBackpack( new BankCheck(10000) );
				bc.Cash +=10000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.FiveTH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $5,000");
				pm.AddToBackpack( new BankCheck(5000) );
				bc.Cash +=5000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.OneTH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $1,000");
				pm.AddToBackpack( new Gold(1000) );
				bc.Cash +=1000;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.SevFiveH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $750");
				pm.AddToBackpack( new Gold(750) );
				bc.Cash +=750;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.FiveH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $500");
				pm.AddToBackpack( new Gold(500) );
				bc.Cash +=500;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.FourH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $400");
				pm.AddToBackpack( new Gold(400) );
				bc.Cash +=400;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.ThreeH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $300");
				pm.AddToBackpack( new Gold(300) );
				bc.Cash +=300;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.TwoH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $200");
				pm.AddToBackpack( new Gold(200) );
				bc.Cash +=200;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.OneH == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $100");
				pm.AddToBackpack( new Gold(100) );
				bc.Cash +=100;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.SevFive == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $75");
				pm.AddToBackpack( new Gold(75) );
				bc.Cash +=75;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.Fifty == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $50");
				pm.AddToBackpack( new Gold(50) );
				bc.Cash +=50;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.TweFive == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $25");
				pm.AddToBackpack( new Gold(25) );
				bc.Cash +=25;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.Ten == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $10");
				pm.AddToBackpack( new Gold(10) );
				bc.Cash +=10;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.Five == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $5");
				pm.AddToBackpack( new Gold(5) );
				bc.Cash +=5;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.One == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won $1");
				pm.AddToBackpack( new Gold(1) );
				bc.Cash +=1;
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
			if ( gd.Zero == true )
			{
				pm.PlaySound( 1051 );
				bc.Say( pm.Name + ", You Won a Prize!");
				switch ( Utility.Random( 16 ) )
				{
					default:
					case  0: pm.AddToBackpack( new DoNDDoll() ); break;
					case  1: pm.AddToBackpack( new DoNDDoll() ); break;
					case  2: pm.AddToBackpack( new DoNDDoll() ); break;
					case  3: pm.AddToBackpack( new DoNDDoll() ); break;
					case  4: pm.AddToBackpack( new DoNDDoll() ); break;
					case  5: pm.AddToBackpack( new DoNDDoll() ); break;
					case  6: pm.AddToBackpack( new DoNDDoll() ); break;
					case  7: pm.AddToBackpack( new DoNDDoll() ); break;
					case  8: pm.AddToBackpack( new DoNDDoll() ); break;
					case  9: pm.AddToBackpack( new DoNDDoll() ); break;
					case  10: pm.AddToBackpack( new DoNDDoll() ); break;
					case  11: pm.AddToBackpack( new DoNDDoll() ); break;
					case  12: pm.AddToBackpack( new DoNDDoll() ); break;
					case  13: pm.AddToBackpack( new DoNDHoweyDoll() ); break;
					case  14: pm.AddToBackpack( new DoNDBankerDoll() ); break;
					case  15: pm.AddToBackpack( new DoNDGameTicket() ); break;
				}
				gd.GameOver = true;
				EndDDGame( pm, bc );
				return;
			}
		}
		public static void StartDDGame( PlayerMobile from, Mobile m )
		{
			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Howey bc = m as Howey;

			if ( bc == null )
				return;
					
			Console.WriteLine( "A Player has started Deal or No Deal : Game Started" );

			SpawnGirls1(bc, pm);
			SpawnGirls2(bc, pm);
			SpawnGirls3(bc, pm);
			SpawnGirls4(bc, pm);
			SpawnGirls5(bc, pm);
			SpawnGirls6(bc, pm);
			SpawnGirls7(bc, pm);
			SpawnGirls8(bc, pm);
			SpawnGirls9(bc, pm);
			SpawnGirls10(bc, pm);
			SpawnGirls11(bc, pm);
			SpawnGirls12(bc, pm);
			SpawnGirls13(bc, pm);
			SpawnGirls14(bc, pm);
			SpawnGirls15(bc, pm);
			SpawnGirls16(bc, pm);
			SpawnGirls17(bc, pm);
			SpawnGirls18(bc, pm);
			SpawnGirls19(bc, pm);
			SpawnGirls20(bc, pm);
			SpawnGirls21(bc, pm);
			SpawnGirls22(bc, pm);
			SpawnGirls23(bc, pm);
			SpawnGirls24(bc, pm);
			SpawnGirls25(bc, pm);
			SpawnGirls26(bc, pm);

			pm.AddToBackpack( new DoNDGameDeed( pm, bc ) );

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );
		
			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			gd.DealOn = true;
			bc.DealOn = true;
			pm.Frozen = true;
			gd.CaseSel = true;
			gd.PO = 0;
			
			if (pm.HasGump( typeof( DoNDMainGump )))
				pm.CloseGump( typeof( DoNDMainGump ) );
			pm.SendGump( new DoNDMainGump( pm, gd ) );
			
			if (pm.HasGump( typeof( DoNDPlayerGump )))
				pm.CloseGump( typeof( DoNDPlayerGump ) );
			pm.SendGump( new DoNDPlayerGump() );

			pm.SendMessage(33, pm.Name + ", You only have 20 minutes to play a game!");

			Timer i_timer = new ItemDeleteTimer( pm, bc, gd ); 
    				i_timer.Start();

			Timer p_timer = new PlayerResetTimer( pm, bc ); 
    				p_timer.Start();

			Timer m_timer = new MobileDeleteTimer( pm, bc ); 
    				m_timer.Start();

			bc.Say( pm.Name + ", Welcome to Deal or No Deal");

			bc.Say( pm.Name + ", Please Select your case!");

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Start Game OK" );
		}

		public static void EndDDGame( PlayerMobile from, Mobile m )
		{
			PlayerMobile pm = from as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;
			
			Howey bc = m as Howey;

			if ( bc == null )
				return;

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
				return;

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
				return;

			if ( gd.GameOver == false )
				return;

			Timer g_timer = new CloseGameTimer( pm, bc, gd ); 
    				g_timer.Start();

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
                    			}
                		}
            		}

            		foreach (Mobile Girls in toDelete)
                		Girls.Delete();

            		toDelete.Clear();
			
			if (pm.HasGump( typeof( DoNDPlayerGump )))
				pm.CloseGump( typeof( DoNDPlayerGump ) );

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, End Game OK" );
		}

		public static void SpawnGirls1( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 5, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X;
			int y = pm.Y -= 3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #5";
			girls.Name = "Ursula";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1044;

			pm.Y += 3;
		}

		public static void SpawnGirls2( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 13, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #13";
			girls.Name = "Leyla";
			girls.Hue = 1048;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1124;
		}

		public static void SpawnGirls3( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 22, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X;
			int y = pm.Y -5;
			int z = pm.Z +10;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #22";
			girls.Name = "Lianna";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1124;
		}

		public static void SpawnGirls4( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 4, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -1;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #4";
			girls.Name = "Keltie";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1553;
		}

		public static void SpawnGirls5( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 3, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -2;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #3";
			girls.Name = "Lisa";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 2213;
		}

		public static void SpawnGirls6( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 2, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -3;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #2";
			girls.Name = "Stacey";
			girls.Hue = 1048;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1124;
		}

		public static void SpawnGirls7( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 1, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -4;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #1";
			girls.Name = "Claudia";
			girls.Hue = 1725;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1044;
		}

		public static void SpawnGirls8( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 6, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +1;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #6";
			girls.Name = "Megan";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1044;
		}

		public static void SpawnGirls9( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 7, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +2;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #7";
			girls.Name = "Sara";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1044;
		}

		public static void SpawnGirls10( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 8, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +3;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #8";
			girls.Name = "Lauren";
			girls.Hue = 1048;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1175;
		}

		public static void SpawnGirls11( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 9, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +4;
			int y = pm.Y -3;
			int z = pm.Z;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #9";
			girls.Name = "Patricia";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 2213;
		}

		public static void SpawnGirls12( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 12, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -1;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #12";
			girls.Name = "Jill";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1124;
		}

		public static void SpawnGirls13( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 11, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -2;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #11";
			girls.Name = "Katie";
			girls.Hue = 1048;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1044;
		}

		public static void SpawnGirls14( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 10, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -3;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #10";
			girls.Name = "Anya";
			girls.Hue = 1002;
			girls.HairItemID = 0x203B;
			girls.HairHue = 2213;
		}

		public static void SpawnGirls15( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 14, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +1;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #14";
			girls.Name = "Pilar";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1044;
		}

		public static void SpawnGirls16( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 15, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +2;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #15";
			girls.Name = "Brooke";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 2213;
		}

		public static void SpawnGirls17( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 16, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +3;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #16";
			girls.Name = "Krissy";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1553;
		}

		public static void SpawnGirls18( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 17, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +4;
			int y = pm.Y -4;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #17";
			girls.Name = "Jenelle";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1124;
		}

		public static void SpawnGirls19( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 21, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -1;
			int y = pm.Y -5;
			int z = pm.Z +10;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #21";
			girls.Name = "Tameka";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1175;
		}

		public static void SpawnGirls20( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 20, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -2;
			int y = pm.Y -5;
			int z = pm.Z +10;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #20";
			girls.Name = "Alike";
			girls.Hue = 1725;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1175;
		}

		public static void SpawnGirls21( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 19, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -3;
			int y = pm.Y -5;
			int z = pm.Z +10;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #19";
			girls.Name = "Mylinda";
			girls.Hue = 1048;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1175;
		}

		public static void SpawnGirls22( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 18, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X -4;
			int y = pm.Y -5;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #18";
			girls.Name = "Marisa";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1124;
		}

		public static void SpawnGirls23( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 23, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +1;
			int y = pm.Y -5;
			int z = pm.Z +10;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #23";
			girls.Name = "Aubrie";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 2213;
		}

		public static void SpawnGirls24( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 24, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +2;
			int y = pm.Y -5;
			int z = pm.Z +10;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #24";
			girls.Name = "Kelly";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 1044;
		}

		public static void SpawnGirls25( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 25, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +3;
			int y = pm.Y -5;
			int z = pm.Z +10;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #25";
			girls.Name = "Hayley Marie";
			girls.Hue = 1048;
			girls.HairItemID = 0x2047;
			girls.HairHue = 1044;
		}

		public static void SpawnGirls26( Mobile target, Mobile player )
		{
			Howey pm = target as Howey;

			PlayerMobile pl = player as PlayerMobile;

			if ( pm == null || pl == null )
				return;

			Map map = pm.Map;

			if ( map == null )
				return;

			Girls girls = new Girls( 26, pl, pm );

			Point3D loc = pm.Location;
			
			int x = pm.X +4;
			int y = pm.Y -5;
			int z = pm.Z +5;

			loc = new Point3D( x, y, z );
			
			girls.MoveToWorld( loc, map );

			girls.Title = "The Model holding Case #26";
			girls.Name = "Lindsay";
			girls.Hue = 1002;
			girls.HairItemID = 0x203C;
			girls.HairHue = 2213;

			pm.Say( "Lets bring out the girls!");
		}
	}
}