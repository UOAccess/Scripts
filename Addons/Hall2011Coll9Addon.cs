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
	public class Hall2011Coll9Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2011Coll9AddonDeed();
			}
		}

		[ Constructable ]
		public Hall2011Coll9Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4681 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9636 );
			AddComponent( ac, 1, 1, 16 );

		}

		public Hall2011Coll9Addon( Serial serial ) : base( serial )
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

	public class Hall2011Coll9AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2011Coll9Addon();
			}
		}

		[Constructable]
		public Hall2011Coll9AddonDeed()
		{
			Name = "Hall2011Coll9";
		}

		public Hall2011Coll9AddonDeed( Serial serial ) : base( serial )
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