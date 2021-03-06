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
	public class DestroyedWagonAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DestroyedWagonAddonDeed();
			}
		}

		[ Constructable ]
		public DestroyedWagonAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3391 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, 1, 3 );
			ac = new AddonComponent( 7604 );
			AddComponent( ac, -5, 0, 0 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -1, 2, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -1, 1, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, 1, 2, 3 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -2, 2, 5 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -2, 1, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -2, 0, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 1, 1, 3 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 6272 );
			AddComponent( ac, -1, 1, 3 );
			ac = new AddonComponent( 7796 );
			ac.Hue = 1854;
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 6325 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 6412 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 3646 );
			ac.Hue = 1622;
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 7606 );
			AddComponent( ac, -6, 1, 0 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2473 );
			AddComponent( ac, -5, 2, 0 );
			ac = new AddonComponent( 6406 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 4651 );
			AddComponent( ac, 2, 1, 2 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 6409 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 7075 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 1993 );
			AddComponent( ac, 2, 0, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 16000 );
			ac.Hue = 1854;
			AddComponent( ac, 1, 2, 3 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, 2, 0, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 1, 2, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, -1, -1, 2 );
			ac = new AddonComponent( 7603 );
			AddComponent( ac, -5, 1, 0 );
			ac = new AddonComponent( 4154 );
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, -2, -1, 2 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, 2, -1, 2 );
			ac = new AddonComponent( 1993 );
			AddComponent( ac, 2, 1, 2 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, -1, 2, 3 );
			ac = new AddonComponent( 7072 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 16001 );
			ac.Hue = 1854;
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 7605 );
			AddComponent( ac, -6, 0, 0 );
			ac = new AddonComponent( 7861 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 7796 );
			ac.Hue = 1854;
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 123420 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 7, 1, 0 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 7, 0, 0 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 5, 0, 0 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 5, 1, 0 );

		}

		public DestroyedWagonAddon( Serial serial ) : base( serial )
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

	public class DestroyedWagonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DestroyedWagonAddon();
			}
		}

		[Constructable]
		public DestroyedWagonAddonDeed()
		{
			Name = "DestroyedWagon";
		}

		public DestroyedWagonAddonDeed( Serial serial ) : base( serial )
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