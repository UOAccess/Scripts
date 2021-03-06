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
	public class KitchenCabinetsDAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KitchenCabinetsDAddonDeed();
			}
		}

		[ Constructable ]
		public KitchenCabinetsDAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1801 );
			ac.Hue = 1153;
			AddComponent( ac, 0, -2, 1 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 2510;
			AddComponent( ac, 0, -2, 12 );
			ac = new AddonComponent( 11526 );
			ac.Hue = 2510;
			AddComponent( ac, 0, -3, 1 );
			ac = new AddonComponent( 2451 );
			AddComponent( ac, 0, -2, 6 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 2510;
			AddComponent( ac, 0, 2, 12 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 2510;
			AddComponent( ac, 0, -1, 12 );
			ac = new AddonComponent( 11754 );
			ac.Hue = 2510;
			AddComponent( ac, 0, 1, 14 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 3, 1 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 2, 1 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 2510;
			AddComponent( ac, 0, 3, 12 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, 2, 7 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1153;
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 11526 );
			ac.Hue = 2510;
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 6867 );
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 2519 );
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 4000 );
			ac.Hue = 1150;
			AddComponent( ac, 1, 3, 17 );
			ac = new AddonComponent( 3871 );
			AddComponent( ac, 1, 2, 12 );
			ac = new AddonComponent( 3871 );
			AddComponent( ac, 1, 2, 14 );

		}

		public KitchenCabinetsDAddon( Serial serial ) : base( serial )
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

	public class KitchenCabinetsDAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KitchenCabinetsDAddon();
			}
		}

		[Constructable]
		public KitchenCabinetsDAddonDeed()
		{
			Name = "KitchenCabinetsD";
		}

		public KitchenCabinetsDAddonDeed( Serial serial ) : base( serial )
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