using System;
using Server;
using Server.Items;
				
namespace Server.Mobiles
{
	[CorpseName( "Corpse of the Soul Guardian" )]
	public class SoulGuardian : BaseCreature
	{
		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public SoulGuardian() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Soul Guardian";
			Body = 311;
			Hue = 0;
            BaseSoundID = 1072;
				 
			SetStr( 500, 500 );
			SetDex( 400, 400 );
			SetInt( 200, 250 );
				 
			SetHits( 3500, 5000 );
				 
			SetDamage( 15, 25 );
				 
			SetDamageType( ResistanceType.Physical, 35 );
			SetDamageType( ResistanceType.Cold, 35 );
			SetDamageType( ResistanceType.Fire, 35 );
				 
			SetResistance( ResistanceType.Physical, 40, 50 );
			SetResistance( ResistanceType.Energy, 40, 50 );
			SetResistance( ResistanceType.Poison, 40, 50 );
			SetResistance( ResistanceType.Cold, 40, 50 );
			SetResistance( ResistanceType.Fire, 40, 50 );
				 
			SetSkill( SkillName.Wrestling, 95.1, 100.0 );
			SetSkill( SkillName.Anatomy, 95.1, 100.0 );
			SetSkill( SkillName.MagicResist, 95.1, 100.0 );
			SetSkill( SkillName.Swords, 95.1, 100.0 );
			SetSkill( SkillName.Tactics, 95.1, 100.0 );
			SetSkill( SkillName.Parry, 95.1, 100.0 );
			SetSkill( SkillName.Focus, 95.1, 100.0 );
				 
			Fame = 15000;
			Karma = -20000;
				 
			VirtualArmor = 40;
                  
			//PackGold( 5000, 6000 );
	
		}
			
		public override bool AlwaysAttackable{ get{ return true; } }
 
		public override void GenerateLoot()
		{
			 AddLoot( LootPack.Rich, 1 );
        }
        public override void OnKilledBy(Mobile mob)
        {
            PlayerMobile p = mob as PlayerMobile;
            if (p == null || p.Map == Map.Internal || p.Map == null || p.Deleted || p.Blessed)
                return;
            else if (mob is PlayerMobile)
            {
                switch (Utility.Random(30))
                {
                    case 0: p.AddToBackpack(new SoulChest()); break;
                    case 1: p.AddToBackpack(new SoulLegs()); break;
                    case 2: p.AddToBackpack(new SoulArms()); break;
                    case 3: p.AddToBackpack(new SoulHelmet()); break;
                    case 4: p.AddToBackpack(new SoulGorget()); break;
                    case 5: p.AddToBackpack(new SoulGloves()); break;
                    case 6: p.AddToBackpack(new SoulShield()); break;
                    case 7: p.AddToBackpack(new SoulBow()); break;
                    case 8: p.AddToBackpack(new SoulSword()); break;
                    case 9: p.AddToBackpack(new SoulShroud()); break;
                }
            }
            base.OnKilledBy(mob);
        }

        public SoulGuardian( Serial serial ) : base( serial )
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
