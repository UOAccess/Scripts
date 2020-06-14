using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Prompts;
using Server.Network;
using System.Collections;

namespace Server.Items
{
    public class AutoResStone : Item
    {
        private int m_Charges = 1;

        [CommandProperty( AccessLevel.GameMaster )]
        public int Charges
        {
            get { return m_Charges; }
            set { m_Charges = value; InvalidateProperties(); }
        }

        private Timer m_Timer;
        private TimeSpan m_Delay = TimeSpan.FromSeconds( 5.0 ); /*TimeSpan.Zero*/

        [CommandProperty(AccessLevel.GameMaster)]
        public TimeSpan Delay { get { return m_Delay; } set { m_Delay = value; } }
	
        public static void Initialize()
        {
            EventSink.PlayerDeath += new PlayerDeathEventHandler(EventSink_Death);
        }

        private static void EventSink_Death(PlayerDeathEventArgs e)
        {
            PlayerMobile owner = e.Mobile as PlayerMobile;

            if (owner != null && !owner.Deleted)
            {
                if (owner.Alive)
                    return;

                if (owner.Backpack == null || owner.Backpack.Deleted)
                    return;

                AutoResStone stone = owner.Backpack.FindItemByType(typeof(AutoResStone)) as AutoResStone;

                if (stone != null && !stone.Deleted)
                {
                    stone.CountDown(owner);
                }
            }
        }

        [Constructable]
        public AutoResStone() : this( 1 )
        { }

        [Constructable]
        public AutoResStone(int charges)   /*int amount*/
            : base(0x1870) 
        {
            m_Charges = charges;

            Name = "Stone Of Rebirth";
            LootType = LootType.Blessed;
            
            /*Stackable = true;*/
            Weight = 1.0;
            /*Amount = amount;*/
        }

        public AutoResStone(Serial serial)
            : base(serial)
        { }

        private void CountDown(PlayerMobile owner)
        {
            m_Timer = Timer.DelayCall(m_Delay, new TimerStateCallback(Resurrect_OnTick), new object[] { owner });
        }

        private void Resurrect_OnTick(object state)
        {
            object[] states = (object[])state;
            PlayerMobile owner = (PlayerMobile)states[0];

            if (owner != null && !owner.Deleted)
            {
                if (owner.Alive || m_Charges < 1)
                    return;

                owner.SendMessage("Your stone of rebirth has saved you from the farplane.");
                owner.Resurrect();

                owner.Hits = owner.HitsMax;
                owner.Stam = owner.StamMax;
                owner.Mana = owner.ManaMax; 

                //m_Charges--;

                InvalidateProperties();
            }
        }

        public override void GetProperties( ObjectPropertyList list )
        {
            base.GetProperties( list );

            //list.Add(String.Format("{0} Charges", m_Charges));
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write( (int) 0 ); // version

            writer.Write( (TimeSpan) m_Delay );
            writer.Write( (int) m_Charges );            
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0: 
                {
                     m_Delay = reader.ReadTimeSpan();
                     m_Charges = reader.ReadInt();
                } break;
            }
        }

    }
}
