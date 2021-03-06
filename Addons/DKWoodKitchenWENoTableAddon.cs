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
	public class DKWoodKitchenWENoTableAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DKWoodKitchenWENoTableAddonDeed();
			}
		}

		[ Constructable ]
		public DKWoodKitchenWENoTableAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -4, 3, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -4, 2, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -4, 2, 6 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 4, 2, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 4, 1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 4, 0, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 4, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -4, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -3, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -2, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 2, -1, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 3, -1, 1 );
			ac = new AddonComponent( 4497 );
			AddComponent( ac, -4, 0, 1 );
			ac = new AddonComponent( 4497 );
			AddComponent( ac, -4, 1, 1 );
			ac = new AddonComponent( 6572 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 0, -1, 9 );
			ac = new AddonComponent( 7979 );
			AddComponent( ac, 0, -1, 9 );
			ac = new AddonComponent( 2541 );
			AddComponent( ac, -1, -1, 7 );
			ac = new AddonComponent( 5465 );
			AddComponent( ac, 4, 1, 6 );
			ac = new AddonComponent( 11526 );
			ac.Hue = 1153;
			AddComponent( ac, 4, 3, 1 );
			ac = new AddonComponent( 6420 );
			ac.Hue = 2283;
			AddComponent( ac, 4, 0, 6 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 4, -1, 6 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 4, -1, 11 );
			ac = new AddonComponent( 6572 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 10331 );
			ac.Hue = 1029;
			AddComponent( ac, 3, -1, 10 );
			ac = new AddonComponent( 10331 );
			ac.Hue = 1029;
			AddComponent( ac, 2, -1, 10 );
			ac = new AddonComponent( 10331 );
			ac.Hue = 1029;
			AddComponent( ac, -3, -1, 10 );
			ac = new AddonComponent( 10331 );
			ac.Hue = 1029;
			AddComponent( ac, -2, -1, 10 );
			ac = new AddonComponent( 11599 );
			AddComponent( ac, -4, 1, 10 );
			ac = new AddonComponent( 4555 );
			AddComponent( ac, -4, 3, 8 );
			ac = new AddonComponent( 3129 );
			ac.Hue = 1036;
			AddComponent( ac, 1, -1, 5 );
			ac = new AddonComponent( 3129 );
			ac.Hue = 1036;
			AddComponent( ac, 0, -1, 5 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -4, -1, 6 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -4, -1, 11 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 3, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, -1, 2, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 2, 1 );
			ac = new AddonComponent( 1848 );
			ac.Hue = 1036;
			AddComponent( ac, 0, 3, 1 );
			ac = new AddonComponent( 3136 );
			AddComponent( ac, 1, -1, 6 );
			ac = new AddonComponent( 3134 );
			AddComponent( ac, 1, -1, 6 );
			ac = new AddonComponent( 3132 );
			AddComponent( ac, 0, -1, 7 );
			ac = new AddonComponent( 3138 );
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 7711 );
			AddComponent( ac, 0, 2, 7 );
			ac = new AddonComponent( 2449 );
			AddComponent( ac, 0, 2, 6 );
			ac = new AddonComponent( 2500 );
			AddComponent( ac, -1, 3, 6 );

		}

		public DKWoodKitchenWENoTableAddon( Serial serial ) : base( serial )
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

	public class DKWoodKitchenWENoTableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DKWoodKitchenWENoTableAddon();
			}
		}

		[Constructable]
		public DKWoodKitchenWENoTableAddonDeed()
		{
			Name = "DKWoodKitchenWENoTable";
		}

		public DKWoodKitchenWENoTableAddonDeed( Serial serial ) : base( serial )
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