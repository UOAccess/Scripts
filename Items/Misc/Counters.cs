using System;

namespace Server.Items
{
    [FlipableAttribute(0xB40, 0xB3F)]
    public class Counters : Item
	{
        [Constructable]
		public Counters(int i)
		{
            switch (i)
            {
                case 1:
                    {
                        ItemID = 0xB40;
                        Name = "a Counter";
                        Movable = true;
                        break;
                    }
                case 2:
                    {
                        ItemID = 0xB3F;
                        Name = "a Counter";
                        Movable = true;
                        break;
                    }
            }
        }

        public Counters(Serial serial) : base(serial)
		{
		}

        public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
        }

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
        }
	}
}
