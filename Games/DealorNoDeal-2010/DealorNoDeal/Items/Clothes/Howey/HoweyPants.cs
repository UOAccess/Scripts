using System;

namespace Server.Items
{
	[FlipableAttribute( 0x1539, 0x153a )]
	public class HoweyPants : LongPants
	{
		[Constructable]
		public HoweyPants()
		{
			Name = "Dress Pants";
			Weight = 2.0;
			Hue = 1175;
		}

		public HoweyPants( Serial serial ) : base( serial )
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