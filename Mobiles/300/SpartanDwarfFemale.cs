using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "a spartan corpse" )] 
	public class SpartanDwarfFemale : BaseCreature
	{

		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public SpartanDwarfFemale() : base( AIType.AI_Melee, FightMode.Aggressor, 10, 1, 0.2, 0.2 )
		{
			//SpeechHue = Utility.RandomDyedHue();
			Name = "a spartan dwarf";
			//Hue = Utility.RandomSkinHue();

			Body = 0x193;

			SetStr( 86, 100 );
			SetDex( 81, 100 );
			SetInt( 72, 85 );

			SetDamage( 18, 26 );
			
			SetHits ( 100, 152);

			SetSkill( SkillName.Fencing, 95.0, 100.0 );
			SetSkill( SkillName.Swords, 92.0, 100.0 );
			SetSkill( SkillName.Tactics, 90.0, 100.0 );
			SetSkill( SkillName.Wrestling, 94.3, 100.0 );

			SetResistance( ResistanceType.Physical, 70, 80 );
			SetResistance( ResistanceType.Fire, 40, 50 );
			SetResistance( ResistanceType.Cold, 80, 90 );
			SetResistance( ResistanceType.Poison, 50, 60 );
			SetResistance( ResistanceType.Energy, 25, 35 );

			Fame = 22500;
			Karma = -22500;

            /*
			AddItem( new Cloak( 33 ) );
			AddItem( new BoneArms() );
			AddItem( new BoneLegs() );
			AddItem( new PhalanxSpear() );
			AddItem( new BronzeShield() );
			AddItem( new NorseHelm() );
			AddItem( new Sandals() );

			Utility.AssignRandomHair( this );
            */
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.MlRich );
		}

		//public override bool AlwaysMurderer{ get{ return true; } }

		public SpartanDwarfFemale( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}