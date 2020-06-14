using System;

namespace Server.Items
{
    public class WheelbarrowPoppies : Item,IDyable
    {
        [Constructable]
        public WheelbarrowPoppies()
            : this(1)
        {
        }

        [Constructable]
        public WheelbarrowPoppies(int amount)
            : base(0xA0ED)
        {
            this.Stackable = false;
            this.Amount = amount;
        }

        public WheelbarrowPoppies(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1125221;
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
