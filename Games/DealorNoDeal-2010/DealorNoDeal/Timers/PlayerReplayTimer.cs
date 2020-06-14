using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	public class PlayerReplayTimer : Timer
    	{
		private Mobile pmobile;

		public PlayerReplayTimer( Mobile m ) : base( TimeSpan.FromMinutes( 1 ) )
        	{
			pmobile = m;
		}
		protected override void OnTick()
        	{
			PlayerMobile pm = pmobile as PlayerMobile;

			if ( pm == null || pm.Backpack == null )
			{
                		this.Stop();
				return;
			}

			Item check = pm.Backpack.FindItemByType(typeof(DoNDReplayDeed) );

			if ( check == null )
			{
                		this.Stop();
				return;
			}

			DoNDReplayDeed gd = check as DoNDReplayDeed;

			if ( gd == null )
			{
                		this.Stop();
				return;
			}
	
			gd.RPM1 +=1;

			if ( gd.RPM1 == 60 )
			{
				gd.RP1 +=1;
				gd.RPM1 = 0;
				this.Start();
				return;
			}

			if ( gd.RP1 == gd.RReplay )
			{
				pm.SendMessage( pm.Name + ", You can now play Deal or No Deal!");
				gd.Delete();
				return;
			}

			if ( gd.RP1 < gd.RReplay )
			{
				this.Start();
				return;
			}
        	}
    	}
}