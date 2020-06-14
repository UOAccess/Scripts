using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a ratman's corpse" )]
	public class Ikitari : BaseCreature
	{
		[Constructable]
		public Ikitari() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Ikitari";
			Body = 42;
			BaseSoundID = 437;

			SetStr( 42, 54 );
			SetDex( 46, 65 );
			SetInt( 16, 30 );

			SetHits( 137, 142 );
			SetMana( 0 );

			SetDamage( 8, 11 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 27, 32 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 15, 25 );

			SetSkill( SkillName.MagicResist, 32.1, 37.0 );
			SetSkill( SkillName.Tactics, 40.3, 54.0 );
			SetSkill( SkillName.Wrestling, 60.3, 74.0 );

			Fame = 800;
			Karma = -800;

			VirtualArmor = 16;

			PackItem( new RodentBlood() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		public override bool AlwaysMurderer{ get{ return true; } }

		public Ikitari( Serial serial ) : base( serial )
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