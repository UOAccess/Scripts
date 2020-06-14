using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a savage's corpse" )]
	public class Grianthiam : BaseCreature
	{
		[Constructable]
		public Grianthiam() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Grianthiam";
			Body = 185;
			BaseSoundID = 0;

			SetStr( 50, 62 );
			SetDex( 52, 70 );
			SetInt( 16, 30 );

			SetHits( 165, 185 );
			SetMana( 0 );

			SetDamage( 12, 15 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 35, 40 );
			SetResistance( ResistanceType.Fire, 15, 20 );
			SetResistance( ResistanceType.Poison, 10, 25 );

			SetSkill( SkillName.MagicResist, 40.1, 45.0 );
			SetSkill( SkillName.Tactics, 50.3, 65.0 );
			SetSkill( SkillName.Wrestling, 70.3, 85.0 );

			Fame = 1200;
			Karma = -1200;

			VirtualArmor = 20;

			PackItem( new SavageHead() );
			PackItem( new TreasureMap( 0, Map.Trammel ) );
		
			EtherealHorse mare = new EtherealHorse();
			mare.Rider = this;

		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		
		public override bool AlwaysMurderer{ get{ return true; } }

		public Grianthiam( Serial serial ) : base( serial )
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