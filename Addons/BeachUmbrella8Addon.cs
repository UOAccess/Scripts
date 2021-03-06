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
	public class BeachUmbrella8Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BeachUmbrella8AddonDeed();
			}
		}

		[ Constructable ]
		public BeachUmbrella8Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 950 );
			ac.Hue = 2642;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 950 );
			ac.Hue = 2642;
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 1542 );
			ac.Hue = 2369;
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 1543 );
			ac.Hue = 2547;
			AddComponent( ac, 0, 1, 20 );
			ac = new AddonComponent( 1541 );
			ac.Hue = 2797;
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 1540 );
			ac.Hue = 2669;
			AddComponent( ac, 1, 1, 20 );
			ac = new AddonComponent( 1544 );
			ac.Hue = 2309;
			AddComponent( ac, 1, 1, 33 );

		}

		public BeachUmbrella8Addon( Serial serial ) : base( serial )
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

	public class BeachUmbrella8AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BeachUmbrella8Addon();
			}
		}

		[Constructable]
		public BeachUmbrella8AddonDeed()
		{
			Name = "BeachUmbrella8";
		}

		public BeachUmbrella8AddonDeed( Serial serial ) : base( serial )
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