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
	public class WasherDryer4EastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WasherDryer4EastAddonDeed();
			}
		}

		[ Constructable ]
		public WasherDryer4EastAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1801 );
            ac.Name = "Washing Machine";
			ac.Hue = 2875;
			AddComponent( ac, 0, 1, 10 );
			ac = new AddonComponent( 1801 );
            ac.Name = "Dryer";
			ac.Hue = 2875;
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 2448 );
            ac.Name = "Laundry Basket";
			ac.Hue = 169;
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 3607 );
            ac.Name = "Bounce Sheets";
			ac.Hue = 1283;
			AddComponent( ac, 0, 1, 15 );
			ac = new AddonComponent( 3622 );
            ac.Name = "Tide Clorox 2";
			ac.Hue = 2851;
			AddComponent( ac, 0, 1, 15 );
			ac = new AddonComponent( 7727 );
            ac.Name = "Washing Machine Door";
			ac.Hue = 2357;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 7727 );
            ac.Name = "Dryer Door";
			ac.Hue = 2357;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3882 );
            ac.Name = "Washing Machine Start Button";
			AddComponent( ac, 1, 0, 16 );
			ac = new AddonComponent( 3882 );
            ac.Name = "Dryer Start Button";
			AddComponent( ac, 1, 1, 16 );

		}

		public WasherDryer4EastAddon( Serial serial ) : base( serial )
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

	public class WasherDryer4EastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WasherDryer4EastAddon();
			}
		}

		[Constructable]
		public WasherDryer4EastAddonDeed()
		{
			Name = "Washer/Dryer 4 East";
            Hue = 2875;
		}

		public WasherDryer4EastAddonDeed( Serial serial ) : base( serial )
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