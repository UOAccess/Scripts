using System;
using Server;

namespace Server.Items
{
	public class DoNDBankerDoll : Item
	{
		[Constructable]
		public DoNDBankerDoll() : base( 0x2106 )
		{
			Name = "The Banker";
			Hue = 33;
			LootType = LootType.Blessed;	
		}

		public DoNDBankerDoll( Serial serial ) : base( serial )
		{
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
	}
}