using System;
using Server;
using Server.Items;
				
namespace Server.Mobiles
{
	[CorpseName( "Corpse Of An Evo Guardian" )]
	public class EvoArmorGuardian : BaseCreature
	{
		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public EvoArmorGuardian() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Evo Guardian";
			Body = 311;
			Hue = 0;
            BaseSoundID = 1072;
				 
			SetStr( 700, 700 );
			SetDex( 600, 600 );
			SetInt( 400, 450 );
				 
			SetHits( 6500, 8000 );
				 
			SetDamage( 20, 25 );
				 
			SetDamageType( ResistanceType.Physical, 45 );
			SetDamageType( ResistanceType.Cold, 45 );
			SetDamageType( ResistanceType.Fire, 45 );
				 
			SetResistance( ResistanceType.Physical, 50, 60 );
			SetResistance( ResistanceType.Energy, 50, 60 );
			SetResistance( ResistanceType.Poison, 50, 60 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Fire, 50, 60 );
				 
			SetSkill( SkillName.Wrestling, 95.1, 100.0 );
			SetSkill( SkillName.Anatomy, 95.1, 100.0 );
			SetSkill( SkillName.MagicResist, 95.1, 100.0 );
			SetSkill( SkillName.Swords, 95.1, 100.0 );
			SetSkill( SkillName.Tactics, 95.1, 100.0 );
			SetSkill( SkillName.Parry, 95.1, 100.0 );
			SetSkill( SkillName.Focus, 95.1, 100.0 );
				 
			Fame = 25000;
			Karma = -25000;
				 
			VirtualArmor = 60;
                  
            //PackGold( 8000, 10000 );
	
		}
			
		public override bool AlwaysAttackable{ get{ return true; } }
 
		public override void GenerateLoot()
		{
			 AddLoot( LootPack.Rich, 2 );
            
        }

        public override void OnKilledBy(Mobile mob)
        {
            PlayerMobile p = mob as PlayerMobile;
            if (p == null || p.Map == Map.Internal || p.Map == null || p.Deleted || p.Blessed)
                return;
            else if (mob is PlayerMobile)
            {
                switch (Utility.Random(50))
                {
                    case 0: p.AddToBackpack(new armsofevolution()); break;
                    case 1: p.AddToBackpack(new chestofevolution()); break;
                    case 2: p.AddToBackpack(new glovesofevolution()); break;
                    case 3: p.AddToBackpack(new helmofevolution()); break;
                    case 4: p.AddToBackpack(new legsofevolution()); break;
                    case 5: p.AddToBackpack(new femalechestofevolution()); break;
                    case 6: p.AddToBackpack(new gorgetofevolution()); break;
                }

            }
            base.OnKilledBy(mob);
        }

        public EvoArmorGuardian( Serial serial ) : base( serial )
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
