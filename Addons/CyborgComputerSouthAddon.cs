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
	public class CyborgComputerSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CyborgComputerSouthAddonDeed();
			}
		}

		[ Constructable ]
		public CyborgComputerSouthAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1801 );
			ac.Hue = 908;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 908;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4241 );
			AddComponent( ac, 0, 1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 908;
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 908;
			AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 14078 );
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 14078 );
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 908;
			AddComponent( ac, 1, 0, 12 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 908;
			AddComponent( ac, 0, 0, 12 );
			ac = new AddonComponent( 7961 );
			AddComponent( ac, 1, 0, 17 );
			ac = new AddonComponent( 14265 );
			AddComponent( ac, 1, 1, 17 );

		}

		public CyborgComputerSouthAddon( Serial serial ) : base( serial )
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

	public class CyborgComputerSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CyborgComputerSouthAddon();
			}
		}

		[Constructable]
		public CyborgComputerSouthAddonDeed()
		{
			Name = "CyborgComputerSouth";
		}

		public CyborgComputerSouthAddonDeed( Serial serial ) : base( serial )
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