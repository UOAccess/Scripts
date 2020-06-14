using System;
using Server;

namespace Server.Items
{
	public class WoodBardiche : Bardiche
	{
		public override int ArtifactRarity{ get{ return 100; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public WoodBardiche()
		{
			Name = "Bardiche of the woods";
			Attributes.WeaponDamage = 75;
			WeaponAttributes.HitFireball = 50;
			WeaponAttributes.HitDispel = 52;
			Attributes.AttackChance = 20;
			Attributes.DefendChance = 20;
			Attributes.Luck = 250;
			WeaponAttributes.UseBestSkill = 1;
			Attributes.SpellChanneling = 1;
			MaxRange = 2;
			Hue = 1872;
			HitSound = 553;
			MissSound = 554;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 3329, 3, 3, false, false );
			defender.FixedParticles( 3381, 10, 30, 5052, EffectLayer.LeftFoot );
			base.OnHit( attacker, defender );
		}
		public WoodBardiche( Serial serial ) : base( serial )
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