using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{ 
   public class KyleStartGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("KyleStartGump", AccessLevel.GameMaster, new CommandEventHandler(KyleStartGump_OnCommand)); 
      } 

      private static void KyleStartGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new KyleStartGump( e.Mobile ) ); 
      } 

      public KyleStartGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "Kyle's Teachings" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=YELLOW>I see you are prepared to begin your combat training.  So let us begin.<BR><BR>Please know, that you will be tested against some very tough creatures.  However, should you prevail, you shall be rewarded with some items to help you begin your journey through this life in Britannia.<BR><BR>You will be tested against some various creatures, and they will only increase in difficulty with each new task.<BR><BR>To begin, take this Level 1 Letter of Gargoyle Recommendation to Jaigar and she will summon your first creature, a Diseased Rat.  Bring me the Diseased Rat Meat and you shall be rewarded, as well as given a Level 2 Letter of Gargoyle Recommendation to further your training.<BR><BR>To find Jaigar, step onto the pentagram in this next room.  Then follow the path through the hordes of monsters to the very end, where you will find Jaigar waiting for you.  Each time you give her a Letter of Gargoyle Recommendation, she will summon a creature to test you.  Defeat these creatures, and return the special items to me for your rewards.<BR><BR>I wish you well in your quest.<BR><BR>Now go young adventurer, and bring me back the Diseased Rat Meat!" +
						     "</BODY>", false, true);
			
//			<BASEFONT COLOR=#7B6D20>			

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
               from.SendMessage( "Fight with all your might!" );
               break; 
            } 

         }
      }
   }
}