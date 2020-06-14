using System;
using Server;
using Server.Gumps;
using Server.Mobiles;

namespace Server.Items
{
	public class CloseCaseTimer : Timer
    	{
		private Item item;
		private Mobile mobile;

		public CloseCaseTimer( Mobile m, Item i ) : base( TimeSpan.FromSeconds( 1 ) )
        	{
			mobile = m;
			item = i;
		}
		protected override void OnTick()
        	{
			PlayerMobile pm = mobile as PlayerMobile;

			if ( pm == null )
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
			gd.CloseCase = true;

			if (pm.HasGump( typeof( DoNDMainGump )))
				pm.CloseGump( typeof( DoNDMainGump ) );
			pm.SendGump( new DoNDMainGump( pm, gd ) );
			this.Stop();
        	}
    	}
}