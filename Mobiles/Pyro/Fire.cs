//Pyro And Changes By Home Wrecker aka Amon////////////
//////////////////////////////////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class Fire : Item
	{
		
	

		[Constructable]
		public Fire() 
		{
			Movable = false;
                        ItemID = 0x398c; 

			new InternalTimer( this ).Start();
		}

		public Fire( Serial serial ) : base( serial )
		{
			new InternalTimer( this ).Start();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		private class InternalTimer : Timer
		{
			private Item m_Fire;

			public InternalTimer( Item Fire ) : base( TimeSpan.FromSeconds( 10.0 ) )
			{
				Priority = TimerPriority.OneSecond;

				m_Fire = Fire;
			}

			protected override void OnTick()
			{
				m_Fire.Delete();
			}
		}
	}
}
