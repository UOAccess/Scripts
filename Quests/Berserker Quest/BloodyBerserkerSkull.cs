/* This file was created with
Ilutzio's Questmaker. Enjoy! */
using System;
using Server;
namespace Server.Items
{
    public class BloodyBerserkerSkull : Item
    {
        [Constructable]
        public BloodyBerserkerSkull() : this(1)
        { }
        [Constructable]
        public BloodyBerserkerSkull(int amountFrom, int amountTo) : this(Utility.RandomMinMax(amountFrom, amountTo))
        { }
        [Constructable]

        ///////////The hexagon value ont he line below is the ItemID
        public BloodyBerserkerSkull(int amount) : base(6883)
        {


            ///////////Item name
            Name = "Bloody Berserker Skull";

            ///////////Item hue
            Hue = 0x845;

            ///////////Stackable
            Stackable = true;

            ///////////Weight of one item
            Weight = 0.01;
            Amount = amount;

        }
        public BloodyBerserkerSkull(Serial serial) : base(serial)
        { }
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
