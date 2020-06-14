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
	public class DKWoodKitchenTableAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DKWoodKitchenTableAddonDeed();
			}
		}

		[ Constructable ]
		public DKWoodKitchenTableAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2948 );
			ac.Hue = 1036;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2951 );
			ac.Hue = 1036;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2947 );
			ac.Hue = 1036;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2949 );
			ac.Hue = 1036;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 2903 );
			ac.Hue = 1036;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2903 );
			ac.Hue = 1036;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2903 );
			ac.Hue = 1036;
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2902 );
			ac.Hue = 1036;
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 2905 );
			ac.Hue = 1036;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2905 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2905 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, 1, -1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, -1, -1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, -2, 0, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, -1, 1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 2413;
			AddComponent( ac, 2, 0, 6 );
			ac = new AddonComponent( 2494 );
			AddComponent( ac, 1, -1, 6 );
			ac = new AddonComponent( 2494 );
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 2494 );
			AddComponent( ac, -1, -1, 6 );
			ac = new AddonComponent( 2493 );
			AddComponent( ac, -2, 0, 6 );
			ac = new AddonComponent( 2516 );
			AddComponent( ac, -1, 1, 6 );
			ac = new AddonComponent( 2516 );
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 2516 );
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 2517 );
			AddComponent( ac, 2, 0, 6 );
			ac = new AddonComponent( 2491 );
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 2950 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2537 );
			AddComponent( ac, -1, 0, 6 );
			ac = new AddonComponent( 2904 );
			ac.Hue = 1036;
			AddComponent( ac, 3, 0, 0 );

		}

		public DKWoodKitchenTableAddon( Serial serial ) : base( serial )
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

	public class DKWoodKitchenTableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DKWoodKitchenTableAddon();
			}
		}

		[Constructable]
		public DKWoodKitchenTableAddonDeed()
		{
			Name = "DKWoodKitchenTable";
		}

		public DKWoodKitchenTableAddonDeed( Serial serial ) : base( serial )
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