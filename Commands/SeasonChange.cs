#region Fraz
/*
    made by Fraz 3.29.2016  
*/
#endregion

using System;
using Server.Commands;
using Server.Network;

namespace Server.Gumps
{
    public class SeasonChange : Gump
    {
        private Map _map;

        public static void Initialize()
        {
            CommandSystem.Register("SeasonChange", AccessLevel.Decorator, new CommandEventHandler(SeasonChange_OnCommand));
            CommandSystem.Register("SC", AccessLevel.Decorator, new CommandEventHandler(SeasonChange_OnCommand));
        }

        [Usage("SeasonChange")]
        [Aliases("SC")]
        [Description("Brings up the Season Change Menu")]
        private static void SeasonChange_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;
            from.CloseGump(typeof(SeasonChange));
            from.SendGump(new SeasonChange(from, from.Map));
        }

        static string Center(string text)
        {
            return String.Format("<CENTER>{0}</CENTER>", text);
        }

        static string Color(string text, int color)
        {
            return String.Format("<BASEFONT COLOR=#{0:X6}>{1}</BASEFONT>", color, text);
        }

        static string Label(string text, string value)
        {
            return String.Format("{0}: {1}", text, value);
        }

        void AddButtonLabeled(int x, int y, int buttonID, string text)
        {
            AddButton(x, y - 1, 4005, 4007, buttonID, GumpButtonType.Reply, 0);
            AddHtml(x + 35, y, 240, 20, Color(text, 0xFFFFFF), false, false);
        }

        void AddTextField(int x, int y, int width, int height, int index)
        {
            AddBackground(x - 2, y - 2, width + 4, height + 4, 0x2486);
            AddTextEntry(x + 2, y + 2, width - 4, height - 4, 0, index, "");
        }

        public SeasonChange(Mobile from, Map map) : base(0, 0)
        {
            NetState ns = from.NetState;
            if (ns == null) return;

            _map = map;

            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;

            AddPage(0);
            AddBackground(5, 115, 230, 200, 9270);
            AddAlphaRegion(15, 125, 210, 180);
            AddHtml(7, 128, 230, 375, Color(Center("SEASON CHANGE ASSISTANT"), 0x00FF00), false, false);
            AddLabel(85, 147, 2727, Label("Map", _map.Name));
            AddLabel(25, 172, 2727, @"Select Map");
            AddTextField(105, 173, 110, 20, 0);
            AddButton(185, 197, 4005, 4007, 0xFF, GumpButtonType.Reply, 0);
            AddButtonLabeled(25, 200, 1, "Spring");
            AddButtonLabeled(25, 220, 2, "Summer");
            AddButtonLabeled(25, 240, 3, "Fall");
            AddButtonLabeled(25, 260, 4, "Winter");
            AddButtonLabeled(25, 280, 5, "Desolation");
            AddImage(192, 271, 0x71, 2424);
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;

            if (from == null) return;
            if (info.ButtonID < 1) return;

            var mapNameEntry = info.GetTextEntry(0);

            string MapNameEntry = null;
            if (mapNameEntry != null)
                MapNameEntry = mapNameEntry.Text.Trim();

            if (info.ButtonID == 0xFF)
            {
                 for (int j = 0; j < Map.AllMaps.Count; ++j)
                {
                    if (MapNameEntry != null && Map.AllMaps[j].Name == MapNameEntry)
                    {
                        if (Map.AllMaps[j] != null && Map.AllMaps[j] != Map.Internal)
                        {
                            from.CloseGump(typeof(SeasonChange));
                            from.SendGump(new SeasonChange(from, Map.AllMaps[j]));
                            return;
                        }
                    }
                }
                from.SendMessage("No map was found with the name you selected.");
                from.CloseGump(typeof(SeasonChange));
                from.SendGump(new SeasonChange(from, _map));
                return;
            }

            _map.Season = info.ButtonID - 1;

            for (int i = 0; i < NetState.Instances.Count; ++i)
            {
                NetState ns = NetState.Instances[i];
                if (ns == null) continue;

                Mobile m = ns.Mobile;

                if (m != null && m.Map == _map)
                {
                    ns.Sequence = 0;
                    ns.Send(Network.SeasonChange.Instantiate(m.GetSeason(), true));

                    if (ns.StygianAbyss)
                    {
                        ns.Send(new MobileUpdate(m));
                    }
                    else
                    {
                        ns.Send(new MobileUpdateOld(m));
                    }
                }
            }
            from.CloseGump(typeof(SeasonChange));
            from.SendGump(new SeasonChange(from, _map));
        }
    }
}