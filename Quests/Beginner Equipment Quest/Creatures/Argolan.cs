using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "an orcish lord's corpse" )]
	public class Argolan : BaseCreature
	{
		[Constructable]
		public Argolan() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Argolan";
			Body = 138;
			BaseSoundID = 1114;

			SetStr( 48, 60 );
			SetDex( 50, 68 );
			SetInt( 16, 30 );

			SetHits( 142, 147 );
			SetMana( 0 );

			SetDamage( 11, 14 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 30, 35 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 10, 20 );

			SetSkill( SkillName.MagicResist, 37.1, 42.0 );
			SetSkill( SkillName.Tactics, 46.3, 60.0 );
			SetSkill( SkillName.Wrestling, 66.3, 80.0 );

			Fame = 1100;
			Karma = -1100;

			VirtualArmor = 19;
		
			PackItem( new MagicOrcHelm() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		public override bool AlwaysMurderer{ get{ return true; } }

		public Argolan( Serial serial ) : base( serial )
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