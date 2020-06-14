using System;
using Server;
using Server.Engines.Craft;

namespace Server.Items
{
    [Server.Engines.Craft.Forge]
    public class PoweredForge : Item
    {
        private int m_UsesRemaining;

        [CommandProperty(AccessLevel.GameMaster)]
        public int UsesRemaining
        {
            get
            {
                return this.m_UsesRemaining;
            }
            set
            {
                this.m_UsesRemaining = value;
                this.InvalidateProperties();
            }
        }

        [Constructable]
        public PoweredForge()
            : base(0xFB1)
        {
            this.Movable = false;
            UsesRemaining = 100;
        }

        public PoweredForge(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
            writer.Write((int)this.m_UsesRemaining);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
            this.m_UsesRemaining = reader.ReadInt();
        }
    }
}
