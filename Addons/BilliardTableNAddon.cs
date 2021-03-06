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
	public class AG_BilliardTableNAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_BilliardTableNAddonDeed();
			}
		}

		[ Constructable ]
		public AG_BilliardTableNAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, -3, -1, 3 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, -3, 0, 3 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, -2, -2, 2 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1;
			AddComponent( ac, -2, -1, 12 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1;
			AddComponent( ac, -2, 2, 12 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, -3, 1, 3 );
			ac = new AddonComponent( 696 );
			ac.Hue = 1536;
			ac.Name = "Legs";
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 696 );
			ac.Hue = 1845;
			AddComponent( ac, -2, 2, 11 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2931 );
			ac.Hue = 267;
			ac.Name = "Felt";
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 2, -1, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 2, 0, 2 );
			ac = new AddonComponent( 678 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 2, 1, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, -1, -2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 0, -2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 1, -2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 2, -2, 2 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, -1, 2, 12 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 0, 2, 12 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 1, 2, 12 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 2, 2, 12 );
			ac = new AddonComponent( 677 );
			ac.Hue = 1845;
			ac.Name = "Rail";
			AddComponent( ac, 3, 2, 12 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1;
			AddComponent( ac, 3, -1, 11 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1;
			AddComponent( ac, 4, 3, 22 );
			ac = new AddonComponent( 696 );
			ac.Hue = 1536;
			ac.Name = "Legs";
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 696 );
			ac.Hue = 1536;
			ac.Name = "Legs";
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 3569 );
			ac.Name = "Cue Stick";
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 12694 );
			ac.Name = "Cue Ball";
			AddComponent( ac, -1, -1, 6 );
			ac = new AddonComponent( 12693 );
			ac.Name = "Three Ball";
			AddComponent( ac, -1, 0, 6 );
			ac = new AddonComponent( 12697 );
			ac.Name = "Two Ball";
			AddComponent( ac, 2, 0, 6 );
			ac = new AddonComponent( 12690 );
			ac.Name = "Four Ball";
			AddComponent( ac, 0, 1, 6 );

		}

		public AG_BilliardTableNAddon( Serial serial ) : base( serial )
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

	public class AG_BilliardTableNAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_BilliardTableNAddon();
			}
		}

		[Constructable]
		public AG_BilliardTableNAddonDeed()
		{
			Name = "AG_BilliardTableN";
		}

		public AG_BilliardTableNAddonDeed( Serial serial ) : base( serial )
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