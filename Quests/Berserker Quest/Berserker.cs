using System;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Berserker corpse" )]
	public class Berserker : BaseCreature
	{
		public override bool ClickTitle{ get{ return false; } }
		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public Berserker() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Title = ", the Berserker";

			Hue = 0;
			BaseSoundID = 357;

			if ( this.Female = Utility.RandomBool() )
			{
				Body = 0x191;
				Name = NameList.RandomName( "female" );
			}
			else
			{
				Body = 0x190;
				Name = NameList.RandomName( "male" );
			}

			SetStr( 476, 505 );
			SetDex( 76, 95 );
			SetInt( 11, 25 );

			SetHits( 386, 403 );

			SetDamage( 6, 12 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 60 );
			SetResistance( ResistanceType.Fire, 50, 60 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.Fencing, 166.0, 197.5 );
			SetSkill( SkillName.Macing, 165.0, 187.5 );
			SetSkill( SkillName.MagicResist, 125.0, 147.5 );
			SetSkill( SkillName.Swords, 165.0, 187.5 );
			SetSkill( SkillName.Tactics, 165.0, 187.5 );
			SetSkill( SkillName.Wrestling, 115.0, 137.5 );

			Fame = 1000;
			Karma = -1000;

			AddItem( new Sandals( Utility.RandomNeutralHue() ) );
			AddItem( new DeerMask() );
			AddItem( new BoneGloves() );

			PackItem( new Gold( 1000, 2500 ) );
			PackItem( new BloodyBerserkerSkull() );

			//if ( 0.5 > Utility.RandomDouble() )
				//PackItem( new AnkhGloves() );

			switch ( Utility.Random( 7 ))
			{
				case 0: AddItem( new Longsword() ); break;
				case 1: AddItem( new Cutlass() ); break;
				case 2: AddItem( new Broadsword() ); break;
				case 3: AddItem( new Axe() ); break;
				case 4: AddItem( new Club() ); break;
				case 5: AddItem( new Dagger() ); break;
				case 6: AddItem( new Spear() ); break;
			}

			Utility.AssignRandomHair( this );

		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.Average, 2 );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Regular; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override int Meat{ get{ return 1; } }

		public Berserker( Serial serial ) : base( serial )
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