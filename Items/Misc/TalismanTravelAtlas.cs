using System;
using System.Collections;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;
using Server.Commands;
using Server.Commands.Generic;

namespace Server.Items
{
	public class TalismanTravelAtlas : BaseTalisman
	{
		[Flags]
		public enum OptFlags
		{
			None			= 0x0000,
			Trammel			= 0x0001,
			TramDungeons	= 0x0002,
			Felucca			= 0x0004,
			FelDungeons		= 0x0008,
			Custom      	= 0x0010,
			Ilshenar		= 0x0020,
			IlshenarShrines = 0x0040,
			Malas			= 0x0080,
			Tokuno			= 0x0100,
			AllowReds		= 0x0200,
			TerMur			= 0x0400,
			UseGlobal		= 0x0800
		}

		public static void Initialize()
		{
			
			if ( m_GlobalFlags == OptFlags.None )
			{
				SetOptFlag( ref m_GlobalFlags, OptFlags.Trammel, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.TramDungeons, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.Felucca, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.FelDungeons, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.Custom, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.Ilshenar, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.IlshenarShrines, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.Malas, Core.AOS );
				SetOptFlag( ref m_GlobalFlags, OptFlags.Tokuno, Core.SE );
				SetOptFlag( ref m_GlobalFlags, OptFlags.TerMur, true );
				SetOptFlag( ref m_GlobalFlags, OptFlags.UseGlobal, true );
			}

			GlobalEntries.Add("Trammel", new TalismanEntry[]
			{
				new TalismanEntry("Britain", new Point3D(1434, 1699, 2), Map.Trammel ),
				new TalismanEntry("Bucs Den", new Point3D(2705, 2162, 0), Map.Trammel ),
				new TalismanEntry("Delucia", new Point3D(5274, 3991, 37), Map.Trammel ),
				new TalismanEntry("Jhelom", new Point3D(1417, 3821, 0), Map.Trammel ),
				//new TAEntry("Lumyr Town", new Point3D(3707, 2185, 20), Map.Trammel ),
                new TalismanEntry("New Haven", new Point3D(3505, 2574, 14), Map.Trammel ),
                new TalismanEntry("Minoc", new Point3D(2525, 582, 0), Map.Trammel ),
				new TalismanEntry("Moonglow", new Point3D(4471, 1177, 0), Map.Trammel ),
				new TalismanEntry("Nujel'm", new Point3D(3770, 1308, 0), Map.Trammel ),
				new TalismanEntry("Papua", new Point3D(5729, 3208, -6), Map.Trammel ),
				new TalismanEntry("Serpents Hold", new Point3D(2895, 3479, 15), Map.Trammel ),
				new TalismanEntry("Skara Brae", new Point3D(596, 2138, 0), Map.Trammel ),
				new TalismanEntry("Trinsic", new Point3D(1823, 2821, 0), Map.Trammel ),
				new TalismanEntry("Vesper", new Point3D(2899, 676, 0), Map.Trammel ),
				new TalismanEntry("Wind", new Point3D(1361, 895, 0), Map.Trammel ),
				new TalismanEntry("Yew", new Point3D(542, 985, 0), Map.Trammel )
	        });

			GlobalEntries.Add("Trammel Dungeons", new TalismanEntry[]
			{
				new TalismanEntry("Covetous", new Point3D(2498, 921, 0), Map.Trammel ),
				new TalismanEntry("Daemon Temple", new Point3D(4591, 3647, 80), Map.Trammel ),
				new TalismanEntry("Deceit", new Point3D(4111, 434, 5), Map.Trammel ),
				new TalismanEntry("Despise", new Point3D(1301, 1080, 0), Map.Trammel ),
				new TalismanEntry("Destard", new Point3D(1176, 2640, 2), Map.Trammel ),
				new TalismanEntry("Fire", new Point3D(2923, 3409, 8), Map.Trammel ),
				new TalismanEntry("Hythloth", new Point3D(4721, 3824, 0), Map.Trammel ),
				new TalismanEntry("Ice", new Point3D(1999, 81, 4), Map.Trammel ),
				new TalismanEntry("Ophidian Temple", new Point3D(5766, 2634, 43), Map.Trammel ),
				new TalismanEntry("Orc Caves", new Point3D(1017, 1429, 0), Map.Trammel ),
				new TalismanEntry("Shame", new Point3D(511, 1565, 0), Map.Trammel ),
				new TalismanEntry("Solen Hive", new Point3D(2607, 763, 0), Map.Trammel ),
				new TalismanEntry("Terathan Keep", new Point3D(5451, 3143, -60), Map.Trammel ),
				new TalismanEntry("Wrong", new Point3D(2043, 238, 10), Map.Trammel )
			});

			GlobalEntries.Add("Felucca", new TalismanEntry[]
			{
				new TalismanEntry("Britain", new Point3D(1434, 1699, 2), Map.Felucca ),
				new TalismanEntry("Bucs Den", new Point3D(2705, 2162, 0), Map.Felucca ),
				new TalismanEntry("Cove", new Point3D(2237, 1214, 0), Map.Felucca ),
				new TalismanEntry("Delucia", new Point3D(5274, 3991, 37), Map.Felucca ),
				new TalismanEntry("Jhelom", new Point3D(1417, 3821, 0), Map.Felucca ),
				new TalismanEntry("Magincia", new Point3D(3728, 2164, 20), Map.Felucca ),
				new TalismanEntry("Minoc", new Point3D(2525, 582, 0), Map.Felucca ),
				new TalismanEntry("Moonglow", new Point3D(4471, 1177, 0), Map.Felucca ),
				new TalismanEntry("Nujel'm", new Point3D(3770, 1308, 0), Map.Felucca ),
				new TalismanEntry("Ocllo", new Point3D(3626, 2611, 0), Map.Felucca ),
				new TalismanEntry("Papua", new Point3D(5729, 3208, -6), Map.Felucca ),
				new TalismanEntry("Serpents Hold", new Point3D(2895, 3479, 15), Map.Felucca ),
				new TalismanEntry("Skara Brae", new Point3D(596, 2138, 0), Map.Felucca ),
				new TalismanEntry("Trinsic", new Point3D(1823, 2821, 0), Map.Felucca ),
				new TalismanEntry("Vesper", new Point3D(2899, 676, 0), Map.Felucca ),
				new TalismanEntry("Wind", new Point3D(1361, 895, 0), Map.Felucca ),
				new TalismanEntry("Yew", new Point3D(542, 985, 0), Map.Felucca )
			});

			GlobalEntries.Add("Felucca Dungeons", new TalismanEntry[]
			{
				new TalismanEntry("Covetous", new Point3D(2498, 921, 0), Map.Felucca ),
				new TalismanEntry("Daemon Temple", new Point3D(4591, 3647, 80), Map.Felucca ),
				new TalismanEntry("Deceit", new Point3D(4111, 434, 5), Map.Felucca ),
				new TalismanEntry("Despise", new Point3D(1301, 1080, 0), Map.Felucca ),
				new TalismanEntry("Destard", new Point3D(1176, 2640, 2), Map.Felucca ),
				new TalismanEntry("Fire", new Point3D(2923, 3409, 8), Map.Felucca ),
				new TalismanEntry("Hythloth", new Point3D(4721, 3824, 0), Map.Felucca ),
				new TalismanEntry("Ice", new Point3D(1999, 81, 4), Map.Felucca ),
				new TalismanEntry("Ophidian Temple", new Point3D(5766, 2634, 43), Map.Felucca ),
				new TalismanEntry("Orc Caves", new Point3D(1017, 1429, 0), Map.Felucca ),
				new TalismanEntry("Shame", new Point3D(511, 1565, 0), Map.Felucca ),
				new TalismanEntry("Solen Hive", new Point3D(2607, 763, 0), Map.Felucca ),
				new TalismanEntry("Terathan Keep", new Point3D(5451, 3143, -60), Map.Felucca ),
				new TalismanEntry("Wrong", new Point3D(2043, 238, 10), Map.Felucca )
			});

			GlobalEntries.Add("Custom Areas", new TalismanEntry[]//add locations to the Custom map here
			{
                new TalismanEntry("Starter Area", new Point3D(5671, 1044, 0), Map.Trammel ),
                new TalismanEntry("Vendor Mall", new Point3D(1012, 466, -90), Map.Malas ),
                new TalismanEntry("Casino", new Point3D(5500, 1153, 1), Map.Trammel ),
				//new TAEntry("Crafters Town", new Point3D(2270, 1213, 0), Map.Trammel ),
				//new TAEntry("The Suburbs", new Point3D(5207, 1181, 0), Map.Trammel ),
			});
            
            GlobalEntries.Add("Ilshenar", new TalismanEntry[]
			{
				new TalismanEntry("Ankh Dungeon", new Point3D(576, 1150, -100), Map.Ilshenar ),
				new TalismanEntry("Blood Dungeon", new Point3D(1747, 1171, -2), Map.Ilshenar ),
				new TalismanEntry("Exodus Dungeon", new Point3D(854, 778, -80), Map.Ilshenar ),
//				new TalismanEntry("Gargoyle City", new Point3D(852, 602, -40), Map.Ilshenar ),
				new TalismanEntry("Lakeshire", new Point3D(1203, 1124, -25), Map.Ilshenar ),
				new TalismanEntry("Mistas", new Point3D(819, 1130, -29), Map.Ilshenar ),
				new TalismanEntry("Montor", new Point3D(1706, 205, 104), Map.Ilshenar ),
				new TalismanEntry("Rock Dungeon", new Point3D(1787, 572, 69), Map.Ilshenar ),
				new TalismanEntry("Savage Camp", new Point3D(1151, 659, -80), Map.Ilshenar ),
				new TalismanEntry("Sorceror's Dungeon", new Point3D(548, 462, -53), Map.Ilshenar ),
				new TalismanEntry("Spectre Dungeon", new Point3D(1363, 1033, -8), Map.Ilshenar ),
				new TalismanEntry("Spider Cave", new Point3D(1420, 913, -16), Map.Ilshenar ),
				new TalismanEntry("Wisp Dungeon", new Point3D(651, 1302, -58), Map.Ilshenar )
			});

            GlobalEntries.Add("Ilshenar Shrines", new TalismanEntry[]
			{
				new TalismanEntry("Compassion Shrine", new Point3D(1215, 467, -13), Map.Ilshenar ),
				new TalismanEntry("Honesty Shrine", new Point3D(722, 1366, -60), Map.Ilshenar ),
				new TalismanEntry("Honor Shrine", new Point3D(744, 724, -28), Map.Ilshenar ),
				new TalismanEntry("Humility Shrine", new Point3D(281, 1016, 0), Map.Ilshenar ),
				new TalismanEntry("Justice Shrine", new Point3D(987, 1011, -32), Map.Ilshenar ),
				new TalismanEntry("Sacrifice Shrine", new Point3D(1174, 1286, -30), Map.Ilshenar ),
				new TalismanEntry("Spirituality Shrine", new Point3D(1532, 1340, -3), Map.Ilshenar ),
				new TalismanEntry("Valor Shrine", new Point3D(528, 216, -45), Map.Ilshenar ),
				new TalismanEntry("Choas Shrine", new Point3D(1721, 218, 96), Map.Ilshenar )
			});

            GlobalEntries.Add("Malas", new TalismanEntry[]
			{
				new TalismanEntry("Doom", new Point3D(2368, 1267, -85), Map.Malas ),
				new TalismanEntry("Luna", new Point3D(1015, 527, -65), Map.Malas ),
				new TalismanEntry("Orc Fort 1", new Point3D(912, 215, -90), Map.Malas ),
				new TalismanEntry("Orc Fort 2", new Point3D(1678, 374, -50), Map.Malas ),
				new TalismanEntry("Orc Fort 3", new Point3D(1375, 621, -86), Map.Malas ),
				new TalismanEntry("Orc Fort 4", new Point3D(1184, 715, -89), Map.Malas ),
				new TalismanEntry("Orc Fort 5", new Point3D(1279, 1324, -90), Map.Malas ),
				new TalismanEntry("Orc Fort 6", new Point3D(1598, 1834, -107), Map.Malas ),
				new TalismanEntry("Ruined Temple", new Point3D(1598, 1762, -110), Map.Malas ),
				new TalismanEntry("Umbra", new Point3D(1997, 1386, -85), Map.Malas )
			});

            GlobalEntries.Add("Tokuno", new TalismanEntry[]
			{
				new TalismanEntry("Bushido Dojo", new Point3D(322, 430, 32), Map.Tokuno ),
				new TalismanEntry("Crane Marsh", new Point3D(203, 985, 18), Map.Tokuno ),
				new TalismanEntry("Fan Dancer's Dojo", new Point3D(970, 222, 23), Map.Tokuno ),
				new TalismanEntry("Isamu-Jima", new Point3D(1169, 998, 41), Map.Tokuno ),
				new TalismanEntry("Makoto-Jima", new Point3D(802, 1204, 25), Map.Tokuno ),
				new TalismanEntry("Homare-Jima", new Point3D(270, 628, 15), Map.Tokuno ),
				new TalismanEntry("Makoto Desert", new Point3D(724, 1050, 33), Map.Tokuno ),
				new TalismanEntry("Makoto Zento", new Point3D(741, 1261, 30), Map.Tokuno ),
				new TalismanEntry("Mt. Sho Castle", new Point3D(1234, 772, 3), Map.Tokuno ),
				new TalismanEntry("Valor Shrine", new Point3D(1044, 523, 15), Map.Tokuno ),
				new TalismanEntry("Yomotsu Mine", new Point3D(257, 786, 63), Map.Tokuno )
			});

            GlobalEntries.Add("Staff", new TalismanEntry[]//add locations to the staff map here
			{
				new TalismanEntry("Green Acres tram", new Point3D(5445, 1153, 0), Map.Trammel ),
				new TalismanEntry("Green Acres fel", new Point3D(5445, 1153, 0), Map.Felucca ),
				new TalismanEntry("Jail tram", new Point3D(5296, 1173, 0), Map.Trammel ),
				new TalismanEntry("Jail fel", new Point3D(5296, 1173, 0), Map.Felucca ),
				new TalismanEntry("Star Room tram", new Point3D(5146, 1774, 0), Map.Trammel ),
				new TalismanEntry("Star Room fel", new Point3D(5146, 1774, 0), Map.Felucca ),
                new TalismanEntry("---------------", new Point3D(0, 0, 0), Map.Trammel ),
                new TalismanEntry("Addon Creations", new Point3D(5125, 2293, 0), Map.Felucca ),
            });
            
		}
			
