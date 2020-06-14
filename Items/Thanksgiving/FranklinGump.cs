using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class FranklinGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("FranklinGump", AccessLevel.GameMaster, new CommandEventHandler(FranklinGump_OnCommand)); 
      } 

      private static void FranklinGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new FranklinGump( e.Mobile ) ); 
      } 

      public FranklinGump( Mobile owner ) : base( 50,50 ) 
      { 
//----------------------------------------------------------------------------------------------------

				AddPage( 0 );
			AddImageTiled(  54, 33, 369, 400, 2624 );
			AddAlphaRegion( 54, 33, 369, 400 );

			AddImageTiled( 416, 39, 44, 389, 203 );
//--------------------------------------Window size bar--------------------------------------------
			
			AddImage( 97, 49, 9005 );
			AddImageTiled( 58, 39, 29, 390, 10460 );
			AddImageTiled( 412, 37, 31, 389, 10460 );
			AddLabel( 140, 60, 0x34, "The Dreaded Turkey Dragon!" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=Yellow><I>You tap Franklin's shoulder</I><br><br>" +
"<BASEFONT Color=Yellow> Oh! You scared be other.... Worlder.<br>" + 
"<BASEFONT COLOR=Yellow> Ah yes! That is right, I forget myself sometimes, I am Franklin, a settler here from the old land of Englandia.<br>" +
"<BASEFONT COLOR=Yellow> With our world almost entirely destroyed, some of us decided to move here and settle down. Anyway, I do have a problem you see...<br>" +
"<BASEFONT COLOR=Yellow> Skara Brae has a little bit of an infestation. Every year at the same time in Englandia we have these Dragons, they're a bit weaker than our regular dragons so over time they've earned the name 'Turkey Dragons.'<br>" +
"<BASEFONT COLOR=Yellow> Yes, it is a pretty funny name. Now. The problem you see, is that the knights and warriors of your realm are weaker than our own, so we need a little assistance in ridding this land of these <I>Turkey Dragons</I>.<br>" +
"<BASEFONT COLOR=Yellow> They seem to sprout from our Englandian Seeds, so you'll find the infestation is contained in Skara Brae's farm land.<br>" + 
"<BASEFONT COLOR=Yellow> Thank you very much for your assistance, should you choose to help.<br>" +
"</BODY>", false, true);
			
			AddImage( 430, 9, 10441);
			AddImageTiled( 40, 38, 17, 391, 9263 );
			AddImage( 6, 25, 10421 );
			AddImage( 34, 12, 10420 );
			AddImageTiled( 94, 25, 342, 15, 10304 );
			AddImageTiled( 40, 427, 415, 16, 10304 );
			AddImage( -10, 314, 10402 );
			AddImage( 56, 150, 10411 );
			AddImage( 155, 120, 2103 );
			AddImage( 136, 84, 96 );

			AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 ); 

//--------------------------------------------------------------------------------------------------------------
      } 

      public override void OnResponse( NetState state, RelayInfo info ) //Function for GumpButtonType.Reply Buttons 
      { 
         Mobile from = state.Mobile; 

         switch ( info.ButtonID ) 
         { 
            case 0: //Case uses the ActionIDs defenied above. Case 0 defenies the actions for the button with the action id 0 
            { 
               //Cancel 
               from.SendMessage( "I promise to no longer use the Englandian Seeds!" );
               break; 
            } 

         }
      }
   }
}