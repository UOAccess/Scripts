using System;
using Server;

namespace Server.Items
{
	public class DeathScythe : Scythe
	{
		public override int ArtifactRarity{ get{ return 666; } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override float MlSpeed{ get{ return 3.50f; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public DeathScythe()
		{
			Name = "Essence of Death";
			Attributes.WeaponDamage = 70;
			WeaponAttributes.HitLeechHits = 60;
			Attributes.AttackChance = 20;
			Attributes.BonusStr = 10;
			Attributes.Luck = 250;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponSpeed = 45;
			MaxRange = 5;
			Hue = 1157;
			HitSound = 505;
			MissSound = 481;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 8707, 3, 3, false, false );
			defender.FixedParticles( 8700, 10, 30, 5052, EffectLayer.LeftFoot );
			defender.FixedParticles( 6942, 10, 30, 5052, EffectLayer.RightFoot );
			base.OnHit( attacker, defender );
		}

		public DeathScythe( Serial serial ) : base( serial )
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