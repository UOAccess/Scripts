using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class SkullPileOfPower: Item
	{
		[Constructable]
		public SkullPileOfPower( ) : base( 0x21FC )
		{
			Name = "SkullPileOfPower";
			Stackable = false;
			Weight = 1.0;
			Hue = 345;
		}

		public SkullPileOfPower( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}