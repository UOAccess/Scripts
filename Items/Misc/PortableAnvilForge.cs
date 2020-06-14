using System;

namespace Server.Items
{
	[FlipableAttribute( 0xFAF, 0xFB0 )]
	[Server.Engines.Craft.Anvil]
	public class PortableAnvil : Item
	{
		[Constructable]
		public PortableAnvil() : base( 0xFAF )
		{
            Name = "Portable Anvil";
			Movable = true;
            LootType = LootType.Blessed;
            Hue = 1150;
		}

        public PortableAnvil(Serial serial) : base(serial)
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

	[Server.Engines.Craft.Forge]
	public class PortableForge : Item
	{
		[Constructable]
        public PortableForge() : base(0x19BB)
		{
            Name = "Portable Forge";
			Movable = true;
            LootType = LootType.Blessed;
            Hue = 1150;
		}

		public PortableForge( Serial serial ) : base( serial )
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