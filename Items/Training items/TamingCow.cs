using System;
using Server.Items;
using System.Collections;
using Server.Targeting;
using Server.Network;


namespace Server.Mobiles
{
    [CorpseName("a cow corpse")]
    public class TamingCow : BaseCreature
    {
        public override bool CanBeDamaged()
        {
            return false;
        }

        [Constructable]
        public TamingCow() : base(AIType.AI_Use_Default, FightMode.None, 10, 1, 0.2, 0.4)
        {
            Name = "a Taming Cow";
            Body = 0xE7;
            Direction = Direction.South;
            LockDirection = true;
            SetStr(100);
            SetDex(100);
            SetInt(100);
            CantWalk = true;

            //Blessed = true;

            SetHits(10000);
            SetMana(0);

            SetDamage(0);

            SetDamageType(ResistanceType.Physical, 0);
            SetResistance(ResistanceType.Physical, 100);
            SetSkill(SkillName.MagicResist, 0);
            SetSkill(SkillName.Tactics, 0);
            SetSkill(SkillName.Wrestling, 0);
            Fame = 300;
            Karma = 0;
            VirtualArmor = 100;
            Tamable = true;
        }

        public override void OnHitsChange(int oldValue)
        {
            if (Hits != 10000)
            {
                Hits = 10000;
            }
            base.OnHitsChange(oldValue);
        }
        public override void OnThink()
        {
            base.OnThink();
            this.Say("Just Thinking About Things....");
        }

        public override void OnDoubleClick(Mobile from)
        {
            double min = (from.Skills.AnimalTaming.Base - 1.0);
            base.OnDoubleClick(from);
            //MinTameSkill = min;
            //from.SendM
            //from.SendMessage("You set the MinTameSkill to " + min);
            
            if (from.Skills.AnimalTaming.Base < 64.1)
            {
                return;
            }
            else
            {
                MinTameSkill = min;
                from.SendMessage("You set the MinTameSkill to " + min);
            }

        }
        

        public override void OnAfterTame(Mobile tamer)
        {
            base.OnAfterTame(tamer);
            this.Controlled = false;
            this.ControlMaster = null;
            this.ControlTarget = null;
            tamer.SendMessage("The Taming Cow releases itself.");
            
            if (tamer.Skills.AnimalTaming.Base < 120.0)
            {
                tamer.Skills.AnimalTaming.Base += 0.1;
            }
            else
            {
                tamer.SendMessage("You have no need to Train Animal Taming anymore.");
            }


        }

        public TamingCow(Serial serial) : base(serial)
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
            if (version > 0)
            {
            }
        }
    }
}
