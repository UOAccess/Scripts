using System;
using Server;

namespace Server.Items
{
	public class DoNDHoweyDoll : Item
	{
		[Constructable]
		public DoNDHoweyDoll() : base( 0x2106 )
		{
			Name = "Howey Mandel";
			LootType = LootType.Blessed;	
		}

		public DoNDHoweyDoll( Serial serial ) : base( serial )
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