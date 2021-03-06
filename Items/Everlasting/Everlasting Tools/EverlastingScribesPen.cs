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
    [FlipableAttribute(0x0FBF, 0x0FC0)]
    public class EverlastingScribesPen : BaseEverlastingTool
    {

        [Constructable]
        public EverlastingScribesPen()
            : base(0x0FBF)
        {
            Name = "Everlasting Scribes Pen";
            this.Weight = 1.0;
        }

        public EverlastingScribesPen(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefInscription.CraftSystem;
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1044168;
            }
        }// scribe's pen
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (this.Weight == 2.0)
                this.Weight = 1.0;
        }
    }
}
