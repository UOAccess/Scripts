using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class SkullPileOfDeath : Item
	{
		[Constructable]
		public SkullPileOfDeath( ) : base( 0x21FC )
		{
			Name = "SkullPileOfDeath";
			Stackable = false;
			Weight = 1.0;
			Hue = 37;
		}

		public SkullPileOfDeath( Serial serial ) : base( serial )
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