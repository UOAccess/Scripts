using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a goblin corpse" )]
	public class GoblinRaider : BaseCreature
	{

		public override InhumanSpeech SpeechType{ get{ return InhumanSpeech.Orc; } }

		[Constructable]
		public GoblinRaider() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "orc" );
			Title = "the Goblin Raider";
			Body = 400;
			BaseSoundID = 0x45A;
			Hue = 0x359;

			SetStr( 76, 100 );
			SetDex( 59, 105 );
			SetInt( 36, 60 );

			SetHits( 50, 90);

			SetDamage( 3, 5 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 20, 30 );
			SetResistance( ResistanceType.Poison, 10, 20 );
			SetResistance( ResistanceType.Energy, 10, 20 );

			SetSkill( SkillName.Tactics, 30.1, 60.0 );
			SetSkill( SkillName.Wrestling, 60.0, 80.0 );

			Fame = 1500;
			Karma = -1500;

			VirtualArmor = 28;

			AddItem( new LeatherChest() );
			AddItem( new LeatherLegs() );
			AddItem( new Boots() );
			AddItem( new Mohawk( Utility.RandomHairHue() ) );
			PackItem( new Gold( 750, 1000 ) );
			switch ( Utility.Random( 6 ) )
			{
				case 0: AddItem( new Scimitar() ); break;
				case 1: AddItem( new Katana() ); break;
				case 2: AddItem( new Broadsword() ); break;
				case 3: AddItem( new Longsword() ); break;
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

		public GoblinRaider( Serial serial ) : base( serial )
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
