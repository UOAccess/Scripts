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
	public class Easter2014BluePotAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Easter2014BluePotAddonDeed();
			}
		}

		[ Constructable ]
		public Easter2014BluePotAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4550 );
			ac.Hue = 2121;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3208 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 9036 );
			AddComponent( ac, 0, 0, 3 );

		}

		public Easter2014BluePotAddon( Serial serial ) : base( serial )
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

	public class Easter2014BluePotAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Easter2014BluePotAddon();
			}
		}

		[Constructable]
		public Easter2014BluePotAddonDeed()
		{
			Name = "Easter2014BluePot";
		}

		public Easter2014BluePotAddonDeed( Serial serial ) : base( serial )
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