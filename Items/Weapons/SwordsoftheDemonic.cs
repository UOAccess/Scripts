using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x27A9, 0x27F4 )]
	public class SwordsoftheDemonic : BaseSword
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Feint; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.DoubleStrike; } }

		public override int AosStrengthReq{ get{ return 40; } }
		public override int AosMinDamage{ get{ return 13; } }
		public override int AosMaxDamage{ get{ return 15; } }
		public override int AosSpeed{ get{ return 40; } }
		public override float MlSpeed{ get{ return 2.75f; } }

		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldMinDamage{ get{ return 13; } }
		public override int OldMaxDamage{ get{ return 15; } }
		public override int OldSpeed{ get{ return 40; } }

		public override int DefHitSound{ get{ return 0x23B; } }
		public override int DefMissSound{ get{ return 0x23A; } }

		public override int InitMinHits{ get{ return 45; } }
		public override int InitMaxHits{ get{ return 65; } }

		[Constructable]
		public SwordsoftheDemonic() : base( 0x27A9 )
		{
			Weight = 8.0;
			Hue = 1;
			Name = "Swords of the Demonic";
            Attributes.SpellChanneling = Utility.Random(0, 1);
            Attributes.WeaponDamage = Utility.Random(0, 50);
            Attributes.WeaponSpeed = Utility.Random(0, 30);
			Attributes.AttackChance = 15;
            WeaponAttributes.HitLowerAttack = Utility.Random(0, 30);
            WeaponAttributes.HitFireball = Utility.Random(0, 50);
            WeaponAttributes.HitLightning = Utility.Random(0, 70);
			WeaponAttributes.HitHarm = 50;
			Layer = Layer.TwoHanded;
		}

		public SwordsoftheDemonic( Serial serial ) : base( serial )
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