#region Header
/*

Name: FootPrints.CS
Author: Dramoor inspired by a runuo 1.0 ML server (uoex.net).
Version = 2.5
Date: 07/05/2018
All I ask if you use is to credit author and server inspired by.

 this is a very stupid, and rather annoying to most, thing. Saw on a Runuo 1.0 ML server that is running.
 Figured I would re-create it for a joke and then someone said they were interested in it.
 Essentially lets the player have some footprints follow behind them as they walk. you can randomize
 up to 5 different itemids to use.

 You will need to add a function to Playermobile for this to work. (No need to serialize or deserialize
 as then they will always revert all to off every restart)

 private bool m_FootPrintsOn;


 [CommandProperty(AccessLevel.GameMaster)]
        public bool FootPrintsOn
        {
            get { return m_FootPrintsOn; }
            set { m_FootPrintsOn = value; }
        }


        after adding that the rest is plug and play. Hope you enjoy.

  Special Thanks to Vorspire for helping with the idea of using the Effect instead of placing actual items!
  More thanks to Vorspire for helping with the placement being properly behind and not always directly below.
  You have helped me learn a lot thank you!
 */
#endregion

using System;
using System.Collections;
using Server.Mobiles;

namespace Server.Items
{
    public class BaseFootprints : Item
    { 
        private bool m_TurnedOn;
        private string m_PrintsName;
        private int m_PrintCount;
        private int m_PrintID1;
        private int m_PrintID2;
        private int m_PrintID3;
        private int m_PrintID4;
        private int m_PrintID5;
        private int m_PrintsHue;

