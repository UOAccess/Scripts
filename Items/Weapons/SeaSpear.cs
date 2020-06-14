using System;
using Server;

namespace Server.Items
{
	public class SeaSpear : ShortSpear
	{
		public override int ArtifactRarity{ get{ return 1337; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public SeaSpear()
		{
			Name = "Spear of the Sea";
			Attributes.WeaponDamage = 50;
			WeaponAttributes.UseBestSkill = 1;
			MaxRange = 5;
			Hue = 1176;
			HitSound = 279;
			MissSound = 17;
			WeaponAttributes.HitHarm = 100;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 5369, 3, 3, false, false );
			defender.FixedParticles( 8383, 10, 30, 5052, EffectLayer.LeftFoot );
			base.OnHit( attacker, defender );
		}
		public SeaSpear( Serial serial ) : base( serial )
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