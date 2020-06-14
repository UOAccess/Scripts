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
	public class Hall2010GraveyardAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2010GraveyardAddonDeed();
			}
		}

		[ Constructable ]
		public Hall2010GraveyardAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1 );
			ac.Hue = 2624;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 4454 );
			ac.Hue = 2624;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 1 );
			ac.Hue = 2624;
			AddComponent( ac, 2, 1, 3 );
			ac = new AddonComponent( 4458 );
			ac.Hue = 2624;
			AddComponent( ac, 2, 1, 3 );
			ac = new AddonComponent( 1 );
			ac.Hue = 2624;
			AddComponent( ac, 4, 1, 3 );
			ac = new AddonComponent( 4456 );
			ac.Hue = 2624;
			AddComponent( ac, 4, 1, 3 );
			ac = new AddonComponent( 1 );
			ac.Hue = 2824;
			AddComponent( ac, -1, 1, 3 );
			ac = new AddonComponent( 12510 );
			ac.Hue = 2824;
			AddComponent( ac, 1, 0, 4 );
			ac = new AddonComponent( 12507 );
			ac.Hue = 2824;
			AddComponent( ac, -2, 1, 3 );
			ac = new AddonComponent( 12509 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 12507 );
			ac.Hue = 2824;
			AddComponent( ac, -2, 1, 3 );
			ac = new AddonComponent( 12509 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 12510 );
			ac.Hue = 2824;
			AddComponent( ac, 1, 0, 4 );
			ac = new AddonComponent( 1 );
			ac.Hue = 2824;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 12482 );
			ac.Hue = 2824;
			AddComponent( ac, 2, -3, 3 );
			ac = new AddonComponent( 12481 );
			ac.Hue = 2824;
			AddComponent( ac, 3, -1, 3 );
			ac = new AddonComponent( 12481 );
			ac.Hue = 2824;
			AddComponent( ac, 3, -1, 3 );
			ac = new AddonComponent( 12482 );
			ac.Hue = 2824;
			AddComponent( ac, 2, -3, 3 );
			ac = new AddonComponent( 12477 );
			ac.Hue = 2824;
			AddComponent( ac, 3, 0, 3 );
			ac = new AddonComponent( 12478 );
			ac.Hue = 2824;
			AddComponent( ac, 2, 0, 3 );
			ac = new AddonComponent( 12479 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 12480 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 12478 );
			ac.Hue = 2824;
			AddComponent( ac, 2, 0, 3 );
			ac = new AddonComponent( 12479 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 12480 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 12477 );
			ac.Hue = 2824;
			AddComponent( ac, 3, 0, 3 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 3, 3 );
			ac = new AddonComponent( 3795 );
			AddComponent( ac, 0, 4, 3 );
			ac = new AddonComponent( 3809 );
			AddComponent( ac, 0, 2, 3 );
			ac = new AddonComponent( 3795 );
			AddComponent( ac, 0, 3, 3 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 2, 3, 3 );
			ac = new AddonComponent( 3795 );
			AddComponent( ac, 2, 4, 3 );
			ac = new AddonComponent( 3809 );
			AddComponent( ac, 2, 2, 3 );
			ac = new AddonComponent( 3795 );
			AddComponent( ac, 2, 3, 3 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 4, 3, 3 );
			ac = new AddonComponent( 3795 );
			AddComponent( ac, 4, 4, 3 );
			ac = new AddonComponent( 3809 );
			AddComponent( ac, 4, 2, 3 );
			ac = new AddonComponent( 3795 );
			AddComponent( ac, 4, 3, 3 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 1, 2, 3 );
			ac = new AddonComponent( 9671 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 2, 9 );
			ac = new AddonComponent( 14217 );
			ac.Hue = 1153;
			AddComponent( ac, 2, 3, 3 );
			ac = new AddonComponent( 12506 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 2, 3 );
			ac = new AddonComponent( 12508 );
			ac.Hue = 2824;
			AddComponent( ac, -3, 2, 3 );
			ac = new AddonComponent( 12503 );
			ac.Hue = 2824;
			AddComponent( ac, 2, 3, 26 );
			ac = new AddonComponent( 12506 );
			ac.Hue = 2824;
			AddComponent( ac, 0, 2, 3 );
			ac = new AddonComponent( 12508 );
			ac.Hue = 2824;
			AddComponent( ac, -3, 2, 3 );
			ac = new AddonComponent( 12503 );
			ac.Hue = 2824;
			AddComponent( ac, 2, 3, 26 );

		}

		public Hall2010GraveyardAddon( Serial serial ) : base( serial )
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

	public class Hall2010GraveyardAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2010GraveyardAddon();
			}
		}

		[Constructable]
		public Hall2010GraveyardAddonDeed()
		{
			Name = "Hall2010Graveyard";
		}

		public Hall2010GraveyardAddonDeed( Serial serial ) : base( serial )
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