using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Gumps;

namespace Server.Mobiles
{
	public class MobileDeleteTimer : Timer
    	{
		private Mobile pmobile;
		private Mobile bmobile;
		private Mobile m_DG;

		public Mobile DG
		{
			get{ return m_DG; }
			set{ m_DG = value; }
		}

		public MobileDeleteTimer( Mobile pmm, Mobile bcc ) : base( TimeSpan.FromSeconds( 1 ) )
        	{
			pmobile = pmm;
			bmobile = bcc;
		}
		protected override void OnTick()
        	{
			Howey bc = bmobile as Howey;

			if ( bc == null )
			{
                		this.Stop();
				return;
			}

			PlayerMobile pm = pmobile as PlayerMobile;

			if ( pm == null || pm.Backpack == null )
			{	
				GameSystem.EndDDGame( pm, bc );
                		this.Stop();
				return;
			}

			Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

			DoNDGameDeed gd = check as DoNDGameDeed;

			if ( gd == null )
			{
                		this.Stop();
                		return;
			}

			if ( gd.Commercial == true )
			{
				if (pm.HasGump( typeof( DoNDCommercialGump )))
					pm.CloseGump( typeof( DoNDCommercialGump ) );
				pm.SendGump( new DoNDCommercialGump( pm ) );
			}

			if ( gd.GameOver == false )
			{
				this.Start();
				return;
			}

			GameSystem.EndDDGame( pm, bc );

			if ( bc.DeBugger == true )
				Console.WriteLine( "DeBug : System, Mobile Delete Timer OK" );
			this.Stop();
        	}
    	}
}