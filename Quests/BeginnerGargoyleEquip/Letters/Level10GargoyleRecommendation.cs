using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class Level10GargoyleRecommendation : Item
	{
		[Constructable]
		public Level10GargoyleRecommendation() : base( 0x14F0 )
		{
			base.Weight = 1.0;
			base.Name = "Level 10 Letter of Gargoyle Recommendation for Jaigar";
			Hue = 84;
		}

		public Level10GargoyleRecommendation( Serial serial ) : base( serial )
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
			m.SendMessage( "Level 10 Letter of Gargoyle Recommendation for Jaigar" );
		}
	}
}


