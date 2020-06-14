using System;
using Server;

namespace Server.Items
{
	public class FlameTongue : ExecutionersAxe
	{
		public override int ArtifactRarity{ get{ return 37; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public FlameTongue()
		{
			Name = "FlameTongue";
			Attributes.WeaponDamage = 60;
			WeaponAttributes.HitFireball = 65;
			Attributes.WeaponSpeed = 35;
			Attributes.Luck = 100;
			Attributes.SpellChanneling = 1;
			WeaponAttributes.HitLowerAttack = 54;
			Attributes.BonusStr = 8;
			Attributes.AttackChance = 20;
			MaxRange = 5;
			Hue = 1161;
			HitSound = 351;
			MissSound = 520;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			pois = cold = nrgy = phys = chaos = direct = 0;
			fire = 100;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 14068, 3, 3, false, false );
			defender.FixedParticles( 14089, 10, 30, 5052, EffectLayer.LeftFoot );
			base.OnHit( attacker, defender );
		}
		public FlameTongue( Serial serial ) : base( serial )
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