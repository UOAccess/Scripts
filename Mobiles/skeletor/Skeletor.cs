using System;
using System.Collections;
using Server.Misc;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "The Corpse Of Skeletor" )]
	public class Skeletor : BaseCreature
	{
		public override InhumanSpeech SpeechType{ get{ return InhumanSpeech.Orc; } }

		[Constructable]
		public Skeletor() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
		
		Name = "Skeletor";
		Hue = 1153;
		Body = 308; 

		SetStr( 120 );
		SetDex( 600 );
		SetInt( 400 );

		SetHits( 3000 );
		SetDamage( 20, 30 );

		SetDamageType( ResistanceType.Physical, 100 );
		SetDamageType( ResistanceType.Cold, 0 );
		SetDamageType( ResistanceType.Fire, 100 );
		SetDamageType( ResistanceType.Energy, 0 );
		SetDamageType( ResistanceType.Poison, 100 );

		SetResistance( ResistanceType.Physical, 80 );
		SetResistance( ResistanceType.Cold, 0 );
		SetResistance( ResistanceType.Fire, 90 );
		SetResistance( ResistanceType.Energy, 0 );
		SetResistance( ResistanceType.Poison, 100 );

                 Fame = -20000;
                 Karma = -20000;

                 VirtualArmor = 5;
     
                        PackGold( 500, 1000 );
			
			if ( Utility.RandomDouble() <= 0.08 )
			PackItem( new skeletorBlade(1) );

			
			switch ( Utility.Random( 7 ) )
			{
				case 0: PackItem( new Arrow() ); break;
				case 1: PackItem( new Lockpick() ); break;
				case 2: PackItem( new Shaft() ); break;
				case 3: PackItem( new Ribs() ); break;
				case 4: PackItem( new Bandage() ); break;
				case 5: PackItem( new BeverageBottle( BeverageType.Wine ) ); break;
				case 6: PackItem( new Jug( BeverageType.Cider ) ); break;
			}

			if ( Core.AOS )
				PackItem( Loot.RandomNecromancyReagent() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich, 2 );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
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

		public Skeletor( Serial serial ) : base( serial )
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