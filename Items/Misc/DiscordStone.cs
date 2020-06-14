using System;
using System.Collections;
using System.Collections.Generic;

using Server;
using Server.Misc;
using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Accounting;


namespace Server.Items
{
    [FlipableAttribute(0x117B, 0x117C)]
    public class DiscordStone : Item
	{
		private string _LabelMessage = "Use: Launches your browser to the Discord Invite";
        private string _DiscordInviteLink = "https://discord.gg/#######";

        [CommandProperty(AccessLevel.GameMaster)]
        public string LabelMessage
        {
            get { return _LabelMessage; }
            set { _LabelMessage = value; InvalidateProperties(); }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public string DiscordInviteLink
        {
            get { return _DiscordInviteLink; }
            set { _DiscordInviteLink = value; InvalidateProperties(); }
        }

		[Constructable]
		public DiscordStone() : base(0x117C)
		{
			Name = "Discord Invite";
			Hue = 0;
			Movable = false;
		}

		public override void GetProperties(ObjectPropertyList list)
		{
			base.GetProperties(list);
			list.Add(1070722, "<BIG><BASEFONT COLOR=#FF0000>"+ _LabelMessage + "</BIG><BASEFONT COLOR=#FFFFFF>");
		}

        public override void OnDoubleClick(Mobile from)
        {
            base.OnDoubleClick(from);
            from.LaunchBrowser(_DiscordInviteLink);

        }

        public DiscordStone(Serial serial) : base(serial)
		{ }

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			int version = 0;

			writer.Write(version);

			switch (version)
			{
				case 0:
					{
						writer.Write(_LabelMessage);
                        writer.Write(_DiscordInviteLink);
                    } break;
			}
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			switch (version)
			{
				case 0:
					{
						_LabelMessage = reader.ReadString();
                        _DiscordInviteLink = reader.ReadString();
                    } break;
			}
		}
	}
}
