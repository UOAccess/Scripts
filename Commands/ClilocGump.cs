using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;
using Server.Commands;
using System.IO;
using System.Linq;

namespace Server.Gumps
{
    //this is an entry which holds the loaded cliloc index/text pair
    public class CliLocEntry
    {
        protected int _Index;
        protected string _Text;

        public int Index
        {
            get { return _Index; }
        }

        public string Text
        {
            get { return _Text; }
        }

        public override string ToString()
        {
            return _Text;
        }

        public CliLocEntry(int index,string text)
        {
            _Index = index;
            _Text = text;
        }
    }
	
    public class ClilocGump : Gump
    {
		public static List<int> ClilocList;
		public static Hashtable ClilocHash;
		
		private static int MaxEntry { get { return 3011032; } }
		
        public static void Initialize()
        {
            CommandSystem.Register("ClilocGump", AccessLevel.Administrator, new CommandEventHandler(ClilocGump_OnCommand));
            CommandSystem.Register("Cliloc", AccessLevel.Administrator, new CommandEventHandler(ClilocGump_OnCommand));
			if (LoadClilocs()) Console.WriteLine("ClilocGump successfully loaded Cliloc list.");
			else Console.WriteLine("ClilocGump failed to load Cliloc list.");
        }

        [Usage("ClilocGump")]
        [Description("Begins the Cliloc Gump.")]
        private static void ClilocGump_OnCommand(CommandEventArgs e)
        {
            Mobile m = e.Mobile;
            try
            {
                int arg = Int32.Parse(e.Arguments[0]);
                if (arg >= 500000 && arg <= 3011032) {
                    m.SendGump(new ClilocGump(m, arg));
				}
                else {
                    m.SendGump(new ClilocGump(m));
				}
            }
            catch { 
				m.SendGump(new ClilocGump(m));
			}
            
        }

        private static bool LoadClilocs()
        {
            bool success = true;
			
			ClilocHash = Read("cliloc.enu", Core.FindDataFile("cliloc.enu"));
            ClilocList = new List<int>();
			try
			{
				for (int x = 500000; x < 3011032; x++)
				{
					if (ClilocHash.ContainsKey(x) && ClilocHash[x] is CliLocEntry && ((CliLocEntry)ClilocHash[x]).Text.Length > 0)
					{
						ClilocList.Add(x);
					}
				}
			}
			catch { success = false; }
            return success;
        }

        //read operation, which loads all the data into the specified cliloc entry hashtable
        public static Hashtable Read(string _Filename, string _FilePath)
        {
            Hashtable clilocs = new Hashtable();

            if (File.Exists(_FilePath))
            {
                using (FileStream stream = new FileStream(_FilePath,FileMode.Open,FileAccess.Read,FileShare.Read))
                {
                    BinaryReader reader = new BinaryReader(stream);
                    for (int i = 0; i < 6; i++){reader.ReadByte();}
                    System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                    int index = 0;
					
                    while (index != MaxEntry)
                    {
						try {
							index = reader.ReadInt32();
							reader.ReadByte();
							short strlen = reader.ReadInt16();
							byte[] buffer = new byte[strlen];
							reader.Read(buffer,0,strlen);
							string text = encoding.GetString(buffer);
							clilocs.Add(index,new CliLocEntry(index,text));
						}
						catch{}
                    }
                }
            }
            else
            {
                Console.WriteLine("CliLoc load error: file doesn't exist");
                return null;
            }

            return clilocs;
        }
		
        private Mobile m_From;
        private int m_OldIndex;
        private int m_LastIndex;
        private const int NUM_PER_PAGE = 8;
        private int m_Theme = 7;
		private string m_Filter = "";
		private List<int> m_List;

        public ClilocGump(Mobile from)
            : this(from, 0, 7, "")
        {
        }

        public ClilocGump(Mobile from, int temp)
            : this(from, ClilocList.LastIndexOf(temp), 7, "")
        {
        }

