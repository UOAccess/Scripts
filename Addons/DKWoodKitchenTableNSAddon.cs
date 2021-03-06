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
	public class DKWoodKitchenTableNSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DKWoodKitchenTableNSAddonDeed();
			}
		}

		[ Constructable ]
		public DKWoodKitchenTableNSAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2948 );
			ac.Hue = 1036;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2947 );
			ac.Hue = 1036;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2951 );
			ac.Hue = 1036;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2949 );
			ac.Hue = 1036;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 2902 );
			ac.Hue = 1036;
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 2903 );
			ac.Hue = 1036;
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2903 );
			ac.Hue = 1036;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2903 );
			ac.Hue = 1036;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2904 );
			ac.Hue = 1036;
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 2905 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 2905 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2905 );
			ac.Hue = 1036;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, -2, 0, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, -1, -1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, 1, -1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, 2, 0, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1428;
			AddComponent( ac, -1, 1, 6 );
			ac = new AddonComponent( 2516 );
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 2516 );
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 2516 );
			AddComponent( ac, -1, 1, 6 );
			ac = new AddonComponent( 2493 );
			AddComponent( ac, -2, 0, 6 );
			ac = new AddonComponent( 2517 );
			AddComponent( ac, 2, 0, 6 );
			ac = new AddonComponent( 2494 );
			AddComponent( ac, 1, -1, 6 );
			ac = new AddonComponent( 2494 );
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 2494 );
			AddComponent( ac, -1, -1, 6 );
			ac = new AddonComponent( 2537 );
			AddComponent( ac, -1, 0, 6 );
			ac = new AddonComponent( 10304 );
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 2429 );
			AddComponent( ac, 1, 0, 6 );

		}

		public DKWoodKitchenTableNSAddon( Serial serial ) : base( serial )
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

	public class DKWoodKitchenTableNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DKWoodKitchenTableNSAddon();
			}
		}

		[Constructable]
		public DKWoodKitchenTableNSAddonDeed()
		{
			Name = "DKWoodKitchenTableNS";
		}

		public DKWoodKitchenTableNSAddonDeed( Serial serial ) : base( serial )
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