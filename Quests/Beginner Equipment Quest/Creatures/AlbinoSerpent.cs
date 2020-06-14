using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a white serpent's corpse" )]
	public class AlbinoSerpent : BaseCreature
	{
		[Constructable]
		public AlbinoSerpent() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Albino Serpent";
			Body = 21;
			Hue = 1153;
			BaseSoundID = 219;

			SetStr( 38, 50 );
			SetDex( 46, 65 );
			SetInt( 16, 30 );

			SetHits( 132, 137 );
			SetMana( 0 );

			SetDamage( 5, 8 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 25, 30 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 25, 35 );

			SetSkill( SkillName.MagicResist, 30.1, 35.0 );
			SetSkill( SkillName.Tactics, 34.3, 49.0 );
			SetSkill( SkillName.Wrestling, 54.3, 69.0 );

			Fame = 500;
			Karma = -500;

			VirtualArmor = 13;

			PackItem( new WhiteSnakeEgg() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		public override bool AlwaysMurderer{ get{ return true; } }

		public AlbinoSerpent( Serial serial ) : base( serial )
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