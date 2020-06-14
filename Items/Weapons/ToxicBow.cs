using System;
using Server;

using System.Collections;
using Server.Network;
using Server.Items;
using Server.Mobiles;

using System.Linq;
using VitaNex.FX;

namespace Server.Items
{
	public class ToxicBow : Katana
	{
		public override int ArtifactRarity{ get{ return 25; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorPierce; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.DoubleShot; } }

		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.ShootBow; } }

		[Constructable]
		public ToxicBow()
		{
			Name = "Toxic Bow";
			ItemID = 10149;
			Attributes.WeaponDamage = 60;
			WeaponAttributes.HitLeechStam = 58;
			WeaponAttributes.SelfRepair = 10;
			Attributes.BonusDex = 10;
			Attributes.WeaponSpeed = 35;
			Attributes.SpellChanneling = 1;
			Attributes.Luck = 250;
			MaxRange = 15;
			Hue = 1372;
			HitSound = 1140;
			MissSound = 517;
			WeaponAttributes.HitHarm = 60;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
            new FireExplodeEffect(attacker, attacker.Map, 5, effectHandler: ExplosionDamage).Send();
            attacker.MovingEffect( defender, 4410, 3, 3, false, false );
			base.OnHit( attacker, defender );
		}

        public virtual void ExplosionDamage( EffectInfo info )
        {
            ArrayList list = new ArrayList();
            Effects.PlaySound(info.Source.Location, info.Map, 777);
        }

        public ToxicBow( Serial serial ) : base( serial )
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
