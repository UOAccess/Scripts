using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "an enraged bear's corpse" )]
	public class EnragedBear : BaseCreature
	{
		[Constructable]
		public EnragedBear() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Enraged Bear";
			Body = 212;
			Hue = 538;
			BaseSoundID = 163;

			SetStr( 40, 52 );
			SetDex( 46, 65 );
			SetInt( 16, 30 );

			SetHits( 134, 139 );
			SetMana( 0 );

			SetDamage( 6, 9 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 25, 30 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 25, 35 );

			SetSkill( SkillName.MagicResist, 30.1, 35.0 );
			SetSkill( SkillName.Tactics, 36.3, 50.0 );
			SetSkill( SkillName.Wrestling, 56.3, 70.0 );

			Fame = 600;
			Karma = -600;

			VirtualArmor = 14;

			PackItem( new BearFur() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		public override bool AlwaysMurderer{ get{ return true; } }

		public EnragedBear( Serial serial ) : base( serial )
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