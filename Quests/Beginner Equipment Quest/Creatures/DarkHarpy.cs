using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a dark harpy's corpse" )]
	public class DarkHarpy : BaseCreature
	{
		[Constructable]
		public DarkHarpy() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Dark Harpy";
			Body = 30;
			Hue = 952;
			BaseSoundID = 402;

			SetStr( 40, 52 );
			SetDex( 46, 65 );
			SetInt( 16, 30 );

			SetHits( 135, 140 );
			SetMana( 0 );

			SetDamage( 7, 10 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 25, 30 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 25, 35 );

			SetSkill( SkillName.MagicResist, 30.1, 35.0 );
			SetSkill( SkillName.Tactics, 38.3, 52.0 );
			SetSkill( SkillName.Wrestling, 58.3, 72.0 );

			Fame = 700;
			Karma = -700;

			VirtualArmor = 15;
			
			PackItem( new DarkFeather() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		public override bool AlwaysMurderer{ get{ return true; } }

		public DarkHarpy( Serial serial ) : base( serial )
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