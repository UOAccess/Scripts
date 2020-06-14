using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "an ostard corpse" )]
	public class AncientOstard : BaseMount
	{
		[Constructable]
		public AncientOstard() : this( "a ancient ostard" )
		{
		}

		[Constructable]
		public AncientOstard( string name ) : base( name, 0xDB, 0x3EA5, AIType.AI_Mage, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Hue =
Utility.RandomSlimeHue() | 0x8000;

			BaseSoundID = 0x270;

			SetStr( 500, 800 );
			SetDex( 300, 400 );
			SetInt( 500, 1800 );

			SetHits( 10000, 15000 );
			SetMana( 1500, 32000);

			SetDamage( 55, 65 );

			SetDamageType( 
ResistanceType.Physical, 65, 80 );
			SetDamageType( ResistanceType.Fire, 65, 80 );
			SetDamageType( ResistanceType.Energy, 65, 80 );

			SetResistance( ResistanceType.Physical, 75, 95 );
			SetResistance( ResistanceType.Fire, 65, 80 );
			SetResistance( ResistanceType.Cold, 65, 80 );
			SetResistance( ResistanceType.Poison, 65, 80);
			SetResistance( ResistanceType.Energy, 65, 80 ); 

			SetSkill( SkillName.MagicResist, 115.1, 200.0 );
			SetSkill( SkillName.Tactics, 115.3, 200.0 );
			SetSkill( SkillName.Wrestling, 115.3, 199.0 );
                                                SetSkill(  
SkillName.Magery, 115,200 );
                                                 SetSkill(   
SkillName.Meditation, 115.3, 200.0 );
                                                 SetSkill(
SkillName.EvalInt, 115.3, 200.0 );
			Fame = 450;
			Karma = 0;

			Tamable = true;
			ControlSlots = 2;
			MinTameSkill = 100.1;
		}

		public override int Meat{ get{ return 3; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies | FoodType.GrainsAndHay; } }
		public override PackInstinct PackInstinct{ get{ return PackInstinct.Ostard; } }

		public AncientOstard( Serial serial ) : base( serial )
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