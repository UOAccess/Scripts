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
	public class BeachUmbrella1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BeachUmbrella1AddonDeed();
			}
		}

		[ Constructable ]
		public BeachUmbrella1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 950 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 950 );
			AddComponent( ac, 1, 1, 7 );
			ac = new AddonComponent( 1540 );
			ac.Hue = 23;
			AddComponent( ac, 1, 1, 8 );
			ac = new AddonComponent( 1541 );
			ac.Hue = 693;
			AddComponent( ac, 1, 0, 8 );
			ac = new AddonComponent( 1542 );
			ac.Hue = 262;
			AddComponent( ac, 0, 0, 8 );
			ac = new AddonComponent( 1543 );
			ac.Hue = 55;
			AddComponent( ac, 0, 1, 8 );

		}

		public BeachUmbrella1Addon( Serial serial ) : base( serial )
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

	public class BeachUmbrella1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BeachUmbrella1Addon();
			}
		}

		[Constructable]
		public BeachUmbrella1AddonDeed()
		{
			Name = "BeachUmbrella1";
		}

		public BeachUmbrella1AddonDeed( Serial serial ) : base( serial )
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