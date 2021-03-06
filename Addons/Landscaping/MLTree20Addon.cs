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
	public class MLTree20Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MLTree20AddonDeed();
			}
		}

		[ Constructable ]
		public MLTree20Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 14803 );
			AddComponent( ac, 5, -3, 0 );
			ac = new AddonComponent( 14802 );
			AddComponent( ac, 5, -2, 0 );
			ac = new AddonComponent( 14801 );
			AddComponent( ac, 5, -1, 0 );
			ac = new AddonComponent( 14800 );
			AddComponent( ac, 5, 0, 0 );
			ac = new AddonComponent( 14799 );
			AddComponent( ac, 5, 1, 0 );
			ac = new AddonComponent( 14798 );
			AddComponent( ac, 5, 2, 0 );
			ac = new AddonComponent( 14797 );
			AddComponent( ac, 5, 3, 0 );
			ac = new AddonComponent( 14796 );
			AddComponent( ac, -4, 4, 0 );
			ac = new AddonComponent( 14795 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 14794 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 14793 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 14792 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 14791 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 14790 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 14789 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 14788 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 14787 );
			AddComponent( ac, 5, 4, 0 );

		}

		public MLTree20Addon( Serial serial ) : base( serial )
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

	public class MLTree20AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MLTree20Addon();
			}
		}

		[Constructable]
		public MLTree20AddonDeed()
		{
			Name = "MLTree20";
		}

		public MLTree20AddonDeed( Serial serial ) : base( serial )
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