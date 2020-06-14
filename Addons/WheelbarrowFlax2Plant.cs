using System;

namespace Server.Items
{
    public class WheelbarrowFlax2Plant : Item, IDyable
    {
        [Constructable]
        public WheelbarrowFlax2Plant()
            : this(1)
        {
        }

        [Constructable]
        public WheelbarrowFlax2Plant(int amount)
            : base(0xA11E)
        {
            this.Stackable = false;
            this.Amount = amount;
        }

        public WheelbarrowFlax2Plant(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1125269;
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
