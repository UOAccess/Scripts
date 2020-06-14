using System; using Server; using Server.Commands;using Server.Gumps; using Server.Network;using Server.Items;using Server.Mobiles;namespace Server.Gumps
{ public class BerserkersQuestGump : Gump { 
public static void Initialize() { 
CommandSystem.Register( "BerserkersQuestGump", AccessLevel.GameMaster, new CommandEventHandler( BerserkersQuestGump_OnCommand ) ); 
}
private static void BerserkersQuestGump_OnCommand( CommandEventArgs e ) 
{
e.Mobile.SendGump( new BerserkersQuestGump( e.Mobile ) ); } 
public BerserkersQuestGump( Mobile owner ) : base( 50,50 ) 
{
//----------------------------------------------------------------------------------------------------
AddPage( 0 );AddImageTiled(  54, 33, 369, 400, 2624 );AddAlphaRegion( 54, 33, 369, 400 );AddImageTiled( 416, 39, 44, 389, 203 );
//--------------------------------------Window size bar--------------------------------------------
AddImage( 97, 49, 9005 );AddImageTiled( 58, 39, 29, 390, 10460 );AddImageTiled( 412, 37, 31, 389, 10460 );
AddLabel( 140, 60, 0x34, "Berserker Rampage" );
//----------------------/----------------------------------------------/
AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>Ike Looks At You With Fire In His Eyes<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>So you wanna know why Im so angery?<BR>" +
"<BASEFONT COLOR=YELLOW>If Berserkers killed your<BR>" +
"<BASEFONT COLOR=YELLOW>wife and daughter infront of you and <BR>" +
"<BASEFONT COLOR=YELLOW>you couldnt do anything for them. It<BR>" +
"<BASEFONT COLOR=YELLOW>leaves a horrible taste in your mouth<BR>" +
"<BASEFONT COLOR=YELLOW>and nightmares in your daily life. <BR>" +
"<BASEFONT COLOR=YELLOW>Kill Ten Of Them For Me!!!<BR>" +
"<BASEFONT COLOR=YELLOW>If you would like to help me out go <BR>" +
"<BASEFONT COLOR=YELLOW>show those berserkers east of Hythloth Dungeon <BR>" +
"<BASEFONT COLOR=YELLOW>the power of vengeance. They camp in<BR>" +
"<BASEFONT COLOR=YELLOW>the small area east of Hythloth. to<BR>" +
"<BASEFONT COLOR=YELLOW>Bring me back ten of their skulls.<BR>" +
"</BODY>", false, true);
//----------------------/----------------------------------------------/
AddImage( 430, 9, 10441);AddImageTiled( 40, 38, 17, 391, 9263 );AddImage( 6, 25, 10421 );AddImage( 34, 12, 10420 );AddImageTiled( 94, 25, 342, 15, 10304 );AddImageTiled( 40, 427, 415, 16, 10304 );AddImage( -10, 314, 10402 );AddImage( 56, 150, 10411 );AddImage( 155, 120, 2103 );AddImage( 136, 84, 96 );AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 ); }
//----------------------/----------------------------------------------/
public override void OnResponse( NetState state, RelayInfo info ){ Mobile from = state.Mobile; switch ( info.ButtonID ) { case 0:{ break; }}}}}
