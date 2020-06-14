using System;

namespace Server.Items
{
	[FlipableAttribute( 0x1efd, 0x1efe )]
	public class HoweyJacket : Doublet
	{
		[Constructable]
		public HoweyJacket()
		{
			Name = "Dress Jacket";
			Weight = 2.0;
			Hue = 1175;
		}

		public HoweyJacket( Serial serial ) : base( serial )
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