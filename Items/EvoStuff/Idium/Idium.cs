// Created by Neptune

using System;
using System.Collections;
using Server;
using Server.Items;

namespace Server.Mobiles

{
    [CorpseName(" corpse of Idium")]
    public class Idium : BaseCreature
    {

        [Constructable]
        public Idium() : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.1, 0.2)
        {
            Name = "Idium";
            Hue = 1264;
            Body = 46; // Uncomment these lines and input values
            BaseSoundID = 357; // To use your own custom body and sound.
            SetStr(700, 800);
            SetDex(500, 800);
            SetInt(700, 800);
            SetHits(10000, 15000);
            SetDamage(30, 35);
            SetDamageType(ResistanceType.Cold, 70);
            SetDamageType(ResistanceType.Fire, 70);
            SetDamageType(ResistanceType.Poison, 70);

            SetResistance(ResistanceType.Physical, 65);
            SetResistance(ResistanceType.Cold, 65);
            SetResistance(ResistanceType.Fire, 65);
            SetResistance(ResistanceType.Energy, 65);
            SetResistance(ResistanceType.Poison, 65);

            SetSkill(SkillName.EvalInt, 150.0);
            SetSkill(SkillName.Magery, 150.0);
            SetSkill(SkillName.Meditation, 150.0);
            SetSkill(SkillName.Poisoning, 150.0);
            SetSkill(SkillName.MagicResist, 150.0);
            SetSkill(SkillName.Tactics, 150.0);
            SetSkill(SkillName.Wrestling, 150.0);
            SetSkill(SkillName.Swords, 150.0);
            SetSkill(SkillName.Anatomy, 150.0);
            SetSkill(SkillName.Parry, 150.0);


            Fame = 40000;
            Karma = -45000;
            VirtualArmor = 65;

        }
        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich, 4);
            
        }

        public override void OnKilledBy(Mobile mob)
        {
            PlayerMobile p = mob as PlayerMobile;
            if (p == null || p.Map == Map.Internal || p.Map == null || p.Deleted || p.Blessed)
                return;
            else if (mob is PlayerMobile)
            {
                switch (Utility.Random(75))
                {
                    case 0: p.AddToBackpack(new DragonArmsOfEvolution()); break;
                    case 1: p.AddToBackpack(new DragonChestOfEvolution()); break;
                    case 2: p.AddToBackpack(new DragonGlovesOfEvolution()); break;
                    case 3: p.AddToBackpack(new DragonLegsOfEvolution()); break;
                    case 4: p.AddToBackpack(new OrderShieldOfEvolution()); break;
                    case 5: p.AddToBackpack(new DragonHelmOfEvolution()); break;
                }
                
            }
            base.OnKilledBy(mob);
        }

        public override bool IsScaryToPets { get { return true; } }
        public override bool BardImmune { get { return true; } }
        public override bool Unprovokable { get { return true; } }
        public override bool AlwaysMurderer { get { return true; } }
        
        public Idium(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

        }

    }
}

