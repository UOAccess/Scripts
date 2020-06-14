using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class SkullPileOfEnlighentment : Item
	{
		[Constructable]
		public SkullPileOfEnlighentment( ) : base( 0x21FC )
		{
			Name = "SkullPileOfEnlighentment";
			Stackable = false;
			Weight = 1.0;
			Hue = 0;
		}

		public SkullPileOfEnlighentment( Serial serial ) : base( serial )
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