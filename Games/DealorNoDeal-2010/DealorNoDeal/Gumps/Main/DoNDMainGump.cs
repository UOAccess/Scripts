using System;
using Server;
using Server.Network;
using Server.Mobiles;
using Server.Items;

namespace Server.Gumps
{
    	public class DoNDMainGump : Gump
    	{
        	public DoNDMainGump( Mobile m, Item i ) : base( 0, -25 )
        	{
			PlayerMobile pm = m as PlayerMobile;

			if ( pm == null )
				return;

			if ( i == null )
				return;

			DoNDGameDeed gd = i as DoNDGameDeed;
//Main Gump Props
            		Closable = false;
			Disposable = false;
			Dragable = true;
//Page #
			AddPage(0);
//Title Deal or No Deal
			AddImage(328, 431, 100);
			AddLabel(342, 450, 1160, @"DEAL");
			AddLabel(381, 450, 1160, @"or");
			AddLabel(401, 450, 1160, @"NO DEAL");
//Backgrounds
			AddBackground(0, 320, 119, 280, 9500);
			AddBackground(681, 320, 119, 280, 9500);
			AddBackground(118, 469, 564, 131, 9500);
			AddBackground(129, 486, 100, 100, 9300);
			AddBackground(234, 486, 244, 98, 9350);
			AddBackground(484, 484, 185, 99, 9400);
//Prize Backgrounds
			AddImage(4, 436, 2062);
			AddImage(4, 456, 2062);
			AddImage(4, 476, 2062);
			AddImage(4, 496, 2062);
			AddImage(4, 516, 2062);
			AddImage(4, 536, 2062);
			AddImage(4, 556, 2062);
			AddImage(4, 575, 2062);
			AddImage(4, 356, 2062);
			AddImage(4, 336, 2062);
			AddImage(4, 376, 2062);
			AddImage(4, 396, 2062);
			AddImage(4, 416, 2062);
			AddImage(685, 436, 2062);
			AddImage(685, 456, 2062);
			AddImage(685, 476, 2062);
			AddImage(685, 496, 2062);
			AddImage(685, 516, 2062);
			AddImage(685, 536, 2062);
			AddImage(685, 556, 2062);
			AddImage(685, 575, 2062);
			AddImage(685, 356, 2062);
			AddImage(685, 336, 2062);
			AddImage(685, 376, 2062);
			AddImage(685, 396, 2062);
			AddImage(685, 416, 2062);
//Left Side Prizes (1160 true / 1151 false)
			if ( gd.Zero == true )
				AddLabel(43, 335, 1160, @"Prize");
			if ( gd.Zero == false )
				AddLabel(43, 335, 1151, @"Prize");
			if ( gd.One == true )
				AddLabel(50, 356, 1160, @"$1");
			if ( gd.One == false )
				AddLabel(50, 356, 1151, @"$1");
			if ( gd.Five == true )
				AddLabel(49, 375, 1160, @"$5");
			if ( gd.Five == false )
				AddLabel(49, 375, 1151, @"$5");
			if ( gd.Ten == true )
				AddLabel(45, 394, 1160, @"$10");
			if ( gd.Ten == false )
				AddLabel(45, 394, 1151, @"$10");
			if ( gd.TweFive == true )
				AddLabel(43, 415, 1160, @"$25");
			if ( gd.TweFive == false )
				AddLabel(43, 415, 1151, @"$25");
			if ( gd.Fifty == true )
				AddLabel(43, 435, 1160, @"$50");
			if ( gd.Fifty == false )
				AddLabel(43, 435, 1151, @"$50");
			if ( gd.SevFive == true )
				AddLabel(43, 455, 1160, @"$75");
			if ( gd.SevFive == false )
				AddLabel(43, 455, 1151, @"$75");
			if ( gd.OneH == true )
				AddLabel(41, 474, 1160, @"$100");
			if ( gd.OneH == false )
				AddLabel(41, 474, 1151, @"$100");
			if ( gd.TwoH == true )
				AddLabel(38, 494, 1160, @"$200");
			if ( gd.TwoH == false )
				AddLabel(38, 494, 1151, @"$200");
			if ( gd.ThreeH == true )
				AddLabel(38, 514, 1160, @"$300");
			if ( gd.ThreeH == false )
				AddLabel(38, 514, 1151, @"$300");
			if ( gd.FourH == true )
				AddLabel(38, 535, 1160, @"$400");
			if ( gd.FourH == false )
				AddLabel(38, 535, 1151, @"$400");
			if ( gd.FiveH == true )
				AddLabel(38, 555, 1160, @"$500");
			if ( gd.FiveH == false )
				AddLabel(38, 555, 1151, @"$500");
			if ( gd.SevFiveH == true )
				AddLabel(38, 574, 1160, @"$750");
			if ( gd.SevFiveH == false )
				AddLabel(38, 574, 1151, @"$750");
//Right Side Prizes (1160 true / 1151 false)
			if ( gd.OneTH == true )
				AddLabel(714, 335, 1160, @"$1,000");
			if ( gd.OneTH == false )
				AddLabel(714, 335, 1151, @"$1,000");
			if ( gd.FiveTH == true )
				AddLabel(713, 354, 1160, @"$5,000");
			if ( gd.FiveTH == false )
				AddLabel(713, 354, 1151, @"$5,000");
			if ( gd.TenTH == true )
				AddLabel(711, 375, 1160, @"$10,000");
			if ( gd.TenTH == false )
				AddLabel(711, 375, 1151, @"$10,000");
			if ( gd.TweFiveTH == true )
				AddLabel(710, 395, 1160, @"$25,000");
			if ( gd.TweFiveTH == false )
				AddLabel(710, 395, 1151, @"$25,000");
			if ( gd.FiftyTH == true )
				AddLabel(710, 414, 1160, @"$50,000");
			if ( gd.FiftyTH == false )
				AddLabel(710, 414, 1151, @"$50,000");
			if ( gd.SevFiveTH == true )
				AddLabel(710, 435, 1160, @"$75,000");
			if ( gd.SevFiveTH == false )
				AddLabel(710, 435, 1151, @"$75,000");
			if ( gd.OneHT == true )
				AddLabel(708, 455, 1160, @"$100,000");
			if ( gd.OneHT == false )
				AddLabel(708, 455, 1151, @"$100,000");
			if ( gd.TwoHT == true )
				AddLabel(705, 475, 1160, @"$200,000");
			if ( gd.TwoHT == false )
				AddLabel(705, 475, 1151, @"$200,000");
			if ( gd.ThreeHT == true )
				AddLabel(705, 495, 1160, @"$300,000");
			if ( gd.ThreeHT == false )
				AddLabel(705, 495, 1151, @"$300,000");
			if ( gd.FourHT == true )
				AddLabel(706, 515, 1160, @"$400,000");
			if ( gd.FourHT == false )
				AddLabel(706, 515, 1151, @"$400,000");
			if ( gd.FiveHT == true )
				AddLabel(706, 535, 1160, @"$500,000");
			if ( gd.FiveHT == false )
				AddLabel(706, 535, 1151, @"$500,000");
			if ( gd.SevFiveHT == true )
				AddLabel(706, 555, 1160, @"$750,000");
			if ( gd.SevFiveHT == false )
				AddLabel(706, 555, 1151, @"$750,000");
			if ( gd.OneMil == true )
				AddLabel(701, 574, 1160, @"$1,000,000");
			if ( gd.OneMil == false )
				AddLabel(701, 574, 1151, @"$1,000,000");
//Case's to Pick (in order from 1 - 6)
			AddLabel(134, 491, 1160, @"Case's to Pick");
			if ( gd.SubStageOne == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
				AddImage(138, 557, 2228);
				AddImage(168, 557, 2229);
				AddImage(198, 557, 2230);
			}
			if ( gd.SubStageTwo == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
				AddImage(138, 557, 2228);
				AddImage(168, 557, 2229);
			}
			if ( gd.SubStageThree == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
				AddImage(138, 557, 2228);
			}
			if ( gd.SubStageFour == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
			}
			if ( gd.SubStageFive == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
			}
			if ( gd.SubStageSix == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne2 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
				AddImage(138, 557, 2228);
				AddImage(168, 557, 2229);
			}
			if ( gd.SubStageTwo2 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
				AddImage(138, 557, 2228);
			}
			if ( gd.SubStageThree2 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
			}
			if ( gd.SubStageFour2 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
			}
			if ( gd.SubStageFive2 == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne3 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
				AddImage(138, 557, 2228);
			}
			if ( gd.SubStageTwo3 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
			}
			if ( gd.SubStageThree3 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
			}
			if ( gd.SubStageFour3 == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne4 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
				AddImage(198, 525, 2227);
			}
			if ( gd.SubStageTwo4 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
			}
			if ( gd.SubStageThree4 == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne5 == true )
			{
				AddImage(139, 525, 2225); 
				AddImage(169, 525, 2226);
			}
			if ( gd.SubStageTwo5 == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne6 == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne7 == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne8 == true )
			{
				AddImage(139, 525, 2225); 
			}
			if ( gd.SubStageOne9 == true )
			{
				AddImage(139, 525, 2225); 
			}
//Previous Bank Offers
			AddLabel(506, 489, 1160, @"Previous Bank Offer's");
			AddLabel(492, 507, 1160, @"1 : " + gd.DA1);
			AddLabel(489, 525, 1160, @"2 : " + gd.DA2);
			AddLabel(489, 543, 1160, @"3 : " + gd.DA3);
			AddLabel(489, 561, 1160, @"4 : " + gd.DA4);
			AddLabel(575, 507, 1160, @"5 : " + gd.DA5);
			AddLabel(575, 525, 1160, @"6 : " + gd.DA6);
			AddLabel(575, 543, 1160, @"7 : " + gd.DA7);
			AddLabel(575, 561, 1160, @"8 : " + gd.DA8);
//Game Information Menu
			AddLabel(281, 490, 1160, @"Game Information Menu");
			if ( gd.PA == 0 )
				AddHtml( 243, 514, 223, 60, @"Please pick your case!        type Case# or Help", (bool)true, (bool)true);
			if ( gd.DHelp == true )
				AddHtml( 243, 514, 223, 60, @"This area will always have next game step information when playing deal or no deal, the game is speech driven so you'll have to type in all of your choices. The choices that are avalible jurying the game are : Deal : NoDeal : Trade : NoTrade : Case# : EndGame : Help : The explaination of each command are listed here : Deal, say this to accept Banker's Deal when you get Banker's offer. NoDeal, say this to reject the Banker's offer. Trade, say this to trade case at the end of game. NoTrade, say this to keep your case at the end of game. Case#, say Case and replace the # with the case number you want to pick. EndGame, say this to end the game at anytime jurying a game. Help, say this to get this help section. HearOffer, say this to hear the bankers offer!", (bool)true, (bool)true);
			if ( gd.DHelp != true )
			{
				if ( gd.StageOne == true )
				{
					if ( gd.SubStageOne == true )
						AddHtml( 243, 514, 223, 60, @"Pick Six Case's!             type Case#", (bool)true, (bool)true);
					if ( gd.SubStageTwo == true )
						AddHtml( 243, 514, 223, 60, @"Pick Five Case's!            type Case#", (bool)true, (bool)true);
					if ( gd.SubStageThree == true )
						AddHtml( 243, 514, 223, 60, @"Pick Four case's!            type Case#", (bool)true, (bool)true);
					if ( gd.SubStageFour == true )
						AddHtml( 243, 514, 223, 60, @"Pick Three Case's!           type Case#", (bool)true, (bool)true);
					if ( gd.SubStageFive == true )
						AddHtml( 243, 514, 223, 60, @"Pick Two Case's!             type Case#", (bool)true, (bool)true);
					if ( gd.SubStageSix == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageTwo == true )
				{
					if ( gd.SubStageOne2 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Five Case's!            type Case#", (bool)true, (bool)true);
					if ( gd.SubStageTwo2 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Four case's!            type Case#", (bool)true, (bool)true);
					if ( gd.SubStageThree2 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Three Case's!           type Case#", (bool)true, (bool)true);
					if ( gd.SubStageFour2 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Two Case's!             type Case#", (bool)true, (bool)true);
					if ( gd.SubStageFive2 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageThree == true )
				{
					if ( gd.SubStageOne3 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Four case's!            type Case#", (bool)true, (bool)true);
					if ( gd.SubStageTwo3 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Three Case's!           type Case#", (bool)true, (bool)true);
					if ( gd.SubStageThree3 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Two Case's!             type Case#", (bool)true, (bool)true);
					if ( gd.SubStageFour3 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageFour == true )
				{
					if ( gd.SubStageOne4 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Three Case's!           type Case#", (bool)true, (bool)true);
					if ( gd.SubStageTwo4 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Two Case's!             type Case#", (bool)true, (bool)true);
					if ( gd.SubStageThree4 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageFive == true )
				{
					if ( gd.SubStageOne5 == true )
						AddHtml( 243, 514, 223, 60, @"Pick Two Case's!             type Case#", (bool)true, (bool)true);
					if ( gd.SubStageTwo5 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageSix == true )
				{
					if ( gd.SubStageOne6 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageSeven == true )
				{
					if ( gd.SubStageOne7 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageEight == true )
				{
					if ( gd.SubStageOne8 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageNine == true )
				{
					if ( gd.SubStageOne9 == true )
						AddHtml( 243, 514, 223, 60, @"Pick One Case!               type Case#", (bool)true, (bool)true);
					if ( gd.Banker == true && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Take Banker's offer?         type Deal or NoDeal", (bool)true, (bool)true);
					if ( gd.Banker == false && gd.OfferSel == true )
						AddHtml( 243, 514, 223, 60, @"Check out Banker's Offer!    type HearOffer", (bool)true, (bool)true);
				}
				if ( gd.StageTen == true )
				{
					if ( gd.Trade == false )
					{
						if ( gd.NoTrade == true )
							AddHtml( 243, 514, 223, 60, @"Checking Last Case", (bool)true, (bool)true);
						if ( gd.NoTrade == false )
							AddHtml( 243, 514, 223, 60, @"Trade Case?                    type Trade or NoTrade", (bool)true, (bool)true);
					}
					if ( gd.Trade == true )
						AddHtml( 243, 514, 223, 60, @"Trading Case's", (bool)true, (bool)true);
				}			
			}
//Awaiting Answer Gump
			if ( gd.OfferSel == true )
			{
				AddBackground(139, 512, 79, 69, 9200);
				AddImage(150, 516, 223);
			}
			if ( gd.StageTen == true )
			{
				AddBackground(139, 512, 79, 69, 9200);
				AddImage(150, 516, 223);
			}
//Case Ammount Gump
			if ( gd.CloseCase == false && gd.Banker == false )
			{
				if ( gd.PC != 0 && gd.PO > 0 )
				{
					Timer i_timer = new CloseCaseTimer( pm, gd ); 
    						i_timer.Start();

					AddImage(297, 157, 75);

					if ( gd.PC == 1 )
					{
						AddLabel(359, 234, 1160, @"$1,000,000");
					}
					if ( gd.PC == 2 )
					{
						AddLabel(362, 234, 1160, @"$750,000");
					}
					if ( gd.PC == 3 )
					{
						AddLabel(362, 234, 1160, @"$500,000");
					}
					if ( gd.PC == 4 )
					{
						AddLabel(362, 234, 1160, @"$400,000");
					}
					if ( gd.PC == 5 )
					{
						AddLabel(362, 234, 1160, @"$300,000");
					}
					if ( gd.PC == 6 )
					{
						AddLabel(362, 234, 1160, @"$200,000");
					}
					if ( gd.PC == 7 )
					{
						AddLabel(362, 234, 1160, @"$100,000");
					}
					if ( gd.PC == 8 )
					{
						AddLabel(365, 234, 1160, @"$75,000");
					}
					if ( gd.PC == 9 )
					{
						AddLabel(365, 234, 1160, @"$50,000");
					}
					if ( gd.PC == 10 )
					{
						AddLabel(365, 234, 1160, @"$25,000");
					}
					if ( gd.PC == 11 )
					{
						AddLabel(365, 234, 1160, @"$10,000");
					}
					if ( gd.PC == 12 )
					{
						AddLabel(368, 234, 1160, @"$5,000");
					}
					if ( gd.PC == 13 )
					{
						AddLabel(368, 234, 1160, @"$1,000");
					}
					if ( gd.PC == 14 )
					{
						AddLabel(371, 234, 1160, @"$750");
					}
					if ( gd.PC == 15 )
					{
						AddLabel(371, 234, 1160, @"$500");
					}
					if ( gd.PC == 16 )
					{
						AddLabel(371, 234, 1160, @"$400");
					}
					if ( gd.PC == 17 )
					{
						AddLabel(371, 234, 1160, @"$300");
					}
					if ( gd.PC == 18 )
					{
						AddLabel(371, 234, 1160, @"$200");
					}
					if ( gd.PC == 19 )
					{
						AddLabel(371, 234, 1160, @"$100");
					}
					if ( gd.PC == 20 )
					{
						AddLabel(374, 234, 1160, @"$75");
					}
					if ( gd.PC == 21 )
					{
						AddLabel(374, 234, 1160, @"$50");
					}
					if ( gd.PC == 22 )
					{
						AddLabel(374, 234, 1160, @"$25");
					}
					if ( gd.PC == 23 )
					{
						AddLabel(374, 234, 1160, @"$10");
					}
					if ( gd.PC == 24 )
					{
						AddLabel(377, 234, 1160, @"$5");
					}
					if ( gd.PC == 25 )
					{
						AddLabel(377, 234, 1160, @"$1");
					}
					if ( gd.PC == 26 )
					{
						AddLabel(368, 234, 1160, @"Prize");
					}
				}
			}
//Bank Offer Gump
			if ( gd.OfferSel == true && gd.Banker == true )
			{
				if ( gd.StageOne == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA1);
				}
				if ( gd.StageTwo == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA2);
				}
				if ( gd.StageThree == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA3);
				}
				if ( gd.StageFour == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA4);
				}
				if ( gd.StageFive == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA5);
				}
				if ( gd.StageSix == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA6);
				}
				if ( gd.StageSeven == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA7);
				}
				if ( gd.StageEight == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA8);
				}
				if ( gd.StageNine == true )
				{
					AddImage(298, 156, 67);
					AddLabel(361, 214, 36, @"Banks Offer");
					AddLabel(364, 233, 1160, @"$" + gd.DA9);
				}
			}
//Bankers Calling Gump
			if ( gd.OfferSel == true && gd.StageTen != true  )
			{
				AddLabel(10, 275, 36, @"Banker's Calling");
				AddImage(12, 250, 40);
				AddImage(12, 260, 40);
				AddImage(12, 270, 40);
				AddImage(12, 293, 40);
				AddImage(12, 303, 40);
				AddImage(12, 313, 40);
				AddLabel(690, 275, 36, @"Banker's Calling");
				AddImage(692, 250, 40);
				AddImage(692, 260, 40);
				AddImage(692, 270, 40);
				AddImage(692, 293, 40);
				AddImage(692, 303, 40);
				AddImage(692, 313, 40);
			}
//Text Command Entry Area
			AddBackground(1, 600, 797, 27, 9200);
			AddLabel(200, 604, 51, @"<Type in Game Commands Here : Case#, Deal, NoDeal, HearOffer, Trade, NoTrade, EndGame, Help>");
//Credits
			AddLabel(349, 581, 1152, @"By : Tiamat13");
        	}
    	}
}