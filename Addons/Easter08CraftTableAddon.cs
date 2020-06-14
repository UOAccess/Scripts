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
	public class Easter08CraftTableAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Easter08CraftTableAddonDeed();
			}
		}

		[ Constructable ]
		public Easter08CraftTableAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2816 );
			ac.Hue = 1150;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2818 );
			ac.Hue = 1150;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2817 );
			ac.Hue = 1150;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4652 );
			ac.Hue = 65;
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 4651 );
			ac.Hue = 21;
			AddComponent( ac, 0, 0, 4 );
			ac = new AddonComponent( 7847 );
			ac.Hue = 1161;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 7847 );
			ac.Hue = 88;
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 7847 );
			ac.Hue = 421;
			AddComponent( ac, -1, 0, 4 );
			ac = new AddonComponent( 7847 );
			ac.Hue = 2500;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 7847 );
			ac.Hue = 65;
			AddComponent( ac, -1, 0, 5 );
			ac = new AddonComponent( 4104 );
			ac.Hue = 293;
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 4006 );
			ac.Hue = 1150;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 2453 );
			ac.Hue = 421;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 2453 );
			ac.Hue = 88;
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 2453 );
			ac.Hue = 65;
			AddComponent( ac, 1, 0, 3 );

		}

		public Easter08CraftTableAddon( Serial serial ) : base( serial )
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

	public class Easter08CraftTableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Easter08CraftTableAddon();
			}
		}

		[Constructable]
		public Easter08CraftTableAddonDeed()
		{
			Name = "Easter08CraftTable";
		}

		public Easter08CraftTableAddonDeed( Serial serial ) : base( serial )
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