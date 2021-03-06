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
	public class MLTree03Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MLTree03AddonDeed();
			}
		}

		[ Constructable ]
		public MLTree03Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 14829 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 14828 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 14827 );
			AddComponent( ac, -1, 1, 0 );

		}

		public MLTree03Addon( Serial serial ) : base( serial )
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

	public class MLTree03AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MLTree03Addon();
			}
		}

		[Constructable]
		public MLTree03AddonDeed()
		{
			Name = "MLTree03";
		}

		public MLTree03AddonDeed( Serial serial ) : base( serial )
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