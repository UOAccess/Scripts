using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a blood bat's corpse" )]
	public class BloodBat : BaseCreature
	{
		[Constructable]
		public BloodBat() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Blood Bat";
			Body = 317;
			Hue = 38;
			BaseSoundID = 0x270;

			SetStr( 35, 47 );
			SetDex( 46, 65 );
			SetInt( 16, 30 );

			SetHits( 128, 133 );
			SetMana( 0 );

			SetDamage( 3, 6 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 20, 25 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 25, 35 );

			SetSkill( SkillName.MagicResist, 27.1, 32.0 );
			SetSkill( SkillName.Tactics, 31.3, 46.0 );
			SetSkill( SkillName.Wrestling, 51.3, 66.0 );

			Fame = 300;
			Karma = -300;

			VirtualArmor = 11;

			PackItem( new BloodyBatWing() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		public override int GetIdleSound()
		{
			return 0x29B;
		}

		public override bool AlwaysMurderer{ get{ return true; } }

		public BloodBat( Serial serial ) : base( serial )
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