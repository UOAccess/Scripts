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
	public class CaveEntranceFWSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CaveEntranceFWSAddonDeed();
			}
		}

		[ Constructable ]
		public CaveEntranceFWSAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3290 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 8552 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 8553 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2280 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 3294 );
			AddComponent( ac, -1, -3, 5 );
			ac = new AddonComponent( 3291 );
			AddComponent( ac, -1, -3, 5 );
			ac = new AddonComponent( 3224 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 3293 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 3294 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 3236 );
			AddComponent( ac, 0, -1, 22 );
			ac = new AddonComponent( 3259 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2277 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3230 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3259 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 3261 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2274 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 3224 );
			AddComponent( ac, 2, -1, 20 );
			ac = new AddonComponent( 2278 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2279 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2274 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 3230 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 3261 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 3245 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 3237 );
			AddComponent( ac, 3, 1, 0 );

		}

		public CaveEntranceFWSAddon( Serial serial ) : base( serial )
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

	public class CaveEntranceFWSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CaveEntranceFWSAddon();
			}
		}

		[Constructable]
		public CaveEntranceFWSAddonDeed()
		{
			Name = "CaveEntranceFWS";
		}

		public CaveEntranceFWSAddonDeed( Serial serial ) : base( serial )
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