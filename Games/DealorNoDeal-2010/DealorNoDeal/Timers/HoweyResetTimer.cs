using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	public class HoweyResetTimer : Timer
    	{
		private Item item;
		private Mobile bmobile;

		public HoweyResetTimer( Item i, Mobile m ) : base( TimeSpan.FromSeconds( 5 ) )
        	{
			item = i;
			bmobile = m;
		}
		protected override void OnTick()
        	{
			DoNDAdminStone si = item as DoNDAdminStone;

			if ( si == null )
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

			DoNDAdminStone.SpawnHowey( si );

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Howey Reset Timer OK" );
                	this.Stop();
        	}
    	}
}