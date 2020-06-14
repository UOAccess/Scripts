using System;
using Server;

namespace Server.Items
{
	public class StoneAxe : DoubleAxe
	{
		public override int ArtifactRarity{ get{ return 1337; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public StoneAxe()
		{
			Name = "Stone Axe";
			Attributes.WeaponDamage = 150;
			MaxRange = 5;
			Hue = 1807;
			HitSound = 502;
			MissSound = 755;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			attacker.MovingEffect( defender, 6002, 3, 3, false, false );
			defender.FixedParticles( 4534, 10, 30, 5052, EffectLayer.LeftFoot );
			base.OnHit( attacker, defender );
		}
		public StoneAxe( Serial serial ) : base( serial )
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