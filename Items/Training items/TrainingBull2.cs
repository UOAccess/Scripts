using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a training bull corpse" )]
	public class TrainingBull : BaseCreature
	{
		[Constructable]
        public TrainingBull()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
		{
			Name = "a training bull";
			Body = 0xE9;
			//BaseSoundID = 0x64;
            Hue = 312;
            CantWalk = true;

			SetStr( 77, 111 );
			SetDex( 56, 75 );
			SetInt( 47, 75 );

			Blessed = false;
            HitsMaxSeed = 7500;
			Hits = 7500;
			
			SetMana( 0 );

			SetDamage( 2, 2 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 50, 60 );
			SetResistance( ResistanceType.Cold, 50, 60 );

			SetSkill( SkillName.MagicResist, 10, 25 );
			SetSkill( SkillName.Tactics, 10, 25 );
			SetSkill( SkillName.Wrestling, 10, 25 );

			Fame = 600;
			Karma = 0;

			VirtualArmor = 100;

			Tamable = false;

						
		}
        public override void OnHitsChange(int oldValue)
        {
            if (Hits != 7500)
            {
                Hits = 7500;
            }
            base.OnHitsChange(oldValue);
        }
        

		public TrainingBull(Serial serial) : base(serial)
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
