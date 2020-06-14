using System;
using Server.Items;
using Server.Network;
using Server.Engines.Harvest;
using Server.CustomMining;

namespace Server.Items
{
	//[FlipableAttribute( 0xE86, 0xE85 )]
	public class IndestructablePickaxe : VeinPickaxe//BaseAxe, IHarvestTool
	{
        /*
		public override HarvestSystem HarvestSystem{ get{ return Mining.System; } }

        
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DoubleStrike; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }

		public override int AosStrengthReq{ get{ return 50; } }
		public override int AosMinDamage{ get{ return 13; } }
		public override int AosMaxDamage{ get{ return 15; } }
		public override int AosSpeed{ get{ return 35; } }
		public override float MlSpeed{ get{ return 3.00f; } }

		public override int OldStrengthReq{ get{ return 25; } }
		public override int OldMinDamage{ get{ return 1; } }
		public override int OldMaxDamage{ get{ return 15; } }
		public override int OldSpeed{ get{ return 35; } }

		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Slash1H; } }
        */

		[Constructable]
		public IndestructablePickaxe() : base()
		{
			Weight = 5.0;
            Hue = 1150;
            LootType = LootType.Blessed;
		}

        public IndestructablePickaxe(Serial serial) : base(serial)
		{
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
