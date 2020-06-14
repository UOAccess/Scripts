using System;
using Server;

namespace Server.Items
{
	public class WindStaff : BlackStaff
	{
		public override int ArtifactRarity{ get{ return 1337; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public WindStaff()
		{
			Name = "staff of the four winds";
			Attributes.WeaponDamage = 50;
			WeaponAttributes.HitLeechMana = 100;
			MaxRange = 5;
			Hue = 1150;
			HitSound = 21;
			MissSound = 20;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 8902, 3, 3, false, false );
			defender.FixedParticles( 14120, 10, 30, 5052, EffectLayer.LeftFoot );
			base.OnHit( attacker, defender );
		}

		public WindStaff( Serial serial ) : base( serial )
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