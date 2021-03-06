/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_BilliardTableSmallW2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_BilliardTableSmallW2AddonDeed();
			}
		}

		[ Constructable ]
		public AG_BilliardTableSmallW2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3569 );
			ac.Name = "Cue Stick";
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1837;
			ac.Name = "Pocket";
			AddComponent( ac, 2, -1, 11 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1837;
			ac.Name = "Pocket";
			AddComponent( ac, 0, -1, 12 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1837;
			ac.Name = "Pocket";
			AddComponent( ac, 0, 3, 11 );
			ac = new AddonComponent( 696 );
			ac.Hue = 1870;
			AddComponent( ac, -1, -2, 1 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, -1, -1, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, -1, 0, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, -1, 1, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, -1, 2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 0, -2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 1, -2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 0, 2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 1, 2, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 1, 1, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Cushion";
			AddComponent( ac, 1, 2, 2 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1837;
			ac.Name = "Pocket";
			AddComponent( ac, 2, 3, 11 );
			ac = new AddonComponent( 2930 );
			ac.Hue = 267;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Pool Table";
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2928 );
			ac.Hue = 267;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2929 );
			ac.Hue = 267;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2930 );
			ac.Hue = 267;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 12694 );
			ac.Name = "Cue Ball";
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 12697 );
			ac.Name = "Two Ball";
			AddComponent( ac, 0, 1, 6 );
			ac = new AddonComponent( 12691 );
			ac.Name = "Four Ball";
			AddComponent( ac, 1, 2, 6 );

		}

		public AG_BilliardTableSmallW2Addon( Serial serial ) : base( serial )
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

	public class AG_BilliardTableSmallW2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_BilliardTableSmallW2Addon();
			}
		}

		[Constructable]
		public AG_BilliardTableSmallW2AddonDeed()
		{
			Name = "AG_BilliardTableSmallW2";
		}

		public AG_BilliardTableSmallW2AddonDeed( Serial serial ) : base( serial )
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