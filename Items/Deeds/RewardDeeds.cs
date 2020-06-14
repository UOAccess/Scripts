using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class LumyrianRaiderRewardTitleDeed : BaseRewardTitleDeed
    {
        public override TextDefinition Title { get { return new TextDefinition("Lumyrian Raider"); } }

        [Constructable]
        public LumyrianRaiderRewardTitleDeed()
        {
        }

        public LumyrianRaiderRewardTitleDeed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int v = reader.ReadInt();
        }
    }
}
