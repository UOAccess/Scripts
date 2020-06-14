using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a venom lord corpse" )]
	public class VenomLord : BaseCreature
	{
		[Constructable]
		public VenomLord () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a venom lord";
			Body = 10;
			BaseSoundID = 357;
			Hue = 1292;

			SetStr( 986, 1185 );
			SetDex( 177, 255 );
			SetInt( 151, 250 );

			SetHits( 1700, 1911 );

			SetDamage( 22, 29 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Fire, 25 );
			SetDamageType( ResistanceType.Energy, 25 );

			SetResistance( ResistanceType.Physical, 77, 80 );
			SetResistance( ResistanceType.Fire, 60, 80 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.Anatomy, 25.1, 50.0 );
			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 95.5, 100.0 );
			SetSkill( SkillName.Necromancy, 120.1, 130.0 );
			SetSkill( SkillName.SpiritSpeak, 120.1, 130.0 );
			SetSkill( SkillName.Meditation, 25.1, 50.0 );
			SetSkill( SkillName.Poisoning, 100.1, 101.0 );
			SetSkill( SkillName.MagicResist, 100.5, 150.0 );
			SetSkill( SkillName.Tactics, 90.1, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );

			Fame = 2400;
			Karma = -2400;

			VirtualArmor = 50;

			PackItem( new Longsword() );
            PackItem(new Kryss());
            PackItem(new RandomTalisman());
		}

		public override void OnDeath( Container c )
        {
		          switch ( Utility.Random( 100 ) ) //Rarity 10
                        { 
				case 0: c.DropItem( new GlassSword() );
			  break;
				case 1: c.DropItem( new Venom() );
                          break;
                case 2: c.DropItem(new ArcticDeathDealer()); break;
                case 3: c.DropItem(new CaptainBloodyRum()); break;
                //case 4: c.DropItem(new PlayersHouseTeleporter()); break;
                case 4: c.DropItem(new HoodedShroudOfShadows()); break;
			 }
                        base.OnDeath( c );
                       }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override Poison HitPoison{ get{ return Poison.Lethal; } }
		public override bool BleedImmune{ get{ return true; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override int Meat{ get{ return 1; } }

		public VenomLord( Serial serial ) : base( serial )
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