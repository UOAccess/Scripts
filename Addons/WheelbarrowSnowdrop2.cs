using System;

namespace Server.Items
{
    public class WheelbarrowSnowdrop2 : Item, IDyable
    {
        [Constructable]
        public WheelbarrowSnowdrop2()
            : this(1)
        {
        }

        [Constructable]
        public WheelbarrowSnowdrop2(int amount)
            : base(0xA122)
        {
            this.Stackable = false;
            this.Amount = amount;
        }

        public WheelbarrowSnowdrop2(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1125270;
            }
        }// decorative plant
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
        #region IDyable
        public virtual bool Dye(Mobile from, DyeTub sender)
        {
            if (this.Deleted)
                return false;

            this.Hue = sender.DyedHue;
            return true;
        }
        #endregion
    }
}
