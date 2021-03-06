
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BoatslipNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {944, -3, 8, 0}, {944, -7, 8, 0}, {944, -2, -1, 0}// 86	87	180	
			, {944, 3, -1, 0}, {944, 8, -1, 0}, {944, 8, -5, 0}// 181	182	183	
			, {944, 8, 8, 0}, {944, 4, 8, 0}// 221	222	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BoatslipNSAddonDeed();
			}
		}

		[ Constructable ]
		public BoatslipNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1993, -7, -5, 6, 0, -1, "(1,1993): -7, -5, 0", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1993, -7, -4, 6, 0, -1, "(2,1993): -7, -4, 0", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1993, -7, -3, 6, 0, -1, "(3,1993): -7, -3, 0", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1993, -7, -2, 6, 0, -1, "(4,1993): -7, -2, 0", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1993, -7, -1, 6, 0, -1, "(5,1993): -7, -1, 0", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1993, -7, 0, 6, 0, -1, "(11,1993): -7, 0, 0", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1993, -7, 1, 6, 0, -1, "(12,1993): -7, 1, 0", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1993, -7, 2, 6, 0, -1, "(13,1993): -7, 2, 0", 1);// 8
			AddComplexComponent( (BaseAddon) this, 938, -7, -5, 6, 0, -1, "(27,938): -7, -5, 0", 1);// 9
			AddComplexComponent( (BaseAddon) this, 938, -7, -1, 6, 0, -1, "(28,938): -7, -1, 0", 1);// 10
			AddComplexComponent( (BaseAddon) this, 935, -7, -4, 7, 0, -1, "(29,935): -7, -4, 1", 1);// 11
			AddComplexComponent( (BaseAddon) this, 935, -7, -3, 7, 0, -1, "(30,935): -7, -3, 1", 1);// 12
			AddComplexComponent( (BaseAddon) this, 935, -7, -2, 7, 0, -1, "(31,935): -7, -2, 1", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1993, -6, -5, 6, 0, -1, "(6,1993): -6, -5, 0", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1993, -6, -4, 6, 0, -1, "(7,1993): -6, -4, 0", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1993, -6, -3, 6, 0, -1, "(8,1993): -6, -3, 0", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1993, -6, -2, 6, 0, -1, "(9,1993): -6, -2, 0", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1993, -6, -1, 6, 0, -1, "(10,1993): -6, -1, 0", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1993, -6, 0, 6, 0, -1, "(19,1993): -6, 0, 0", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1993, -6, 1, 6, 0, -1, "(20,1993): -6, 1, 0", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1993, -6, 2, 6, 0, -1, "(21,1993): -6, 2, 0", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3703, -6, -4, 7, 0, -1, "(32,3703): -6, -4, 1", 1);// 22
			AddComplexComponent( (BaseAddon) this, 3703, -6, -3, 7, 0, -1, "(33,3703): -6, -3, 1", 1);// 23
			AddComplexComponent( (BaseAddon) this, 3645, -6, -2, 6, 0, -1, "(34,3645): -6, -2, 0", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1993, -5, -5, 6, 0, -1, "(39,1993): -5, -5, 0", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1993, -5, -4, 6, 0, -1, "(40,1993): -5, -4, 0", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1993, -5, -3, 6, 0, -1, "(41,1993): -5, -3, 0", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1993, -5, -2, 6, 0, -1, "(42,1993): -5, -2, 0", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1993, -5, -1, 6, 0, -1, "(43,1993): -5, -1, 0", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1993, -5, 0, 6, 0, -1, "(148,1993): -5, 0, 0", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1993, -5, 1, 6, 0, -1, "(149,1993): -5, 1, 0", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1993, -5, 2, 6, 0, -1, "(150,1993): -5, 2, 0", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1993, -4, -5, 6, 0, -1, "(44,1993): -4, -5, 0", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1993, -4, -4, 6, 0, -1, "(45,1993): -4, -4, 0", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1993, -4, -3, 6, 0, -1, "(46,1993): -4, -3, 0", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1993, -4, -2, 6, 0, -1, "(47,1993): -4, -2, 0", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1993, -4, -1, 6, 0, -1, "(48,1993): -4, -1, 0", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1993, -4, 0, 6, 0, -1, "(156,1993): -4, 0, 0", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1993, -4, 1, 6, 0, -1, "(157,1993): -4, 1, 0", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1993, -4, 2, 6, 0, -1, "(158,1993): -4, 2, 0", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1993, -3, -5, 6, 0, -1, "(49,1993): -3, -5, 0", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1993, -3, -4, 6, 0, -1, "(50,1993): -3, -4, 0", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1993, -3, -3, 6, 0, -1, "(51,1993): -3, -3, 0", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1993, -3, -2, 6, 0, -1, "(52,1993): -3, -2, 0", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1993, -3, -1, 6, 0, -1, "(53,1993): -3, -1, 0", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1993, -3, 0, 6, 0, -1, "(164,1993): -3, 0, 0", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1993, -3, 1, 6, 0, -1, "(165,1993): -3, 1, 0", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1993, -3, 2, 6, 0, -1, "(166,1993): -3, 2, 0", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1993, -7, 3, 6, 0, -1, "(14,1993): -7, 3, 0", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1993, -7, 4, 6, 0, -1, "(15,1993): -7, 4, 0", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1993, -7, 5, 6, 0, -1, "(16,1993): -7, 5, 0", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1993, -7, 6, 6, 0, -1, "(17,1993): -7, 6, 0", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1993, -7, 7, 6, 0, -1, "(18,1993): -7, 7, 0", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1993, -7, 8, 6, 0, -1, "(35,1993): -7, 8, 0", 1);// 54
			AddComplexComponent( (BaseAddon) this, 933, -7, 8, 7, 0, -1, "(37,933): -7, 8, 1", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1993, -6, 3, 6, 0, -1, "(22,1993): -6, 3, 0", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1993, -6, 4, 6, 0, -1, "(23,1993): -6, 4, 0", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1993, -6, 5, 6, 0, -1, "(24,1993): -6, 5, 0", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1993, -6, 6, 6, 0, -1, "(25,1993): -6, 6, 0", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1993, -6, 7, 6, 0, -1, "(26,1993): -6, 7, 0", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1993, -6, 8, 6, 0, -1, "(36,1993): -6, 8, 0", 1);// 61
			AddComplexComponent( (BaseAddon) this, 2918, -6, 8, 6, 0, -1, "(38,2918): -6, 8, 0", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1993, -5, 3, 6, 0, -1, "(151,1993): -5, 3, 0", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1993, -5, 4, 6, 0, -1, "(152,1993): -5, 4, 0", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1993, -5, 5, 6, 0, -1, "(153,1993): -5, 5, 0", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1993, -5, 6, 6, 0, -1, "(154,1993): -5, 6, 0", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1993, -5, 7, 6, 0, -1, "(155,1993): -5, 7, 0", 1);// 67
			AddComplexComponent( (BaseAddon) this, 3520, -5, 6, 6, 0, -1, "(184,3520): -5, 6, 0", 1);// 68
			AddComplexComponent( (BaseAddon) this, 3530, -5, 3, 6, 0, -1, "(187,3530): -5, 3, 0", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1993, -5, 8, 6, 0, -1, "(199,1993): -5, 8, 0", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2919, -5, 8, 6, 0, -1, "(212,2919): -5, 8, 0", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1993, -4, 3, 6, 0, -1, "(159,1993): -4, 3, 0", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1993, -4, 4, 6, 0, -1, "(160,1993): -4, 4, 0", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1993, -4, 5, 6, 0, -1, "(161,1993): -4, 5, 0", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1993, -4, 6, 6, 0, -1, "(162,1993): -4, 6, 0", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1993, -4, 7, 6, 0, -1, "(163,1993): -4, 7, 0", 1);// 76
			AddComplexComponent( (BaseAddon) this, 1993, -4, 8, 6, 0, -1, "(200,1993): -4, 8, 0", 1);// 77
			AddComplexComponent( (BaseAddon) this, 2917, -4, 8, 6, 0, -1, "(211,2917): -4, 8, 0", 1);// 78
			AddComplexComponent( (BaseAddon) this, 1993, -3, 3, 6, 0, -1, "(167,1993): -3, 3, 0", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1993, -3, 4, 6, 0, -1, "(168,1993): -3, 4, 0", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1993, -3, 5, 6, 0, -1, "(169,1993): -3, 5, 0", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1993, -3, 6, 6, 0, -1, "(170,1993): -3, 6, 0", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1993, -3, 7, 6, 0, -1, "(171,1993): -3, 7, 0", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1993, -3, 8, 6, 0, -1, "(201,1993): -3, 8, 0", 1);// 84
			AddComplexComponent( (BaseAddon) this, 933, -3, 8, 6, 0, -1, "(207,933): -3, 8, 0", 1);// 85
			AddComplexComponent( (BaseAddon) this, 1993, -2, -5, 6, 0, -1, "(54,1993): -2, -5, 0", 1);// 88
			AddComplexComponent( (BaseAddon) this, 1993, -2, -4, 6, 0, -1, "(55,1993): -2, -4, 0", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1993, -2, -3, 6, 0, -1, "(56,1993): -2, -3, 0", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1993, -2, -2, 6, 0, -1, "(57,1993): -2, -2, 0", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1993, -2, -1, 6, 0, -1, "(58,1993): -2, -1, 0", 1);// 92
			AddComplexComponent( (BaseAddon) this, 1993, -1, -5, 6, 0, -1, "(59,1993): -1, -5, 0", 1);// 93
			AddComplexComponent( (BaseAddon) this, 1993, -1, -4, 6, 0, -1, "(60,1993): -1, -4, 0", 1);// 94
			AddComplexComponent( (BaseAddon) this, 1993, -1, -3, 6, 0, -1, "(61,1993): -1, -3, 0", 1);// 95
			AddComplexComponent( (BaseAddon) this, 1993, -1, -2, 6, 0, -1, "(62,1993): -1, -2, 0", 1);// 96
			AddComplexComponent( (BaseAddon) this, 1993, -1, -1, 6, 0, -1, "(63,1993): -1, -1, 0", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1993, 0, -5, 6, 0, -1, "(64,1993): 0, -5, 0", 1);// 98
			AddComplexComponent( (BaseAddon) this, 1993, 0, -4, 6, 0, -1, "(65,1993): 0, -4, 0", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1993, 0, -3, 6, 0, -1, "(66,1993): 0, -3, 0", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1993, 0, -2, 6, 0, -1, "(67,1993): 0, -2, 0", 1);// 101
			AddComplexComponent( (BaseAddon) this, 1993, 0, -1, 6, 0, -1, "(68,1993): 0, -1, 0", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1993, 1, -5, 6, 0, -1, "(69,1993): 1, -5, 0", 1);// 103
			AddComplexComponent( (BaseAddon) this, 1993, 1, -4, 6, 0, -1, "(70,1993): 1, -4, 0", 1);// 104
			AddComplexComponent( (BaseAddon) this, 1993, 1, -3, 6, 0, -1, "(71,1993): 1, -3, 0", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1993, 1, -2, 6, 0, -1, "(72,1993): 1, -2, 0", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1993, 1, -1, 6, 0, -1, "(73,1993): 1, -1, 0", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1993, 2, -5, 6, 0, -1, "(74,1993): 2, -5, 0", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1993, 2, -4, 6, 0, -1, "(75,1993): 2, -4, 0", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1993, 2, -3, 6, 0, -1, "(76,1993): 2, -3, 0", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1993, 2, -2, 6, 0, -1, "(77,1993): 2, -2, 0", 1);// 111
			AddComplexComponent( (BaseAddon) this, 1993, 2, -1, 6, 0, -1, "(78,1993): 2, -1, 0", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1993, 3, -5, 6, 0, -1, "(79,1993): 3, -5, 0", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1993, 3, -4, 6, 0, -1, "(80,1993): 3, -4, 0", 1);// 114
			AddComplexComponent( (BaseAddon) this, 1993, 3, -3, 6, 0, -1, "(81,1993): 3, -3, 0", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1993, 3, -2, 6, 0, -1, "(82,1993): 3, -2, 0", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1993, 4, -5, 6, 0, -1, "(83,1993): 4, -5, 0", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1993, 4, -4, 6, 0, -1, "(84,1993): 4, -4, 0", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1993, 4, -3, 6, 0, -1, "(85,1993): 4, -3, 0", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1993, 4, -2, 6, 0, -1, "(86,1993): 4, -2, 0", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1993, 5, -5, 6, 0, -1, "(87,1993): 5, -5, 0", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1993, 5, -4, 6, 0, -1, "(88,1993): 5, -4, 0", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1993, 5, -3, 6, 0, -1, "(89,1993): 5, -3, 0", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1993, 5, -2, 6, 0, -1, "(90,1993): 5, -2, 0", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1993, 6, -5, 6, 0, -1, "(91,1993): 6, -5, 0", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1993, 6, -4, 6, 0, -1, "(92,1993): 6, -4, 0", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1993, 6, -3, 6, 0, -1, "(93,1993): 6, -3, 0", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1993, 6, -2, 6, 0, -1, "(94,1993): 6, -2, 0", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1993, 7, -5, 6, 0, -1, "(95,1993): 7, -5, 0", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1993, 7, -4, 6, 0, -1, "(96,1993): 7, -4, 0", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1993, 7, -3, 6, 0, -1, "(97,1993): 7, -3, 0", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1993, 7, -2, 6, 0, -1, "(98,1993): 7, -2, 0", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1993, 8, -5, 6, 0, -1, "(99,1993): 8, -5, 0", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1993, 8, -4, 6, 0, -1, "(100,1993): 8, -4, 0", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1993, 8, -3, 6, 0, -1, "(101,1993): 8, -3, 0", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1993, 8, -2, 6, 0, -1, "(102,1993): 8, -2, 0", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1993, 4, -1, 6, 0, -1, "(103,1993): 4, -1, 0", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1993, 4, 0, 6, 0, -1, "(104,1993): 4, 0, 0", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1993, 4, 1, 6, 0, -1, "(105,1993): 4, 1, 0", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1993, 4, 2, 6, 0, -1, "(106,1993): 4, 2, 0", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1993, 5, -1, 6, 0, -1, "(112,1993): 5, -1, 0", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1993, 5, 0, 6, 0, -1, "(113,1993): 5, 0, 0", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1993, 5, 1, 6, 0, -1, "(114,1993): 5, 1, 0", 1);// 143
			AddComplexComponent( (BaseAddon) this, 1993, 5, 2, 6, 0, -1, "(115,1993): 5, 2, 0", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1993, 6, -1, 6, 0, -1, "(121,1993): 6, -1, 0", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1993, 6, 0, 6, 0, -1, "(122,1993): 6, 0, 0", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1993, 6, 1, 6, 0, -1, "(123,1993): 6, 1, 0", 1);// 147
			AddComplexComponent( (BaseAddon) this, 1993, 6, 2, 6, 0, -1, "(124,1993): 6, 2, 0", 1);// 148
			AddComplexComponent( (BaseAddon) this, 1993, 7, -1, 6, 0, -1, "(130,1993): 7, -1, 0", 1);// 149
			AddComplexComponent( (BaseAddon) this, 1993, 7, 0, 6, 0, -1, "(131,1993): 7, 0, 0", 1);// 150
			AddComplexComponent( (BaseAddon) this, 1993, 7, 1, 6, 0, -1, "(132,1993): 7, 1, 0", 1);// 151
			AddComplexComponent( (BaseAddon) this, 1993, 7, 2, 6, 0, -1, "(133,1993): 7, 2, 0", 1);// 152
			AddComplexComponent( (BaseAddon) this, 1993, 8, -1, 6, 0, -1, "(139,1993): 8, -1, 0", 1);// 153
			AddComplexComponent( (BaseAddon) this, 1993, 8, 0, 6, 0, -1, "(140,1993): 8, 0, 0", 1);// 154
			AddComplexComponent( (BaseAddon) this, 1993, 8, 1, 6, 0, -1, "(141,1993): 8, 1, 0", 1);// 155
			AddComplexComponent( (BaseAddon) this, 1993, 8, 2, 6, 0, -1, "(142,1993): 8, 2, 0", 1);// 156
			AddComplexComponent( (BaseAddon) this, 934, -1, -1, 7, 0, -1, "(172,934): -1, -1, 1", 1);// 157
			AddComplexComponent( (BaseAddon) this, 934, 0, -1, 7, 0, -1, "(173,934): 0, -1, 1", 1);// 158
			AddComplexComponent( (BaseAddon) this, 934, 1, -1, 7, 0, -1, "(174,934): 1, -1, 1", 1);// 159
			AddComplexComponent( (BaseAddon) this, 934, 2, -1, 7, 0, -1, "(175,934): 2, -1, 1", 1);// 160
			AddComplexComponent( (BaseAddon) this, 939, -2, -1, 6, 0, -1, "(176,939): -2, -1, 0", 1);// 161
			AddComplexComponent( (BaseAddon) this, 1993, 3, -1, 6, 0, -1, "(177,1993): 3, -1, 0", 1);// 162
			AddComplexComponent( (BaseAddon) this, 938, 3, -1, 6, 0, -1, "(178,938): 3, -1, 0", 1);// 163
			AddComplexComponent( (BaseAddon) this, 938, 8, -5, 6, 0, -1, "(179,938): 8, -5, 0", 1);// 164
			AddComplexComponent( (BaseAddon) this, 937, 8, -4, 7, 0, -1, "(180,937): 8, -4, 1", 1);// 165
			AddComplexComponent( (BaseAddon) this, 937, 8, -3, 7, 0, -1, "(181,937): 8, -3, 1", 1);// 166
			AddComplexComponent( (BaseAddon) this, 937, 8, -2, 7, 0, -1, "(182,937): 8, -2, 1", 1);// 167
			AddComplexComponent( (BaseAddon) this, 938, 8, -1, 6, 0, -1, "(183,938): 8, -1, 0", 1);// 168
			AddComplexComponent( (BaseAddon) this, 3703, 8, -3, 6, 0, -1, "(188,3703): 8, -3, 0", 1);// 169
			AddComplexComponent( (BaseAddon) this, 3703, 8, -2, 6, 0, -1, "(189,3703): 8, -2, 0", 1);// 170
			AddComplexComponent( (BaseAddon) this, 3645, 8, -4, 6, 0, -1, "(190,3645): 8, -4, 0", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1993, -1, -6, 6, 0, -1, "(191,1993): -1, -6, 0", 1);// 172
			AddComplexComponent( (BaseAddon) this, 1993, 0, -6, 6, 0, -1, "(192,1993): 0, -6, 0", 1);// 173
			AddComplexComponent( (BaseAddon) this, 1993, 1, -6, 6, 0, -1, "(193,1993): 1, -6, 0", 1);// 174
			AddComplexComponent( (BaseAddon) this, 1993, 2, -6, 6, 0, -1, "(194,1993): 2, -6, 0", 1);// 175
			AddComplexComponent( (BaseAddon) this, 1993, -1, -7, 6, 0, -1, "(195,1993): -1, -7, 0", 1);// 176
			AddComplexComponent( (BaseAddon) this, 1993, 0, -7, 6, 0, -1, "(196,1993): 0, -7, 0", 1);// 177
			AddComplexComponent( (BaseAddon) this, 1993, 1, -7, 6, 0, -1, "(197,1993): 1, -7, 0", 1);// 178
			AddComplexComponent( (BaseAddon) this, 1993, 2, -7, 6, 0, -1, "(198,1993): 2, -7, 0", 1);// 179
			AddComplexComponent( (BaseAddon) this, 1993, 4, 3, 6, 0, -1, "(107,1993): 4, 3, 0", 1);// 184
			AddComplexComponent( (BaseAddon) this, 1993, 4, 4, 6, 0, -1, "(108,1993): 4, 4, 0", 1);// 185
			AddComplexComponent( (BaseAddon) this, 1993, 4, 5, 6, 0, -1, "(109,1993): 4, 5, 0", 1);// 186
			AddComplexComponent( (BaseAddon) this, 1993, 4, 6, 6, 0, -1, "(110,1993): 4, 6, 0", 1);// 187
			AddComplexComponent( (BaseAddon) this, 1993, 4, 7, 6, 0, -1, "(111,1993): 4, 7, 0", 1);// 188
			AddComplexComponent( (BaseAddon) this, 1993, 5, 3, 6, 0, -1, "(116,1993): 5, 3, 0", 1);// 189
			AddComplexComponent( (BaseAddon) this, 1993, 5, 4, 6, 0, -1, "(117,1993): 5, 4, 0", 1);// 190
			AddComplexComponent( (BaseAddon) this, 1993, 5, 5, 6, 0, -1, "(118,1993): 5, 5, 0", 1);// 191
			AddComplexComponent( (BaseAddon) this, 1993, 5, 6, 6, 0, -1, "(119,1993): 5, 6, 0", 1);// 192
			AddComplexComponent( (BaseAddon) this, 1993, 5, 7, 6, 0, -1, "(120,1993): 5, 7, 0", 1);// 193
			AddComplexComponent( (BaseAddon) this, 1993, 6, 3, 6, 0, -1, "(125,1993): 6, 3, 0", 1);// 194
			AddComplexComponent( (BaseAddon) this, 1993, 6, 4, 6, 0, -1, "(126,1993): 6, 4, 0", 1);// 195
			AddComplexComponent( (BaseAddon) this, 1993, 6, 5, 6, 0, -1, "(127,1993): 6, 5, 0", 1);// 196
			AddComplexComponent( (BaseAddon) this, 1993, 6, 6, 6, 0, -1, "(128,1993): 6, 6, 0", 1);// 197
			AddComplexComponent( (BaseAddon) this, 1993, 6, 7, 6, 0, -1, "(129,1993): 6, 7, 0", 1);// 198
			AddComplexComponent( (BaseAddon) this, 1993, 7, 3, 6, 0, -1, "(134,1993): 7, 3, 0", 1);// 199
			AddComplexComponent( (BaseAddon) this, 1993, 7, 4, 6, 0, -1, "(135,1993): 7, 4, 0", 1);// 200
			AddComplexComponent( (BaseAddon) this, 1993, 7, 5, 6, 0, -1, "(136,1993): 7, 5, 0", 1);// 201
			AddComplexComponent( (BaseAddon) this, 1993, 7, 6, 6, 0, -1, "(137,1993): 7, 6, 0", 1);// 202
			AddComplexComponent( (BaseAddon) this, 1993, 7, 7, 6, 0, -1, "(138,1993): 7, 7, 0", 1);// 203
			AddComplexComponent( (BaseAddon) this, 1993, 8, 3, 6, 0, -1, "(143,1993): 8, 3, 0", 1);// 204
			AddComplexComponent( (BaseAddon) this, 1993, 8, 4, 6, 0, -1, "(144,1993): 8, 4, 0", 1);// 205
			AddComplexComponent( (BaseAddon) this, 1993, 8, 5, 6, 0, -1, "(145,1993): 8, 5, 0", 1);// 206
			AddComplexComponent( (BaseAddon) this, 1993, 8, 6, 6, 0, -1, "(146,1993): 8, 6, 0", 1);// 207
			AddComplexComponent( (BaseAddon) this, 1993, 8, 7, 6, 0, -1, "(147,1993): 8, 7, 0", 1);// 208
			AddComplexComponent( (BaseAddon) this, 3519, 7, 5, 7, 0, -1, "(185,3519): 7, 5, 1", 1);// 209
			AddComplexComponent( (BaseAddon) this, 3530, 5, 6, 6, 0, -1, "(186,3530): 5, 6, 0", 1);// 210
			AddComplexComponent( (BaseAddon) this, 1993, 4, 8, 6, 0, -1, "(202,1993): 4, 8, 0", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1993, 5, 8, 6, 0, -1, "(203,1993): 5, 8, 0", 1);// 212
			AddComplexComponent( (BaseAddon) this, 1993, 6, 8, 6, 0, -1, "(204,1993): 6, 8, 0", 1);// 213
			AddComplexComponent( (BaseAddon) this, 1993, 7, 8, 6, 0, -1, "(205,1993): 7, 8, 0", 1);// 214
			AddComplexComponent( (BaseAddon) this, 1993, 8, 8, 6, 0, -1, "(206,1993): 8, 8, 0", 1);// 215
			AddComplexComponent( (BaseAddon) this, 2919, 6, 8, 6, 0, -1, "(208,2919): 6, 8, 0", 1);// 216
			AddComplexComponent( (BaseAddon) this, 2918, 5, 8, 6, 0, -1, "(209,2918): 5, 8, 0", 1);// 217
			AddComplexComponent( (BaseAddon) this, 2917, 7, 8, 6, 0, -1, "(210,2917): 7, 8, 0", 1);// 218
			AddComplexComponent( (BaseAddon) this, 933, 8, 8, 6, 0, -1, "(213,933): 8, 8, 0", 1);// 219
			AddComplexComponent( (BaseAddon) this, 933, 4, 8, 6, 0, -1, "(214,933): 4, 8, 0", 1);// 220

		}

		public BoatslipNSAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class BoatslipNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BoatslipNSAddon();
			}
		}

		[Constructable]
		public BoatslipNSAddonDeed()
		{
			Name = "BoatslipNS";
		}

		public BoatslipNSAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}