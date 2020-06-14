using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class DoNDGameTicket : Item
	{
		[Constructable]
		public DoNDGameTicket() : base( 0x14EF )
		{
			Name = "DoND Game Ticket";
			Hue = 1161;

			LootType = LootType.Blessed;
		}

		public override bool DisplayLootType{ get{ return false; } }

		public DoNDGameTicket( Serial serial ) : base( serial )
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