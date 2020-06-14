using System;

namespace Server.Items
{
	public class Waystone : Item
	{
        public static int Animation = Config.Get("Waystone.Animation", 11);
        public static int FrameCount = Config.Get("Waystone.FrameCount", 5);
        public static int RepeatCount = Config.Get("Waystone.RepeatCount", 1);
        public static int Delay = Config.Get("Waystone.Delay", 0);
        private bool m_Marked;
        private Point3D m_Target;
        private Map m_TargetMap;

        [Constructable]
		public Waystone() : base(0x41BE)
		{
            Name = "a Waystone";
			Movable = true;

            m_Marked = false;
            m_TargetMap = null;

        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001);
            }
            else if (m_Marked == false)
            {
                from.Animate(Animation, FrameCount, RepeatCount, true, false, Delay);
                //from.Animate(16, 5, 1, true, false, 0);
                from.PlaySound(0x1EB);
                m_Target = from.Location;
                m_TargetMap = from.Map;
                m_Marked = true;
                from.SendMessage("You Mark the stones location.");

            }
            else
            {
                from.Animate(17, 5, 1, true, false, 0);
                from.PlaySound(0x0F6);
                from.Location = m_Target;
                from.Map = m_TargetMap;
                from.SendMessage("You are sent to the Waystones saved location.");
            }
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
            //list.Add("Marked");
            if (m_Marked == false)
            {
                list.Add("Not Marked");
            }
            else
            {
                list.Add("Marked");
            }
        }

        public Waystone(Serial serial) : base(serial)
		{
		}


        [CommandProperty(AccessLevel.Counselor, AccessLevel.GameMaster)]
        public bool Marked
        {
            get
            {
                return m_Marked;
            }
            set
            {
                if (m_Marked != value)
                {
                    m_Marked = value;
                    InvalidateProperties();
                }
            }
        }
        [CommandProperty(AccessLevel.Counselor, AccessLevel.GameMaster)]
        public Point3D Target
        {
            get
            {
                return m_Target;
            }
            set
            {
                m_Target = value;
            }
        }
        [CommandProperty(AccessLevel.Counselor, AccessLevel.GameMaster)]
        public Map TargetMap
        {
            get
            {
                return m_TargetMap;
            }
            set
            {
                if (m_TargetMap != value)
                {
                    m_TargetMap = value;
                    InvalidateProperties();
                }
            }
        }

        public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

            writer.Write((bool)m_Marked);
            writer.Write((Point3D)m_Target);
            writer.Write((Map)m_TargetMap);
        }

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

            m_Marked = reader.ReadBool();
            m_Target = reader.ReadPoint3D();
            m_TargetMap = reader.ReadMap();
        }
	}
}
