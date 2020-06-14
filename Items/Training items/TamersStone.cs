using System;
using System.Collections;
using Server;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{
    public class TamerStone : Item
    {
        private static Hashtable m_BeingTamed = new Hashtable();

        [Constructable]
        public TamerStone() : base(0xED4)
        {
            Name = "A Tamers Stone";
            Hue = 0x48A;
            Movable = false;
        }


        public override void OnDoubleClick(Mobile from)
        {
            object target = this;

            if (from.Skills.AnimalTaming.Base != 120.0)
            {
                if (m_BeingTamed.Contains(this))
                {
                    from.SendLocalizedMessage(502802); // Someone else is already taming this.
                }
                else
                {
                    m_BeingTamed[this] = this;
                    // Face the creature
                    from.Direction = from.GetDirectionTo(this);
                    from.NextSkillTime = Core.TickCount + 6000;
                    from.LocalOverheadMessage(MessageType.Emote, 0x59, 1010597); // You start to tame the creature.
                    from.NonlocalOverheadMessage(MessageType.Emote, 0x59, 1010598); // *begins taming a creature.*

                    new InternalTimer(from, this, Utility.Random(10, 10)).Start();
                }
            }
            else
            {
                from.SendMessage("You are too good at Taming to try this.");
            }
        }

        private class InternalTimer : Timer
        {
            //private BaseTamer m_Item;
            private Mobile m_Tamer;
            private TamerStone m_Stone;
            //private int m_MaxCount;
            //private int m_Count;



            public InternalTimer(Mobile tamer, TamerStone stone, int count) : base(TimeSpan.FromSeconds(10.0), TimeSpan.FromSeconds(10.0), count)
            {

                m_Tamer = tamer;
                m_Stone = stone;


            }

            protected override void OnTick()
            {
                //m_Count++;

                if (!m_Tamer.InRange(m_Stone, 6))
                {
                    m_BeingTamed.Remove(m_Stone);
                    m_Tamer.NextSkillTime = Core.TickCount;
                    m_Tamer.SendLocalizedMessage(502795); // You are too far away to continue taming.
                    Stop();
                }
                else if (!m_Tamer.CheckAlive())
                {
                    m_BeingTamed.Remove(m_Stone);
                    m_Tamer.NextSkillTime = Core.TickCount;
                    m_Tamer.SendLocalizedMessage(502796); // You are dead, and cannot continue taming.
                    Stop();
                }
                else if (!m_Tamer.CanSee(m_Stone))
                {
                    m_BeingTamed.Remove(m_Stone);
                    m_Tamer.NextSkillTime = Core.TickCount;
                    m_Tamer.SendLocalizedMessage(502800); // You can't see that.
                    Stop();
                }
                else
                {
                    m_Tamer.RevealingAction();
                    m_Tamer.NextSkillTime = Core.TickCount;
                    m_BeingTamed.Remove(m_Stone);

                    if (m_Tamer.Skills.AnimalTaming.Base >= 100.0)
                    {
                        m_Tamer.PrivateOverheadMessage(MessageType.Regular, 0x3B2, 502799, m_Tamer.NetState); // It seems to accept you as master.
                        m_Tamer.Skills.AnimalTaming.Base += 0.1;
                        Stop();
                    }
                    else
                    {
                        m_Tamer.SendMessage("You can no longer tame this stone."); // You fail to tame the creature.
                    }
                }
            }
        }



        public TamerStone(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
