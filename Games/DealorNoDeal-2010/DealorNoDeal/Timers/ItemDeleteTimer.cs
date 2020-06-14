using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class ItemDeleteTimer : Timer
    	{
		private Item item;
		private Mobile pmobile;
		private Mobile bmobile;

		public ItemDeleteTimer( Mobile m, Mobile bm, Item i ) : base( TimeSpan.FromSeconds( 1 ) )
        	{
			pmobile = m;
			bmobile = bm;
			item = i;
		}
		protected override void OnTick()
        	{
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

			PlayerMobile pm = pmobile as PlayerMobile;

			if ( pm == null )
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

			if ( gd.GameOver == false )
			{
				this.Start();
				return;
			}

			GameSystem.EndDDGame( pm, bc );

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Item Delete Timer OK" );
			this.Stop();
        	}
    	}
}