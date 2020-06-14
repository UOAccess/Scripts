using System;
using Server;

namespace Server.Items
{
	public class ForkofArms : WarFork
	{
		public override int ArtifactRarity{ get{ return 55; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ForkofArms()
		{
			Name = "Warfork of Arms";
			Attributes.WeaponDamage = 60;
			Attributes.WeaponSpeed = 35;
			WeaponAttributes.HitFireball = 50;
			WeaponAttributes.HitDispel = 52;
			Attributes.AttackChance = 20;
			Attributes.DefendChance = 10;
			Attributes.Luck = 250;
			Attributes.SpellChanneling = 1;
			//MaxRange = 1;
			Hue = 1175;
			HitSound = 0x56;
			MissSound = 0x2A1;
		}

		public virtual void OnHit( Mobile attacker, Mobile defender )
		{
			int roll = Utility.Random( 10 );	

			if ( roll == 1 )
			{
				attacker.MovingEffect( defender, 3922, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 2 )
			{
				attacker.MovingEffect( defender, 5121, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 3 )
			{
				attacker.MovingEffect( defender, 9556, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 4 )
			{
				attacker.MovingEffect( defender, 5123, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 5 )
			{
				attacker.MovingEffect( defender, 3937, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 6 )
			{
				attacker.MovingEffect( defender, 5049, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 7 )
			{
				attacker.MovingEffect( defender, 9560, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 8 )
			{
				attacker.MovingEffect( defender, 9591, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 9 )
			{
				attacker.MovingEffect( defender, 9592, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}

			else if ( roll == 10 )
			{
				attacker.MovingEffect( defender, 9570, 3, 3, false, false );
				base.OnHit( attacker, defender );
			}
		}
		public ForkofArms( Serial serial ) : base( serial )
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