using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a sick rat's corpse" )]
	public class DiseasedRat : BaseCreature
	{
		[Constructable]
		public DiseasedRat() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Diseased Rat";
			Body = 215;
			BaseSoundID = 392;
			Hue = 903;

			SetStr( 32, 44 );
			SetDex( 46, 65 );
			SetInt( 16, 30 );

			SetHits( 125, 130 );
			SetMana( 0 );

			SetDamage( 2, 5 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 18, 23 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 25, 35 );

			SetSkill( SkillName.MagicResist, 25.1, 30.0 );
			SetSkill( SkillName.Tactics, 29.3, 44.0 );
			SetSkill( SkillName.Wrestling, 49.3, 64.0 );

			Fame = 200;
			Karma = -200;

			VirtualArmor = 10;

			PackItem( new DiseasedRatMeat() );

			}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		public override bool AlwaysMurderer{ get{ return true; } }

		public DiseasedRat(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}