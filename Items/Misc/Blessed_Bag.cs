using System;
using System.Collections;
using Server.Multis;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{

public class BlessedBag : BaseContainer, IDyable
	{
		public override int DefaultGumpID{ get{ return 0x3D; } }
		public override int DefaultDropSound{ get{ return 0x48; } }

		public override Rectangle2D Bounds
		{
			get{ return new Rectangle2D( 29, 34, 108, 94 ); }
		}

		[Constructable]
		public BlessedBag() : base( 0xE76 )
		{
			Weight = 1.0;
                        Name = "Blessed Bag";
                        Hue = 1366;
                        LootType = LootType.Blessed;
		}

		public BlessedBag( Serial serial ) : base( serial )
		{
		}

		public bool Dye( Mobile from, DyeTub sender )
		{
			if ( Deleted ) return false;

			Hue = sender.DyedHue;

			return true;
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
   }