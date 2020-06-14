using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a vile toad's corpse" )]
	public class VileToad : BaseCreature
	{
		[Constructable]
		public VileToad() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Vile Toad";
			Body = 80;
			Hue = 668;
			BaseSoundID = 619;

			SetStr( 37, 49 );
			SetDex( 46, 65 );
			SetInt( 16, 30 );

			SetHits( 130, 135 );
			SetMana( 0 );

			SetDamage( 4, 7 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 25, 30 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Poison, 25, 35 );

			SetSkill( SkillName.MagicResist, 29.1, 34.0 );
			SetSkill( SkillName.Tactics, 33.3, 48.0 );
			SetSkill( SkillName.Wrestling, 53.3, 68.0 );

			Fame = 400;
			Karma = -400;

			VirtualArmor = 12;

			PackItem( new ToadEye() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			
		}

		
		public override bool AlwaysMurderer{ get{ return true; } }

		public VileToad( Serial serial ) : base( serial )
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