/*  Scripted By
 *        █▀▀▀ █▀▀ █▀▀█ █▀▀ █▀▀ ▀█ █▀ █▀▀█ █▀▀█ 
 *        █▀▀▀ ▀▀█ █  █ █   █▀   █▄█  █▄▄█ █  █ 
 *        █▄▄▄ ▀▀▀ █▀▀▀ ▀▀▀ ▀▀▀   ▀   ▀  ▀ █  █
 *                 █
 *  
 *     █ █ █▀█ ▄▀█ █▀▀ █▀▀ █▀▀ █▀ █▀   █▀▀ █▀█ █▀█▀█
 *     █▄█ █▄█ █▀█ █▄▄ █▄▄ ██▄ ▄█ ▄█ ▄ █▄▄ █▄█ █ ▀ █
 */

using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute(0x1022, 0x1023)]
    public class EverlastingFletcherTools : BaseEverlastingTool
    {
        [Constructable]
        public EverlastingFletcherTools()
            : base(0x1022)
        {
            this.Name = "Everlasting Fletcher Tools";
            this.Weight = 2.0;
            this.Hue = 1150;
        }

        public EverlastingFletcherTools(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefBowFletching.CraftSystem;
            }
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

            if (this.Weight == 1.0)
                this.Weight = 2.0;
        }
    }
}
