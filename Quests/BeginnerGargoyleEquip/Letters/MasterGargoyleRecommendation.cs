using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class MasterGargoyleRecommendation : Item
	{
		[Constructable]
		public MasterGargoyleRecommendation() : base( 0x14F0 )
		{
			base.Weight = 1.0;
			base.Name = "Master Letter of Gargoyle Recommendation for Jaigar";
			Hue = 84;
		}

		public MasterGargoyleRecommendation( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile m )
		{
			m.SendMessage( "Master Letter of Gargoyle Recommendation for Jaigar" );
		}
	}
}