        #region Getters n Setters
        [CommandProperty(AccessLevel.GameMaster)]
        public bool TurnedOn
        {
            get { return m_TurnedOn; }
            set { m_TurnedOn = value; }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public virtual string PrintsName
        {
            get
            {
                return m_PrintsName;
            }
            set
            {
                m_PrintsName = value; InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int PrintCount
        {
            get
            {
                return m_PrintCount;
            }
            set
            {
                if (value < 0)
                    value = 0;

                m_PrintCount = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int PrintID1
        {
            get
            {
                return m_PrintID1;
            }
            set
            {
                if (value < 0)
                    value = 0;

                m_PrintID1 = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int PrintID2
        {
            get
            {
                return m_PrintID2;
            }
            set
            {
                if (value < 0)
                    value = 0;

                m_PrintID2 = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int PrintID3
        {
            get
            {
                return m_PrintID3;
            }
            set
            {
                if (value < 0)
                    value = 0;

                m_PrintID3 = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int PrintID4
        {
            get
            {
                return m_PrintID4;
            }
            set
            {
                if (value < 0)
                    value = 0;

                m_PrintID4 = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int PrintID5
        {
            get
            {
                return m_PrintID5;
            }
            set
            {
                if (value < 0)
                    value = 0;

                m_PrintID5 = value;
                InvalidateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int PrintsHue
        {
            get
            {
                return m_PrintsHue;
            }
            set
            {
                if (value < 0)
                    value = 0;

                m_PrintsHue = value;
                InvalidateProperties();
            }
        }

        #endregion

        [Constructable]
        public BaseFootprints()
            : base(0x1ECE)
        {
            PrintsName = "Base Footprint";
            Name = "Footprints";
            Weight = 1.0;
        }

        public BaseFootprints(Serial serial)
            : base(serial)
        {
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (!TurnedOn)
            {
                list.Add(1114774, "{0}\t{1}\t{2}", m_PrintsName, "Double click to activate.", "Turned off");
            }
            else
                list.Add(1114774, "{0}\t{1}\t{2}", m_PrintsName, "Double click to de-activate.", "Turned on");
        }

        public override void OnDoubleClick(Mobile from)
        {
            PlayerMobile check = from as PlayerMobile;

            if (!this.IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042664); // You must have the object in your backpack to use it.
                return;
            }

            if (!TurnedOn)
            {
                if (!check.FootPrintsOn)
                {
                    BeginPrints(from, this);
                    ItemID = 0x1ED2;
                    from.SendMessage("You turn the footprints on.");
                    TurnedOn = true;
                    check.FootPrintsOn = true;
                }
                else
                {
                    from.SendMessage("You must turn off your other footprints first.");
                }
            }
            else
            {
                if (!check.FootPrintsOn)
                {
                    EndPrints(from);
                    ItemID = 0x1ECE;
                    from.SendMessage("Error! You obtained footprints that were turned on. Now turning off....");
                    TurnedOn = false;
                    check.FootPrintsOn = false;
                }
                else
                {
                    EndPrints(from);
                    ItemID = 0x1ECE;
                    from.SendMessage("You turn the footprints off.");
                    TurnedOn = false;
                    check.FootPrintsOn = false;
                }
            }
        }

        private static Hashtable m_Table = new Hashtable();

        public static void BeginPrints(Mobile m, Item z)
        {
            Timer t = (Timer)m_Table[m];

            if (t != null)
                t.Stop();

            t = new InternalTimer(m, z);
            m_Table[m] = t;


            t.Start();
        }

        public static void DoPrints(Mobile m, Item b)
        {
            BaseFootprints c = b as BaseFootprints;
            PlayerMobile pm = m as PlayerMobile;

            var behind = (Direction)(((int)(m.Direction & Direction.Mask) + 4) % 8);// was 8%

            int x = m.X, y = m.Y, z = m.Z;

            Server.Movement.Movement.Offset(behind, ref x, ref y);

            //var p = new Point3D(x, y, m.Map.GetAverageZ(x, y));
            var p = new Point3D(x, y, z);

            if (!c.IsChildOf(m.Backpack))
            {
                EndPrints(m);
                c.ItemID = 0x1ECE;
                m.SendMessage("The footprints must be in your pack to use. Turning them off.");
                c.TurnedOn = false;
                pm.FootPrintsOn = false;
                return;
            }
            if ((m is PlayerMobile) && c != null && pm.FootPrintsOn == true)
            {
                if (Core.TickCount - m.LastMoveTime <= m.ComputeMovementSpeed(m.Direction) && c.IsChildOf(m.Backpack) && pm.Hidden == false)
                {
                    int printid = 0;
                    switch (c.PrintCount)
                    {
                        case 0:
                            printid = 0x9DAC;//smoke puffs
                            break;
                        case 1:
                            printid = c.PrintID1;
                            break;
                        case 2:
                            printid = Utility.RandomList(c.PrintID1, c.PrintID2);
                            break;
                        case 3:
                            printid = Utility.RandomList(c.PrintID1, c.PrintID2, c.PrintID3);
                            break;
                        case 4:
                            printid = Utility.RandomList(c.PrintID1, c.PrintID2, c.PrintID3, c.PrintID4);
                            break;
                        case 5:
                            printid = Utility.RandomList(c.PrintID1, c.PrintID2, c.PrintID3, c.PrintID4, c.PrintID5);
                            break;
                    }
                    Effects.SendLocationEffect(p, pm.Map, printid, 13, 3, c.PrintsHue, 0);
                }
            }
        }

        public static void EndPrints(Mobile m)
        {
            Timer t = (Timer)m_Table[m];

            if (t == null)
                return;

            t.Stop();
            m_Table.Remove(m);
        }

        private class InternalTimer : Timer
        {
            private Mobile m_From;
            private Item m_this;
            private int m_Count;

            public InternalTimer(Mobile from, Item o) : base(TimeSpan.FromSeconds(.1), TimeSpan.FromSeconds(.1)) //firsttime was 2 now 1
            {
                m_this = o;
                m_From = from;
                Priority = TimerPriority.TenMS;
            }

            protected override void OnTick()
            {
                DoPrints(m_From, m_this);
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt((int)1); // version

            writer.Write(m_PrintCount);
            writer.Write(m_PrintID1);
            writer.Write(m_PrintID2);
            writer.Write(m_PrintID3);
            writer.Write(m_PrintID4);
            writer.Write(m_PrintID5);
            writer.Write(m_PrintsHue);
            writer.Write(m_PrintsName);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();

            switch (version)
            {
                case 1:
                    {
                        m_PrintCount = reader.ReadInt();
                        m_PrintID1 = reader.ReadInt();
                        m_PrintID2 = reader.ReadInt();
                        m_PrintID3 = reader.ReadInt();
                        m_PrintID4 = reader.ReadInt();
                        m_PrintID5 = reader.ReadInt();
                        m_PrintsHue = reader.ReadInt();
                        m_PrintsName = reader.ReadString();
                        goto case 0;
                    }
                case 0:
                    { 
                    if (ItemID != 0x1ECE)
                        ItemID = 0x1ECE;
                    break;
                    }
            }
        }
    }
}