        public ClilocGump(Mobile from, int index, int theme, string filter)
            : base(20, 40)
        {
            m_From = from;
            m_OldIndex = index;
            m_LastIndex = index;
            m_Theme = theme;
			m_Filter = filter;
			m_List = ClilocList;
			
			int precount = m_List.Count;
			if (m_Filter.Length > 0) 
				m_List = FilteredCliLocs(m_Filter);
			
            bool t7 = theme == 7;
            bool t8 = theme == 8;
            bool t9 = theme == 9;
            bool t10 = theme == 10;
            bool t11 = theme == 11;
            int bground = t7 ? 9200 : t8 ? 3500 : t9 ? 3600 : t10 ? 9400 : 9300;

            Closable = true;
            Disposable = true;
            Dragable = true;
            Resizable = true;

            AddPage(0);
            AddBackground(20, 40, 740, 505, bground);
            AddBackground(20, 551, 618, 39, bground);
            AddBackground(621, 551, 139, 39, bground);
            AddBackground(600, 90, 130, 60, 9200);
            AddHtml(615, 105, 80, 30, t7 ? "*Current*" : "Select This One", true, false);
            if (!t7) AddButton(700, 108, 1210, 1210, 7, GumpButtonType.Reply, 0);
            AddBackground(600, 165, 130, 60, 3500);
            AddHtml(615, 180, 80, 30, t8 ? "*Current*" : "Select This One", true, false);
            if (!t8) AddButton(700, 183, 1210, 1210, 8, GumpButtonType.Reply, 0);
            AddBackground(600, 240, 130, 60, 3600);
            AddHtml(615, 255, 80, 30, t9 ? "*Current*" : "Select This One", true, false);
            if (!t9) AddButton(700, 258, 1210, 1210, 9, GumpButtonType.Reply, 0);
            AddBackground(600, 315, 130, 60, 9400);
            AddHtml(615, 330, 80, 30, t10 ? "*Current*" : "Select This One", true, false);
            if (!t10) AddButton(700, 333, 1210, 1210, 10, GumpButtonType.Reply, 0);
            AddBackground(600, 390, 130, 60, 9300);
            AddHtml(615, 405, 80, 30, t11 ? "*Current*" : "Select This One", true, false);
            if (!t11) AddButton(700, 408, 1210, 1210, 11, GumpButtonType.Reply, 0);
            int y = 45;
            int found = 0;
			int error = 0;

            for (int z = index; found < NUM_PER_PAGE && z < m_List.Count; z++)
            {
                try
                {
                    AddHtml(33, y + 3, 80, 22, m_List[z].ToString(), false, false);
                    AddHtmlLocalized(110, y, 480, (int)(500 / NUM_PER_PAGE) - 5, m_List[z], true, true);
                    y += (int)(500/NUM_PER_PAGE);
                    found += 1;
                }
                catch { 
					error++;
				}
                m_LastIndex = z;
            }

			try {
				AddLabel(490, 560, 380, "Search by number:");
				AddTextField(630, 560, 90, 20, 2, m_List[index].ToString());
				AddButton(715, 560, 4015, 4016, 5, GumpButtonType.Reply, 0);
				AddLabel(20, 560, 380, "Search by name:");
				AddTextField(130, 560, 290, 20, 3, m_Filter);
				AddButton(420, 560, 4015, 4016, 6, GumpButtonType.Reply, 0);
				if (index - NUM_PER_PAGE  >= 0) 
					AddButton(601, 45, 0x1519, 0x1519, 3, GumpButtonType.Reply, 0); // Previous Page
				if (index + NUM_PER_PAGE < m_List.Count) 
					AddButton(601, 522, 0x151A, 0x151A, 4, GumpButtonType.Reply, 0); // Next Page
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
        }

        public void AddTextField(int x,int y,int width,int height,int index,string text)
        {
            AddImageTiled(x - 2,y - 2,width + 4,height + 4,0xA2C);
            AddAlphaRegion(x - 2,y - 2,width + 4,height + 4);
            AddTextEntry(x + 2,y + 2,width - 4,height - 4,1153,index,text);
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            int x = info.ButtonID;
            TextRelay tr2 = info.GetTextEntry(2);
            TextRelay tr3 = info.GetTextEntry(3);
            m_From.CloseGump(typeof(ClilocGump));
            if (x == 3) m_From.SendGump(new ClilocGump(m_From, m_OldIndex - NUM_PER_PAGE, m_Theme, m_Filter)); //Previous Page
            else if (x == 4) m_From.SendGump(new ClilocGump(m_From, m_LastIndex + 1, m_Theme, m_Filter)); //Next Page
            else if (x == 5 && tr2 != null)
            {
                //Try to interpret the number typed in the browse box.
                int temp = 0;
                try { temp = Convert.ToInt32(tr2.Text, 10); }
                catch { }

                if (ClilocList.Contains(temp))
                {
                    m_From.SendGump(new ClilocGump(m_From, ClilocList.LastIndexOf(temp), m_Theme, ""));
                }
                else
                //If out of range, send an error, and re-display the gump.
                {
                    m_From.SendMessage("That number is out of range.");
                    m_From.SendGump(new ClilocGump(m_From, m_OldIndex, m_Theme, m_Filter));
                }
            }
            else if (x == 6 && tr3 != null)
            {
                //Try to interpret the number typed in the browse box.
				string filter = "";
                try { filter = tr3.Text; }
                catch { 
                    m_From.SendMessage("That search text was not recognized.");
                    m_From.SendGump(new ClilocGump(m_From, 0, m_Theme, ""));
				}
				
                m_From.SendGump(new ClilocGump(m_From, 0, m_Theme, filter));
            }
            else if (x == 7) m_From.SendGump(new ClilocGump(m_From, m_OldIndex, x, m_Filter)); //Grey Stone Theme
            else if (x == 8) m_From.SendGump(new ClilocGump(m_From, m_OldIndex, x, m_Filter)); //Paper Theme
            else if (x == 9) m_From.SendGump(new ClilocGump(m_From, m_OldIndex, x, m_Filter)); //Dark Box Theme
            else if (x == 10) m_From.SendGump(new ClilocGump(m_From, m_OldIndex, x, m_Filter)); //Shiny Grey Theme
            else if (x == 11) m_From.SendGump(new ClilocGump(m_From, m_OldIndex, x, m_Filter)); //Tan Parchment Theme
        }

        protected static List<int> FilteredCliLocs(string filterstring)
        {
            if (filterstring == null || filterstring == "")
            {
                return ClilocGump.ClilocHash.Keys.Cast<int>().ToList();
            }

            List<int> filtered = new List<int>();

            IDictionaryEnumerator enumerator = ClilocGump.ClilocHash.GetEnumerator();

            //seek ahead until you reach the entry

            while (enumerator.MoveNext())
            {
                if (enumerator.Value.ToString().ToLower().IndexOf(filterstring.ToLower()) > -1)
                {
                    filtered.Add((int)enumerator.Key);
                }
            }
			filtered.Sort();

			if (filtered.Count == 0) return ClilocGump.ClilocHash.Keys.Cast<int>().ToList();
            return filtered;
        }
    }
}