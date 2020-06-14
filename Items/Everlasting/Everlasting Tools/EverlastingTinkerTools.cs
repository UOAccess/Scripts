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
using Server.ContextMenus;

namespace Server.Items
{
    [Flipable(0x1EB8, 0x1EB9)]
    public class EverlastingTinkerTools : BaseEverlastingTool
    {

        [Constructable]
        public EverlastingTinkerTools()
            : base(0x1EB8)
        {
            Name = "Everlasting Tinker Tools";
            this.Weight = 1.0;
        }

        public EverlastingTinkerTools(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefTinkering.CraftSystem;
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

        public override void GetContextMenuEntries(Mobile from, System.Collections.Generic.List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);

            if (Core.TOL)
                list.Add(new ToggleRepairContextMenuEntry(from, this));
        }

        public class ToggleRepairContextMenuEntry : ContextMenuEntry
        {
            private Mobile _From;
            private BaseEverlastingTool _Tool;

            public ToggleRepairContextMenuEntry(Mobile from, BaseEverlastingTool tool)
                : base(1157040) // Toggle Repair Mode
            {
                _From = from;
                _Tool = tool;
            }

            public override void OnClick()
            {
                if (_Tool.RepairMode)
                {
                    _From.SendLocalizedMessage(1157042); // This tool is fully functional. 
                    _Tool.RepairMode = false;
                }
                else
                {
                    _From.SendLocalizedMessage(1157041); // This tool will only repair items in this mode.
                    _Tool.RepairMode = true;
                }
            }
        }
    }
}
