using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Gumps
{
    	public class DebugGump : Gump
   	{
        	public DebugGump( Mobile m ) : base( 0, 0 )
        	{
			PlayerMobile pm = m as PlayerMobile;

			if (pm == null || pm.Backpack == null)
    				return;

			Item di = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( di == null )
				return;

			DoNDGameDeed gd = di as DoNDGameDeed;

			if ( gd == null )
				return;

           		Closable = true;
			Disposable = true;
			Dragable = true;

			AddPage(0);
			AddBackground(5, 2, 280, 593, 9270);
			AddBackground(17, 35, 256, 547, 9200);
			AddBackground(221, 129, 100, 372, 9200);

			AddLabel(48, 15, 1160, @"Deal or No Deal DeBug Bool Menu");

			AddLabel(20, 40, 57, @"Deal On : " + gd.DealOn);
			AddLabel(20, 60, 57, @"Game Start : " + gd.GameStart);
			AddLabel(20, 80, 57, @"Game Over : " + gd.GameOver);
			AddLabel(20, 100, 57, @"Case Select : " + gd.CaseSel);
			AddLabel(20, 120, 57, @"Offer Select : " + gd.OfferSel);
			AddLabel(20, 140, 57, @"Deal : " + gd.Deal);
			AddLabel(20, 160, 57, @"No Deal : " + gd.NoDeal);
			AddLabel(20, 180, 57, @"Trade : " + gd.Trade);
			AddLabel(20, 200, 57, @"No Trade : " + gd.NoTrade);
			AddLabel(20, 220, 57, @"Help : " + gd.DHelp);
			AddLabel(20, 240, 57, @"Close Case : " + gd.CloseCase);
			AddLabel(20, 260, 57, @"Commercial : " + gd.Commercial);
			AddLabel(20, 280, 57, @"Deal 1 : " + gd.DA1);
			AddLabel(20, 300, 57, @"Deal 2 : " + gd.DA2);
			AddLabel(20, 320, 57, @"Deal 3 : " + gd.DA3);
			AddLabel(20, 340, 57, @"Deal 4 : " + gd.DA4);
			AddLabel(20, 360, 57, @"Deal 5 : " + gd.DA5);
			AddLabel(20, 380, 57, @"Deal 6 : " + gd.DA6);
			AddLabel(20, 400, 57, @"Deal 7 : " + gd.DA7);
			AddLabel(20, 420, 57, @"Deal 8 : " + gd.DA8);
			AddLabel(20, 440, 57, @"Deal 9 : " + gd.DA9);
			AddLabel(20, 460, 57, @"PO : " + gd.PO);
			AddLabel(20, 480, 57, @"GO : " + gd.GO);
			AddLabel(20, 500, 57, @"PA : " + gd.PA);
			AddLabel(20, 520, 57, @"PC : " + gd.PC);
			AddLabel(20, 540, 57, @"TL : " + gd.TL);
			AddLabel(20, 560, 57, @"Replay : " + gd.DReplay);

			AddLabel(240, 137, 1160, @"Pick Order");

			if ( gd.StageOne == true )
				AddLabel(235, 157, 57, @"Stage One");
			if ( gd.StageTwo == true )
				AddLabel(235, 177, 57, @"Stage Two");
			if ( gd.StageThree == true )
				AddLabel(235, 197, 57, @"Stage Three");
			if ( gd.StageFour == true )
				AddLabel(235, 117, 57, @"Stage Four");
			if ( gd.StageFive == true )
				AddLabel(235, 237, 57, @"Stage Five");
			if ( gd.StageSix == true )
				AddLabel(235, 257, 57, @"Stage Six");
			if ( gd.StageSeven == true )
				AddLabel(235, 277, 57, @"Stage Seven");
			if ( gd.StageEight == true )
				AddLabel(235, 297, 57, @"Stage Eight");
			if ( gd.StageNine == true )
				AddLabel(235, 317, 57, @"Stage Nine");
			if ( gd.StageTen == true )
				AddLabel(235, 337, 57, @"Stage Ten");

			if ( gd.SubStageOne == true )
				AddLabel(235, 357, 57, @"Sub One");
			if ( gd.SubStageTwo == true )
				AddLabel(235, 377, 57, @"Sub Two");
			if ( gd.SubStageThree == true )
				AddLabel(235, 397, 57, @"Sub Three");
			if ( gd.SubStageFour == true )
				AddLabel(235, 417, 57, @"Sub Four");
			if ( gd.SubStageFive == true )
				AddLabel(235, 437, 57, @"Sub Five");
			if ( gd.SubStageSix == true )
				AddLabel(235, 457, 57, @"Sub Six");

			if ( gd.SubStageOne2 == true )
				AddLabel(235, 357, 57, @"Sub One");
			if ( gd.SubStageTwo2 == true )
				AddLabel(235, 377, 57, @"Sub Two");
			if ( gd.SubStageThree2 == true )
				AddLabel(235, 397, 57, @"Sub Three");
			if ( gd.SubStageFour2 == true )
				AddLabel(235, 417, 57, @"Sub Four");
			if ( gd.SubStageFive2 == true )
				AddLabel(235, 437, 57, @"Sub Five");

			if ( gd.SubStageOne3 == true )
				AddLabel(235, 357, 57, @"Sub One");
			if ( gd.SubStageTwo3 == true )
				AddLabel(235, 377, 57, @"Sub Two");
			if ( gd.SubStageThree3 == true )
				AddLabel(235, 397, 57, @"Sub Three");
			if ( gd.SubStageFour3 == true )
				AddLabel(235, 417, 57, @"Sub Four");

			if ( gd.SubStageOne4 == true )
				AddLabel(235, 357, 57, @"Sub One");
			if ( gd.SubStageTwo4 == true )
				AddLabel(235, 377, 57, @"Sub Two");
			if ( gd.SubStageThree4 == true )
				AddLabel(235, 397, 57, @"Sub Three");

			if ( gd.SubStageOne5 == true )
				AddLabel(235, 357, 57, @"Sub One");
			if ( gd.SubStageTwo5 == true )
				AddLabel(235, 377, 57, @"Sub Two");

			if ( gd.SubStageOne6 == true )
				AddLabel(235, 357, 57, @"Sub One");

			if ( gd.SubStageOne7 == true )
				AddLabel(235, 357, 57, @"Sub One");

			if ( gd.SubStageOne8 == true )
				AddLabel(235, 357, 57, @"Sub One");

			if ( gd.SubStageOne9 == true )
				AddLabel(235, 357, 57, @"Sub One");

			if ( gd.Banker == true )
				AddLabel(235, 477, 33, @"Banker");	
        	}
    	}
}