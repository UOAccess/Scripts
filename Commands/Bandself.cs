using System;
using Server;
using Server.Items;
using Server.Commands;

namespace Server.Commands
{
	public class Bandself
	{
		public static void Initialize()
		{
			CommandSystem.Register( "BandSelf", AccessLevel.Player, new CommandEventHandler( BandSelf_OnCommand ) );
		}
		[Usage( "BandSelf" )]
		public static void BandSelf_OnCommand( CommandEventArgs e )
		{
			Mobile from = e.Mobile;

			if( from != null)
			{
				Container backpack = from.Backpack;

				if( backpack != null )
				{
					Bandage bandage = (Bandage) backpack.FindItemByType( typeof( Bandage ) );

					if ( bandage != null )
					{
						Targeting.Target.Cancel( from );

						from.RevealingAction();

						if ( BandageContext.BeginHeal( from, from ) != null )
							bandage.Consume();
					}
					else
						e.Mobile.SendMessage( "Cannot find bandage." );
				}
				else
					from.SendMessage( "You don't have a Backpack." );
			}
		}
	}
}