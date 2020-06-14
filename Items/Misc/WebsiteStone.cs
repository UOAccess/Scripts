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
    [FlipableAttribute(0x116D, 0x116E)]
    public class WebsiteStone : Item
	{
        private string _Link = "(~*Set the Website*~)";
		private string _Label = "Launches your browser to ";

        [CommandProperty(AccessLevel.GameMaster)]
        public string Link
        {
            get { return _Link; }
            set { _Link = value; InvalidateProperties(); }
        }
        [CommandProperty(AccessLevel.GameMaster)]
		public string Label {
            get { return _Label; } set{ _Label = value; InvalidateProperties(); }
		}

		[Constructable]
		public WebsiteStone() : base(0x116E)
		{
			Name = "Website Stone";
			Hue = 0;
			Movable = false;
		}

		public override void GetProperties(ObjectPropertyList list)
		{
			base.GetProperties(list);
			list.Add(_Label + _Link);
		}

        public override void OnDoubleClick(Mobile from)
        {
            base.OnDoubleClick(from);
            from.LaunchBrowser(_Link);

        }

        public WebsiteStone(Serial serial) : base(serial)
		{
        }

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			int version = 0;
			writer.Write(version);
			switch (version)
			{
				case 0:
					{
                        writer.Write(_Link);
						writer.Write(_Label);
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
                        _Link = reader.ReadString();
						_Label = reader.ReadString();
                        
                    } break;
			}
		}
	}
}
