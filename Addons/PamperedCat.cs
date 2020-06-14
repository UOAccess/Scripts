using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a cat corpse" )]
	public class PamperedCat : BaseCreature
	{
        private DateTime last = DateTime.Now;
        private TimeSpan delay = TimeSpan.FromSeconds(30);

        public DateTime Limit;
        public ArrayList Given;

		[Constructable]
		public PamperedCat() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Pampered Cat";
			Body = 0xC9;
			BaseSoundID = 0x69;

			SetStr( 600, 1000 );
			SetDex( 260, 380 );
			SetInt( 60, 140 );

			SetHits( 400, 600 );
			SetMana( 0 );

			SetDamage( 20, 40 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 50, 100 );

			SetSkill( SkillName.MagicResist, 50.0, 140.0 );
			SetSkill( SkillName.Tactics, 50.1, 100.0 );
			SetSkill( SkillName.Wrestling, 50.1, 100.0 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 90;

			Tamable = true;
			ControlSlots = 1;
			MinTameSkill = 110;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Poor );
		}

		public override int Meat{ get{ return 1; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }

		public PamperedCat( Serial serial ) : base( serial )
		{
		}


             public override void OnThink()
        {
            if ((last + delay) > DateTime.Now)
                return;
            else
                last = DateTime.Now;

            SayRandom();
        }

        public void SayRandom()
        {
            switch (Utility.Random(1, 5))
            {
                case 1:
                    {
                        this.Say("Take me home, please´?");
                        break;
                    }
                case 2:
                    {
                        this.Say("Wasn't me it was the dog.");
                        break;
                    }
                case 3:
                    {
                        this.Say("Cuddle time, gimmie some luvin!");
                        break;
                    }
                case 4:
                    {
                        this.Say("*scratch, scratch, rip, oops, hide*");
                        break;
                    }
                case 5:
                    {
                        this.Say("Purrrrrfect, I love chicken.*");
                        break;
                    }
            }
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