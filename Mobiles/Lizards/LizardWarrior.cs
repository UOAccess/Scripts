using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a lizardman corpse" )]
	public class LizardWarrior : BaseCreature
	{
		[Constructable]
		public LizardWarrior() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "lizardman" );
			Body = Utility.RandomList( 35, 36 );
			BaseSoundID = 417;
			Hue = 636;

			SetStr( 120, 220 );
			SetDex( 186, 205 );
			SetInt( 136, 160 );

			SetHits( 258, 372 );

			SetDamage( 25, 27 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 30, 35 );
			SetResistance( ResistanceType.Fire, 25, 30 );
			SetResistance( ResistanceType.Cold, 25, 30 );
			SetResistance( ResistanceType.Poison, 30, 40 );

			SetSkill( SkillName.MagicResist, 60.0, 75.1 );
			SetSkill( SkillName.Tactics, 75.1, 99.0 );
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 58;

			PackGold( 1225, 1250 );
		}
		public override int Meat{ get{ return 2; } }
		public override int Hides{ get{ return 25; } }
		public override HideType HideType{ get{ return HideType.Spined; } }

		public LizardWarrior( Serial serial ) : base( serial )
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