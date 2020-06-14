using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Factions;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using Server.ContextMenus;

namespace Server.Mobiles
{
	[CorpseName( "a ReaperMans corpse" )]
	public class  ReaperMan : BaseCreature
	{

		[Constructable]
		public ReaperMan () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "The Reaper Guy";
            Title = "Of B&T's Most Excelent Adventure";
			Body = 400;
            Hue = 1153;

            SetStr(380);
            SetDex(110);
            SetInt(100);

            //SetHits( 800, 1200 );
            SetDamage(12, 25);

            SetDamageType(ResistanceType.Physical, 110);

            SetSkill(SkillName.MagicResist, 100.0);
            SetSkill(SkillName.Tactics, 87.0);
            SetSkill(SkillName.Wrestling, 40.0);
            SetSkill(SkillName.DetectHidden, 60);

            SetResistance(ResistanceType.Physical, 50, 60);
            SetResistance(ResistanceType.Fire, 44, 50);
            SetResistance(ResistanceType.Cold, 35, 40);
            SetResistance(ResistanceType.Poison, 25, 30);
            SetResistance(ResistanceType.Energy, 15, 20);

            Fame = 240000;
            Karma = -240000;

            VirtualArmor = 90;

            PackItem(new HellKey());

            AddItem(new HoodedShroudOfShadows(0x1));
          


            Item staff = new Scythe
                ();
            staff.Movable = false;
            AddItem(staff);	
			
        }
        public ReaperMan(Serial serial)
            : base(serial)
        {
        }
        public override bool AlwaysMurderer { get { return true; } }
    
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