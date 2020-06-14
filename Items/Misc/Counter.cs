using System;

namespace Server.Items
{
    [FlipableAttribute(0xB40, 0xB3F)]
    public class Counter : Item
    {
        [Constructable]
        public Counter() : base (0xB40)
        {
            Name = "a Counter";
            Movable = true;
        }

        public Counter(Serial serial) : base(serial)
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
