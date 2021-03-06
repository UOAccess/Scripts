using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a goblin corpse" )]
	public class GoblinElite : BaseCreature
	{
		public override InhumanSpeech SpeechType{ get{ return InhumanSpeech.Orc; } }

		[Constructable]
		public GoblinElite() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "orc" );
			Title = "the Goblin Elite";
			Body = 400;
			BaseSoundID = 0x45A;
			Hue = 0x359;

			SetStr( 90, 110 );
			SetDex( 59, 105 );
			SetInt( 36, 60 );

			SetHits( 90, 130);

			SetDamage( 10, 15 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 20, 30 );
			SetResistance( ResistanceType.Poison, 10, 20 );
			SetResistance( ResistanceType.Energy, 10, 20 );

			SetSkill( SkillName.Tactics, 50.0, 80.0 );
			SetSkill( SkillName.Swords, 80.0, 100.0 );

			Fame = 1500;
			Karma = -1500;

			VirtualArmor = 28;

			AddItem( new RingmailChest() );
			AddItem( new RingmailLegs() );
			AddItem( new RingmailGloves() );
			AddItem( new Boots() );
			//AddItem( new Mohawk( Utility.RandomHairHue() ) );
			PackItem( new Gold( 1000, 1500 ) );
			switch ( Utility.Random( 6 ) )
			{
				case 0: AddItem( new Scimitar() ); AddItem( new HeaterShield() ); break;
				case 1: AddItem( new Katana() ); AddItem( new HeaterShield() ); break;
				case 2: AddItem( new Broadsword() ); AddItem( new HeaterShield() ); break;
				case 3: AddItem( new Longsword() ); AddItem( new HeaterShield() ); break;
				case 4: AddItem( new Bardiche() ); break;
				case 5: AddItem( new Halberd() ); break;
			}

			switch ( Utility.Random( 3 ) )
			{
				case 0: PackItem( new Ribs() ); break;
				case 1: PackItem( new Shaft() ); break;
				case 2: PackItem( new Candle() ); break;
			}

		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Meager );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override int TreasureMapLevel{ get{ return 1; } }
		public override int Meat{ get{ return 1; } }

		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.SavagesAndOrcs; }
		}

		public override bool IsEnemy( Mobile m )
		{
			if ( m.Player && m.FindItemOnLayer( Layer.Helm ) is OrcishKinMask )
				return false;

			return base.IsEnemy( m );
		}

		public override void AggressiveAction( Mobile aggressor, bool criminal )
		{
			base.AggressiveAction( aggressor, criminal );

			Item item = aggressor.FindItemOnLayer( Layer.Helm );

			if ( item is OrcishKinMask )
			{
				AOS.Damage( aggressor, 50, 0, 100, 0, 0, 0 );
				item.Delete();
				aggressor.FixedParticles( 0x36BD, 20, 10, 5044, EffectLayer.Head );
				aggressor.PlaySound( 0x307 );
			}
		}

		public GoblinElite( Serial serial ) : base( serial )
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
