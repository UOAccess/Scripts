using System;
using Server;
using Server.Gumps;
using Server.Mobiles;

namespace Server.Items
{
	public class CloseGameTimer : Timer
    	{
		private Item item;
		private Mobile pmobile;
		private Mobile bmobile;

		public CloseGameTimer( Mobile m, Mobile bm, Item i ) : base( TimeSpan.FromSeconds( 3 ) )
        	{
			pmobile = m;
			bmobile = bm;
			item = i;
		}
		protected override void OnTick()
        	{
			PlayerMobile pm = pmobile as PlayerMobile;

			if ( pm == null || pm.Backpack == null )
			{
                		this.Stop();
				return;
			}

			Howey bc = bmobile as Howey;

			if ( bc == null )
			{
                		this.Stop();
				return;
			}

			DoNDGameDeed gd = item as DoNDGameDeed;

			if ( gd == null )
			{
                		this.Stop();
                		return;
			}

			if( gd.Deleted )
			{
                		this.Stop();
                		return;
			}
			
			if ( gd.GameOver == false && gd.NoTrade == true )
			{
				bc.Say( pm.Name + ", Your case had....!");
				GameSystem.PrizeCheck( pm, bc );

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Close Game Timer, NoTrade OK" );
				this.Stop();
			}

			bc.DealOn = false;
			bc.AL = 0;
			bc.cnt = 0;
			pm.Frozen = false;
			
			bc.CD1 = false;
			bc.CD2 = false;
			bc.CD3 = false;
			bc.CD4 = false;
			bc.CD5 = false;
			bc.CD6 = false;
			bc.CD7 = false;
			bc.CD8 = false;
			bc.CD9 = false;
			bc.CD10 = false;
			bc.CD11 = false;
			bc.CD12 = false;
			bc.CD13 = false;
			bc.CD14 = false;
			bc.CD15 = false;
			bc.CD16 = false;
			bc.CD17 = false;
			bc.CD18 = false;
			bc.CD19 = false;
			bc.CD20 = false;
			bc.CD21 = false;
			bc.CD22 = false;
			bc.CD23 = false;
			bc.CD24 = false;
			bc.CD25 = false;
			bc.CD26 = false;

			if (pm.HasGump( typeof( DoNDMainGump )))
				pm.CloseGump( typeof( DoNDMainGump ) );

			bc.Say( pm.Name + ", Thanks for playing Deal or No Deal!");
			bc.Hidden = true;

			bc.FixedParticles( 0x37CC, 1, 40, 97, 3, 9917, EffectLayer.Waist );
           		bc.FixedParticles( 0x374A, 1, 15, 9502, 97, 3, (EffectLayer)255 );

			Console.WriteLine( "A Player has Ended Deal or No Deal : Game Over" );

			Item ri = pm.Backpack.FindItemByType(typeof(DoNDReplayDeed) );

			if ( ri != null )
			{
				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Close Game Timer, Found Replay Deed OK" );
				this.Stop();
				return;
			}
			
			if ( pm.AccessLevel < AccessLevel.GameMaster )
				pm.AddToBackpack( new DoNDReplayDeed( pm, gd ) );

			gd.Delete();

			if ( pm.AccessLevel < AccessLevel.GameMaster )
			{
				pm.SendMessage( 33, pm.Name + ", You'll need to wait in order to play again!");

				Timer p_timer = new PlayerReplayTimer( pm ); 
    					p_timer.Start();
			}
			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Close Game Timer, End Game OK" );
			this.Stop();
        	}
    	}
}