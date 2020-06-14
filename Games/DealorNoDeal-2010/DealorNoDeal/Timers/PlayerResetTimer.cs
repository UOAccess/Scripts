using System;
using Server;
using Server.Gumps;
using Server.Items;

namespace Server.Mobiles
{
	public class PlayerResetTimer : Timer
    	{
		private Mobile pmobile;
		private Mobile bmobile;

		public PlayerResetTimer( Mobile m, Mobile bm ) : base( TimeSpan.FromMinutes( 1 ) )
        	{
			pmobile = m;
			bmobile = bm;
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

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			if ( check == null )
			{
                		this.Stop();
				return;
			}

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
			{
                		this.Stop();
				return;
			}

			gd.TL +=1;

			if ( gd.TL < 5 )
			{
				this.Start();
				return;
			}

			if ( gd.TL == 5 )
			{
				pm.SendMessage( 33,pm.Name + ", You only have limited time to play");
				gd.TL = 20 - gd.TL;
				pm.SendMessage( 33,gd.TL + " Minutes Left to Play!");
				gd.TL = 20 - gd.TL;
				this.Start();
				return;
			}

			if ( gd.TL != 5 && gd.TL < 10 )
			{
				this.Start();
				return;
			}

			if ( gd.TL == 10 )
			{
				pm.SendMessage( 33,pm.Name + ", You only have limited time to play");
				gd.TL = 20 - gd.TL;
				pm.SendMessage( 33,gd.TL + " Minutes Left to Play!");
				gd.TL = 20 - gd.TL;
				this.Start();
				return;
			}

			if ( gd.TL != 10 && gd.TL < 15 )
			{
				this.Start();
				return;
			}

			if ( gd.TL < 20 )
			{
				pm.SendMessage( 33,pm.Name + ", You only have limited time to play");
				gd.TL = 20 - gd.TL;
				pm.SendMessage( 33,gd.TL + " Minutes Left to Play!");
				gd.TL = 20 - gd.TL;
				this.Start();
				return;
			}
			pm.SendMessage( 33,pm.Name + ", Times up, Game Over!");

			if( gd != null )
			{
				if (pm.HasGump( typeof( DoNDMainGump )))
					pm.CloseGump( typeof( DoNDMainGump ) );

				gd.GameOver = true;
				GameSystem.EndDDGame( pm, bc );

				if ( bc.DeBugger == true )
					Console.WriteLine( "DeBug : System, Player Reset Timer OK" );
				gd.TL = 0;
                		this.Stop();
			}
        	}
    	}
}