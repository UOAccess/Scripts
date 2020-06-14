using System;

namespace Server.Items
{
	[FlipableAttribute( 0x170f, 0x1710 )]
	public class HoweyShoes : Shoes
	{
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

		[Constructable]
		public HoweyShoes()
		{
			Name = "Dress Shoes";
			Weight = 2.0;
			Hue = 1175;
		}

		public HoweyShoes( Serial serial ) : base( serial )
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
