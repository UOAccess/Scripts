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
	public class WasherDryer11SouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WasherDryer11SouthAddonDeed();
			}
		}

		[ Constructable ]
		public WasherDryer11SouthAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1928 );
            ac.Name = "Washing Machine";
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 1928 );
            ac.Name = "Dryer";
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 3607 );
            ac.Name = "Bounce Sheets";
			ac.Hue = 1283;
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 3622 );
            ac.Name = "Tide Clorox 2";
			ac.Hue = 2851;
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 2448 );
            ac.Name = "Laundry Basket";
			ac.Hue = 169;
			AddComponent( ac, 1, 0, 15 );
			ac = new AddonComponent( 7726 );
            ac.Name = "Washing Machine Door";
			ac.Hue = 2357;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 7726 );
            ac.Name = "Dryer Door";
			ac.Hue = 2357;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3882 );
            ac.Name = "Washing Machine Start Button";
			AddComponent( ac, 0, 1, 16 );
			ac = new AddonComponent( 3882 );
            ac.Name = "Dryer Start Button";
			AddComponent( ac, 1, 1, 16 );

		}

		public WasherDryer11SouthAddon( Serial serial ) : base( serial )
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

	public class WasherDryer11SouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WasherDryer11SouthAddon();
			}
		}

		[Constructable]
		public WasherDryer11SouthAddonDeed()
		{
			Name = "Washer/Dryer 11 South";
            Hue = 1112;
		}

		public WasherDryer11SouthAddonDeed( Serial serial ) : base( serial )
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