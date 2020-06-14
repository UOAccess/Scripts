using System;

namespace Server.Items
{
    public class BossDyeTub : DyeTub
    {
        [Constructable]
        public BossDyeTub(int i)
        {
            //this.Redyable = false;  //Remove this before the 'switch (i)'
            switch (i)
            {
                case 1:
                    {
                        this.Hue = 0x300;
                        this.DyedHue = this.Hue;
                        this.Redyable = false;//<--add this into the switch case itself
                        break;
                    }
                case 2:
                    {
                        this.Hue = 0x489;
                        this.DyedHue = this.Hue;
                        this.Redyable = false;//<--add this into the switch case itself
                        break;
                    }
            }
        }

        public BossDyeTub(Serial serial)
            : base(serial)
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