		public static int GenerateTalismanTravelAtlas()
		{
			int gen = 0;

			if (GetOptFlag( m_GlobalFlags, OptFlags.Trammel )) gen += GenerateEntry( "Trammel" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.TramDungeons )) gen += GenerateEntry( "Trammel Dungeons" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.Felucca )) gen += GenerateEntry( "Felucca" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.FelDungeons )) gen += GenerateEntry( "Felucca Dungeons" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.Custom)) gen += GenerateEntry( "Custom Areas" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.Ilshenar)) gen += GenerateEntry( "Ilshenar" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.IlshenarShrines)) gen += GenerateEntry( "Ilshenar Shrines" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.Malas) && Core.AOS) gen += GenerateEntry( "Malas" );
			if (GetOptFlag( m_GlobalFlags, OptFlags.Tokuno) && Core.SE) gen += GenerateEntry( "Tokuno" );

			gen += GenerateEntry( "Staff" );

			return gen;
		}		

		private static int GenerateEntry( string map )
		{
            TalismanEntry[] me = (TalismanEntry[])GlobalEntries[map];
			if ( me != null )
			{
				for (int i = 0; i < me.Length; i++)
					new TalismanTravelAtlas().MoveToWorld( me[i].Destination, me[i].Map );
				return me.Length;
			}
			return 0;
		}

		public static Hashtable GlobalEntries = new Hashtable();
		private OptFlags m_Flags;
		private static OptFlags m_GlobalFlags;

		[CommandProperty(AccessLevel.Administrator)]
		public bool Trammel{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.Trammel ); } set{ SetOptFlag( OptFlags.Trammel, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool TramDungeons{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.TramDungeons ); } set{ SetOptFlag( OptFlags.TramDungeons, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool Felucca{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.Felucca ); } set{ SetOptFlag( OptFlags.Felucca, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool FelDungeons{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.FelDungeons ); } set{ SetOptFlag( OptFlags.FelDungeons, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool Custom{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.Custom ); } set{ SetOptFlag( OptFlags.Custom, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool Ilshenar{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.Ilshenar ); } set{ SetOptFlag( OptFlags.Ilshenar, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool IlshenarShrines{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.IlshenarShrines ); } set{ SetOptFlag( OptFlags.IlshenarShrines, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool Malas{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.Malas ); } set{ SetOptFlag( OptFlags.Malas, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool Tokuno{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.Tokuno ); } set{ SetOptFlag( OptFlags.Tokuno, value ); } }

		[CommandProperty(AccessLevel.Administrator)]
		public bool AllowReds{ get{ return GetOptFlag( (UseGlobal ? m_GlobalFlags : m_Flags), OptFlags.AllowReds ); } set{ SetOptFlag( OptFlags.AllowReds, value ); } }
        
		[CommandProperty(AccessLevel.Administrator)]
		public bool UseGlobal{ get{ return GetOptFlag( m_Flags, OptFlags.UseGlobal ); } set{ SetOptFlag( ref m_Flags, OptFlags.UseGlobal, value ); } }

		public void SetOptFlag( OptFlags toSet, bool value )
		{
			if ( UseGlobal )
			{
				if ( value )
					m_GlobalFlags |= toSet;
				else
					m_GlobalFlags &= ~toSet;
			}
			else
			{
				if ( value )
					m_Flags |= toSet;
				else
					m_Flags &= ~toSet;
			}
		}

		public static void SetOptFlag( ref OptFlags flags, OptFlags toSet, bool value )
		{
			if ( value )
				flags |= toSet;
			else
				flags &= ~toSet;
		}

		public static bool GetOptFlag( OptFlags flags, OptFlags flag )
		{
			return ( (flags & flag) != 0 );
		}

		[Constructable]
		public TalismanTravelAtlas() : this ( (int)m_GlobalFlags )
		{
		}

		[Constructable]
		public TalismanTravelAtlas( int flags ) : base(0x2F5B)
		{
			Movable = true;
			LootType = LootType.Blessed;
			Hue = 38;
			Name = "Talisman of Travel";
			Light = LightType.Circle300;
			m_Flags = (OptFlags)flags;
            //Attributes.Luck = 500;
        }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !from.Player )
				return;
			UseTeleporter(from);
		}

		public bool UseTeleporter( Mobile m )
		{
			if ( m.Criminal )
				m.SendLocalizedMessage( 1005561, "", 0x22 ); // Thou'rt a criminal and cannot escape so easily.
			else if ( Server.Spells.SpellHelper.CheckCombat( m ) )
				m.SendLocalizedMessage( 1005564, "", 0x22 ); // Wouldst thou flee during the heat of battle??
			else if ( m.Spell != null )
				m.SendLocalizedMessage( 1049616 ); // You are too busy to do that at the moment.
			else
			{
				m.CloseGump( typeof(TalismanTravelAtlasGump) );
				m.SendGump( new TalismanTravelAtlasGump( m, this, 0 ) );

				if ( !m.Hidden || m.AccessLevel == AccessLevel.Player )
					Effects.PlaySound( m.Location, m.Map, 0x20E );
				return true;
			}
			return false;
		}

		public TalismanTravelAtlas( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 2 ); // version

			//version 2
			writer.Write( (int) m_Flags );
			writer.Write( (int) m_GlobalFlags );

		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			switch (version)
			{
				case 2:
				{
					m_Flags = (OptFlags)reader.ReadInt();
					m_GlobalFlags = (OptFlags)reader.ReadInt();
					break;
				}
				case 1:
				{
					SetOptFlag( ref m_Flags, OptFlags.IlshenarShrines, reader.ReadBool() );
					goto case 0;
				}
				case 0:
				{
					SetOptFlag( ref m_Flags, OptFlags.Trammel, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.TramDungeons, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.Felucca, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.FelDungeons, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.Custom, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.Ilshenar, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.Malas, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.Tokuno, reader.ReadBool() );
					SetOptFlag( ref m_Flags, OptFlags.AllowReds, reader.ReadBool() );
					UseGlobal = false;
					break;
				}
			}
		}
	}

	public class TalismanTravelAtlasGump : Gump
	{
		private TalismanTravelAtlas m_TalismanTravelAtlas;
		private int m_Page;
		private bool m_Reds, m_HasLBR, m_HasAOS, m_HasSE;

		public TalismanTravelAtlasGump( Mobile from, TalismanTravelAtlas TA, int page ) : base( 100, 100 )
		{
			ClientFlags flags = (from.NetState == null ? ClientFlags.None : from.NetState.Flags);

            m_TalismanTravelAtlas = TA;
			m_Page = page;
			 m_HasLBR = ((int)flags & 0x04) != 0;
   			m_HasAOS = ((int)flags & 0x08) != 0;
   			m_HasSE = ((int)flags & 0x10) != 0;
			m_Reds = (from.Kills < 5 || TA.AllowReds);

			//Did they press an invalid button or supply an invalid argument?
			if ( page < 0 || page > 11 )
				page = 0;

			AddPage( 0 );
			AddBackground( 0, 0, 660, 404, 3500 ); //white

			AddImage(267, 10, 5528); // map
			AddImage(45, 30, 5609); // globe

			AddHtmlLocalized( 10, 10, 200, 20, 1012011, false, false ); // Pick your destination:

			int p = 1;

			if ( TA.Trammel && m_Reds )
			{
				GenerateMapListing( 1 );
				AddPageButton( "Trammel", Map.Trammel, p++, 1 );
			}

			if ( TA.TramDungeons && m_Reds )
			{
				GenerateMapListing( 2 );
				AddPageButton( "Trammel Dungeons", Map.Trammel, p++, 2 );
			}

			if ( TA.Felucca )
			{
				GenerateMapListing( 3 );
				AddPageButton( "Felucca", Map.Felucca, p++, 3 );
			}

			if ( TA.FelDungeons )
			{
				GenerateMapListing( 4 );
				AddPageButton( "Felucca Dungeons", Map.Felucca, p++, 4 );
			}

			if ( TA.Custom && m_Reds && Core.AOS && m_HasAOS )
			{
				GenerateMapListing( 5 );
				AddPageButton( "<basefont color=#0000FF>Custom <basefont color=#FF0000>Areas</basefont>", null, p++, 5 );
			}

			if ( TA.Ilshenar && m_Reds && m_HasLBR )
			{
				GenerateMapListing( 6 );
				AddPageButton( "Ilshenar", Map.Ilshenar, p++, 6 );
			}

			if ( TA.IlshenarShrines && m_Reds && m_HasLBR )
			{
				GenerateMapListing( 7 );
				AddPageButton( "Ilshenar Shrines", Map.Ilshenar, p++, 7 );
			}

			if ( TA.Malas && m_Reds && Core.AOS && m_HasAOS )
			{
				GenerateMapListing( 8 );
				AddPageButton( "Malas", Map.Malas, p++, 8 );
			}

			if ( TA.Tokuno && m_Reds && Core.SE && m_HasSE )
			{
				GenerateMapListing( 9 );
				AddPageButton( "Tokuno", Map.Tokuno, p++, 9 );
			}

			if ( from.AccessLevel > AccessLevel.Player )
			{
				GenerateMapListing( 10 );
				AddPageButton( "Staff Only", null, p++, 10 );
			}
		}

		private void AddPageButton( string text, Map map, int offset, int page )
		{
			string label;
			if ( map != null )
				label = String.Format( "<basefont color=#{0}>{1}</basefont>", MapHue( map ), text );
			else
				label = text;
			AddHtml( 30, 100 + ((offset - 1) * 25), 150, 20, label, false, false );
			AddButton( 10, 100 + ((offset - 1) * 25), 2117, 2118, page, GumpButtonType.Reply, 0 );
		}

		private static TalismanEntry GetEntry( string name, int id )
		{
            TalismanEntry[] me = (TalismanEntry[])TalismanTravelAtlas.GlobalEntries[name];

			if ( me != null )
			{
				if ( id < 0 || id >= me.Length )
					id = 0;
				return me[id];
			}

			return null;
		}

		private void GenerateMapListing( int page )
		{
			if ( m_Page == 0 )
				m_Page = page;
			else if ( page != m_Page )
				return;

			string name = m_Entries[page-1];

            TalismanEntry[] me = (TalismanEntry[])TalismanTravelAtlas.GlobalEntries[name];
			if ( me == null )
				return;

			int offset = m_Page * 100;
			bool gates = name == "Custom Areas";
			for (int i = 0, l = 0; i < me.Length; i++ )
			{
                TalismanEntry entry = me[i];

				if ( ( (gates || name == "Felucca") && entry.Map == Map.Felucca && !m_TalismanTravelAtlas.Felucca) )
					continue;
				else if ( (gates || name == "Trammel") && entry.Map == Map.Trammel && (!m_TalismanTravelAtlas.Trammel || !m_Reds))
					continue;
				else if ( entry.Map == Map.Ilshenar && (!m_TalismanTravelAtlas.Ilshenar || !m_HasLBR || !m_Reds))
					continue;
				else if (entry.Map == Map.Malas && (!Core.AOS || !m_HasAOS || !m_TalismanTravelAtlas.Malas || !m_Reds))
					continue;
				else if (entry.Map == Map.Tokuno && (!Core.SE || !m_HasSE || !m_TalismanTravelAtlas.Tokuno || !m_Reds))
					continue;
				else
				{
					string label = String.Format( "<basefont color=#{0}>{1}</basefont>", MapHue( entry.Map ), entry.Name );
					AddHtml( 180, 20+(l*20), 150, 20, label, false, false );
					AddButton( 145, 20+(l*20), 4015, 4016, (i+offset), GumpButtonType.Reply, 0 );
					l++;
				}
			}
		}

		private string MapHue( Map map )
		{
			if ( map == null )
				return "101010";
			if ( map == Map.Felucca )
				return "FF0000";
			else if ( map == Map.Trammel )
				return "0000FF";
			else if ( map == Map.Ilshenar )
				return "008000";
			else if ( map == Map.Malas )
				return "FFFFFF";
			else
				return "FF00FF";
		}

		private static string[] m_Entries = new string[]
		{
			"Trammel", "Trammel Dungeons", "Felucca", "Felucca Dungeons",
			"Custom Areas", "Ilshenar", "Ilshenar Shrines", "Malas",
			"Tokuno", "Staff"
		};

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;

			if ( info.ButtonID <= 0 || from == null || from.Deleted || m_TalismanTravelAtlas == null || m_TalismanTravelAtlas.Deleted )
				return;

			int id = info.ButtonID / 100;
			int count = info.ButtonID % 100;

			if ( id == 0 && count < 12 )
			{
				from.SendGump( new TalismanTravelAtlasGump( from, m_TalismanTravelAtlas, count ) );
				return;
			}

			//Invalid checks
			if ( id < 1 || id > 11 || (id == 10 && from.AccessLevel < AccessLevel.GameMaster) )
				id = 1;

			string name = m_Entries[id-1];

            TalismanEntry entry = GetEntry( name, count );

			bool gates = name == "Custom Areas";

			if ( entry == null )
				from.SendMessage( "Error: Invalid Button Response - No Map Entries" );
			else if ( ( (gates || name == "Felucca") && entry.Map == Map.Felucca && !m_TalismanTravelAtlas.Felucca) )
				from.SendMessage( "Error: Invalid Button Response - Felucca Disabled" );
			else if ( (gates || name == "Trammel") && entry.Map == Map.Trammel && (!m_TalismanTravelAtlas.Trammel || !m_Reds))
				from.SendMessage( "Error: Invalid Button Response - Trammel Disabled" );
			else if ( (name == "Ilshenar" ) && entry.Map == Map.Ilshenar && (!m_TalismanTravelAtlas.Ilshenar || !m_HasLBR || !m_Reds))
				from.SendMessage( "Error: Invalid Button Response - Ilshenar Disabled" );
			else if (entry.Map == Map.Malas && (!Core.AOS || !m_HasAOS || !m_TalismanTravelAtlas.Malas || !m_Reds))
				from.SendMessage( "Error: Invalid Button Response - Malas Disabled" );
			else if (entry.Map == Map.Tokuno && (!Core.SE || !m_HasSE || !m_TalismanTravelAtlas.Tokuno || !m_Reds))
				from.SendMessage( "Error: Invalid Button Response - Tokuno Disabled" );
			else if ( !from.InRange(m_TalismanTravelAtlas.GetWorldLocation(), 1 ) || from.Map != m_TalismanTravelAtlas.Map )
				from.SendLocalizedMessage( 1019002 ); // You are too far away to use the gate.
			else if ( from.Criminal )
				from.SendLocalizedMessage( 1005561, "", 0x22 ); // Thou'rt a criminal and cannot escape so easily.
			else if ( Server.Spells.SpellHelper.CheckCombat( from ) )
				from.SendLocalizedMessage( 1005564, "", 0x22 ); // Wouldst thou flee during the heat of battle??
			else if ( from.Spell != null )
				from.SendLocalizedMessage( 1049616 ); // You are too busy to do that at the moment.
			else if ( from.Map == entry.Map && from.InRange( entry.Destination, 1 ) )
				from.SendLocalizedMessage( 1019003 ); // You are already there.
			else
			{
				BaseCreature.TeleportPets( from, entry.Destination, entry.Map );

				from.Combatant = null;

				from.MoveToWorld( entry.Destination, entry.Map );

				if ( !from.Hidden || from.AccessLevel == AccessLevel.Player )
					Effects.PlaySound( entry.Destination, entry.Map, 0x1FE );
			}
		}
	}
    public class TalismanEntry
    {
        private string m_Name;
        private Point3D m_Destination;
        private Map m_Map;

        public string Name { get { return m_Name; } }
        public Point3D Destination { get { return m_Destination; } }
        public Map Map { get { return m_Map; } }

        public TalismanEntry(string name, Point3D p, Map map)
        {
            m_Name = name;
            m_Destination = p;
            m_Map = map;
        }
    }
}
