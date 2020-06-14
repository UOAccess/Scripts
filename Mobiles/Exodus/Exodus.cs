using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "Exodus' corpse" )]
	public class Exodus : BaseCreature
	{
		public override WeaponAbility GetWeaponAbility()
		{
			return Utility.RandomBool() ? WeaponAbility.MortalStrike : WeaponAbility.BleedAttack;
		}

		[Constructable]
		public Exodus () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Exodus";
			Body = 102;
			BaseSoundID = 357;

			SetStr( 986, 1185 );
			SetDex( 177, 255 );
			SetInt( 151, 250 );

			SetHits( 3000 );

			SetDamage( 42, 49 );

			SetDamageType( ResistanceType.Physical, 20 );
			SetDamageType( ResistanceType.Fire, 45 );
			SetDamageType( ResistanceType.Energy, 35 );

			SetResistance( ResistanceType.Physical, 65, 80 );
			SetResistance( ResistanceType.Fire, 60, 80 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.Anatomy, 105.1, 120.0 );
			SetSkill( SkillName.EvalInt, 105.1, 120.0 );
			SetSkill( SkillName.Magery, 105.5, 120.0 );
			SetSkill( SkillName.Meditation, 105.1, 120.0 );
			SetSkill( SkillName.MagicResist, 100.5, 150.0 );
			SetSkill( SkillName.Tactics, 100.1, 120.0 );
			SetSkill( SkillName.Wrestling, 100.1, 120.0 );

			Fame = 24000;
			Karma = -24000;

			VirtualArmor = 90;

		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 21 );
                         switch ( Utility.Random( 50 ) ) //Rarity 9 
                        { 
                          case 0: PackItem( new ExodusParry( ) ); 
                          break; 
                          case 1: PackItem( new ExodusPillar( ) ); 
                          break; 
                          case 2: PackItem( new ExodusGuise( ) ); 
                          break; 
                          case 3: PackItem( new ExodusValor( ) ); 
                          break; 
                          case 4: PackItem( new ExodusSerenity( ) ); 
                          break; 
                          case 5: PackItem( new ExodusFury( ) ); 
                          break; 
                          case 6: PackItem( new ExodusRedemption( ) ); 
                          break; 
                          case 7: PackItem( new ExodusSigil( ) ); 
                          break; 
			}
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override int TreasureMapLevel{ get{ return 6; } }
		public override bool AutoDispel{ get{ return true; } }
		public override bool BardImmune{ get{ return true; } }


		public Exodus( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}