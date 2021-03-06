/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class D14EasterBunnyGreenAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new D14EasterBunnyGreenAddonDeed();
			}
		}

		[ Constructable ]
		public D14EasterBunnyGreenAddon()
		{
			AddComponent( new AddonComponent( 10139 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 3576 ), 0, 0, 1 );
			AddComponent( new AddonComponent( 3576 ), 0, 0, 2 );
			AddComponent( new AddonComponent( 10118 ), 0, 0, 5 );
			AddComponent( new AddonComponent( 3576 ), 0, 0, 6 );
			AddComponent( new AddonComponent( 10136 ), 0, 0, 9 );
			AddComponent( new AddonComponent( 8965 ), 1, 0, 9 );
			AddComponent( new AddonComponent( 3576 ), 0, 0, 10 );
			AddComponent( new AddonComponent( 3864 ), 0, 0, 11 );
			AddComponent( new AddonComponent( 5441 ), 0, 0, 15 );
			AddComponent( new AddonComponent( 5441 ), 0, 1, 15 );
			AddComponent( new AddonComponent( 6479 ), 0, 1, 2 );

		}

		public D14EasterBunnyGreenAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class D14EasterBunnyGreenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new D14EasterBunnyGreenAddon();
			}
		}

		[Constructable]
		public D14EasterBunnyGreenAddonDeed()
		{
			Name = "D14EasterBunnyGreen";
		}

		public D14EasterBunnyGreenAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}