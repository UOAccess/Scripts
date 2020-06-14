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
    [FlipableAttribute(0x13E3, 0x13E4)]
    public class EverlastingSmithHammer : BaseEverlastingTool
    {

        [Constructable]
        public EverlastingSmithHammer()
            : base(0x13E3)
        {
            Name = "Everlasting Smith Hammer";
            this.Weight = 8.0;
            this.Layer = Layer.OneHanded;
        }

        public EverlastingSmithHammer(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefBlacksmithy.CraftSystem;
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
        }
    }
}
