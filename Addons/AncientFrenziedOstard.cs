using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "an ostard corpse" )]
	public class AncientFrenziedOstard : BaseMount
	{
		[Constructable]
		public AncientFrenziedOstard() : this( "an ancient frenzied ostard" )
		{
		}

		[Constructable]
		public AncientFrenziedOstard( string name ) : base( name, 0xDA, 0x3EA4, AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Hue = Utility.RandomHairHue() | 0x8000;

			BaseSoundID = 0x275;

			SetStr( 450, 500 );
			SetDex( 250, 300 );
			SetInt( 450, 500 );

			SetHits( 12000, 15000 );
			SetMana( 450, 500 );

			SetDamage( 35, 40 );

			SetDamageType( ResistanceType.Physical, 100 );
            SetDamageType( ResistanceType.Energy, 100 );
            
			SetResistance( ResistanceType.Physical, 65, 70 );
			SetResistance( ResistanceType.Fire, 40, 45 );
			SetResistance( ResistanceType.Poison, 50, 55 );
			SetResistance( ResistanceType.Energy, 40, 45 );

			SetSkill( SkillName.MagicResist, 105.1, 110.0 );
			SetSkill( SkillName.Tactics, 109.3, 114.0 );
			SetSkill( SkillName.Wrestling, 110.3, 115.0 );
            SetSkill( SkillName.Magery, 115.3, 120.0 ); 
            SetSkill( SkillName.Meditation, 115.3, 120.0 ); 
            SetSkill( SkillName.EvalInt, 114.3, 119.3 ); 
            SetSkill( SkillName.Anatomy, 110.3, 115.3 );
            SetSkill( SkillName.Healing, 111.3, 115.3 );
			Fame = 1500;
			Karma = 1500;

			Tamable = true;
			ControlSlots = 2;
			MinTameSkill = 109.1;
		}

		public override int Meat{ get{ return 3; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat | FoodType.Fish | FoodType.Eggs | FoodType.FruitsAndVegies; } }
		public override PackInstinct PackInstinct{ get{ return PackInstinct.Ostard; } }

		public AncientFrenziedOstard( Serial serial ) : base( serial )
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
