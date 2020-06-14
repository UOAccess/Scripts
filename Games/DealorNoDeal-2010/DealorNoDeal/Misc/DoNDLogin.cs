using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	public class DoNDLogin
	{
		public static void Initialize()
		{
			EventSink.Login += new LoginEventHandler( OnLogin );
		}

		private static void OnLogin( LoginEventArgs e )
		{
			if ( e.Mobile is PlayerMobile )
			{
				PlayerMobile pm = (PlayerMobile)e.Mobile;

				if (pm == null || pm.Backpack == null)
    					return; 

				Item check = pm.Backpack.FindItemByType(typeof(DoNDGameDeed) );

				if ( check != null )
					check.Delete();

				if ( pm.Frozen == true )
					pm.Frozen = false;

				Item check2 = pm.Backpack.FindItemByType(typeof(DoNDReplayDeed) );

				if ( check2 == null )
					return;

				DoNDReplayDeed rd = check2 as DoNDReplayDeed;
	
				if ( rd == null )
					return;

				if ( rd.RP1 < 24 )
				{
					Timer i_timer = new PlayerReplayTimer( pm ); 
    						i_timer.Start();
				}
				
				if ( rd.RP1 >= 24 )
					rd.Delete();
			}
		}
	}
}
