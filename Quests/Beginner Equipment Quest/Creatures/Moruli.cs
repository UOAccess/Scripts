using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a skeletal corpse" )]
	public class Moruli : BaseCreature
	{
		[Constructable]
		public Moruli() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Moruli";
			Body = 57;
			BaseSoundID = 451;

			SetStr( 44, 56 );
			SetDex( 47, 66 );
			SetInt( 16, 30 );

			SetHits( 140, 145 );
			SetMana( 0 );

			SetDamage( 10, 13 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 30, 35 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 10, 20 );

			SetSkill( SkillName.MagicResist, 34.1, 39.0 );
			SetSkill( SkillName.Tactics, 44.3, 58.0 );
			SetSkill( SkillName.Wrestling, 64.3, 78.0 );

			Fame = 1000;
			Karma = -1000;

			VirtualArmor = 18;

			PackItem( new GlowingSkull() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		public override bool AlwaysMurderer{ get{ return true; } }

		public Moruli( Serial serial ) : base( serial )
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