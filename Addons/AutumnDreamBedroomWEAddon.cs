
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
	public class AutumnDreamBedroomWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2918, 2, 2, 0}, {2917, 3, 2, 0}// 154	166	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AutumnDreamBedroomWEAddonDeed();
			}
		}

		[ Constructable ]
		public AutumnDreamBedroomWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2802, -5, -1, 0, 2960, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2803, -3, -4, 0, 2960, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2802, -5, 1, 0, 2960, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2797, -3, 0, 0, 2960, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2797, -2, -2, 0, 2960, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2802, -5, -2, 0, 2960, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 5992, -2, 0, 3, 2827, -1, "(26,5992): 1, 0, 2", 1);// 7
			AddComplexComponent( (BaseAddon) this, 5992, -3, 0, 3, 2827, -1, "(23,5992): 0, 0, 2", 1);// 8
			AddComplexComponent( (BaseAddon) this, 5992, -2, -1, 3, 2827, -1, "(25,5992): 1, -1, 2", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2800, -5, 4, 0, 2960, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 10395, -4, -2, 0, 2960, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2797, -4, -2, 0, 2960, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5992, -3, -1, 3, 2827, -1, "(22,5992): 0, -1, 2", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2797, -2, -1, 0, 2960, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5992, -3, -1, 5, 2827, -1, "(40,5992): 0, -1, 4", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2805, -4, 4, 0, 2960, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2797, -3, 3, 0, 2960, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 5992, -3, 1, 5, 2827, -1, "(42,5992): 0, 1, 4", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2803, -4, -4, 0, 2960, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 10395, -4, 1, 0, 2960, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2797, -4, 3, 0, 2960, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2797, -3, -3, 0, 2960, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2802, -5, 2, 0, 2960, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 5992, -3, 0, 1, 2827, -1, "(5,5992): 0, 0, 0", 1);// 24
			AddComplexComponent( (BaseAddon) this, 10398, -5, 0, 0, 2960, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 3530, -3, 0, 7, 2827, -1, "(56,3530): 0, 0, 6", 1);// 26
			AddComplexComponent( (BaseAddon) this, 10398, -5, -2, 0, 2960, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 10398, -5, -1, 0, 2960, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 10398, -5, 2, 0, 2960, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 5690, -4, 0, 7, 2660, -1, "(63,5690): -1, 0, 6", 1);// 30
			AddComplexComponent( (BaseAddon) this, 10398, -5, 1, 0, 2960, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2799, -5, -4, 0, 2960, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2797, -2, 3, 0, 2960, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2797, -4, -3, 0, 2960, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2797, -4, 1, 0, 2960, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2797, -1, -2, 0, 2960, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 5992, -2, -1, 2, 2827, -1, "(16,5992): 1, -1, 1", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2797, -3, -2, 0, 2960, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 5992, -2, 0, 5, 2827, -1, "(44,5992): 1, 0, 4", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2797, -4, 0, 0, 2960, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 5992, -3, -1, 1, 2827, -1, "(4,5992): 0, -1, 0", 1);// 41
			AddComplexComponent( (BaseAddon) this, 5992, -3, 1, 6, 2827, -1, "(51,5992): 0, 1, 5", 1);// 42
			AddComplexComponent( (BaseAddon) this, 5992, -2, 1, 4, 2827, -1, "(36,5992): 1, 1, 3", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2797, -2, 1, 0, 2960, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2805, -1, 4, 0, 2960, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 5992, -4, 1, 1, 2827, -1, "(3,5992): -1, 1, 0", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2805, -2, 4, 0, 2960, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2805, -3, 4, 0, 2960, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 9234, -3, -2, 0, 2726, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 5992, -2, 1, 3, 2827, -1, "(27,5992): 1, 1, 2", 1);// 50
			AddComplexComponent( (BaseAddon) this, 5992, -4, 1, 4, 2827, -1, "(30,5992): -1, 1, 3", 1);// 51
			AddComplexComponent( (BaseAddon) this, 5992, -4, 1, 5, 2827, -1, "(39,5992): -1, 1, 4", 1);// 52
			AddComplexComponent( (BaseAddon) this, 2803, -2, -4, 0, 2960, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 5992, -4, 0, 1, 2827, -1, "(2,5992): -1, 0, 0", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2797, -1, 2, 0, 2960, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 10398, -4, 2, 0, 2960, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2797, -1, -1, 0, 2960, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 2797, -4, -1, 0, 2960, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 9234, -3, 2, 0, 2726, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 2797, -1, 3, 0, 2960, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2797, -2, -3, 0, 2960, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 2797, -3, -1, 0, 2960, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 2797, -2, 2, 0, 2960, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 10381, -5, -3, 0, 2960, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 5992, -2, 1, 5, 2827, -1, "(45,5992): 1, 1, 4", 1);// 65
			AddComplexComponent( (BaseAddon) this, 2802, -5, 3, 0, 2960, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 5992, -2, -1, 4, 2827, -1, "(34,5992): 1, -1, 3", 1);// 67
			AddComplexComponent( (BaseAddon) this, 10395, -4, -3, 0, 2960, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 2797, -4, 2, 0, 2960, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 5992, -4, 0, 5, 2827, -1, "(38,5992): -1, 0, 4", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2797, -1, -3, 0, 2960, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 10398, -4, -2, 0, 2960, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 5992, -4, 1, 3, 2827, -1, "(21,5992): -1, 1, 2", 1);// 73
			AddComplexComponent( (BaseAddon) this, 5992, -4, 0, 4, 2827, -1, "(29,5992): -1, 0, 3", 1);// 74
			AddComplexComponent( (BaseAddon) this, 5992, -3, 1, 3, 2827, -1, "(24,5992): 0, 1, 2", 1);// 75
			AddComplexComponent( (BaseAddon) this, 2797, -3, 1, 0, 2960, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 5992, -2, -1, 1, 2827, -1, "(7,5992): 1, -1, 0", 1);// 77
			AddComplexComponent( (BaseAddon) this, 5992, -3, -1, 4, 2827, -1, "(31,5992): 0, -1, 3", 1);// 78
			AddComplexComponent( (BaseAddon) this, 5992, -4, -1, 1, 2827, -1, "(1,5992): -1, -1, 0", 1);// 79
			AddComplexComponent( (BaseAddon) this, 5992, -3, 1, 2, 2827, -1, "(15,5992): 0, 1, 1", 1);// 80
			AddComplexComponent( (BaseAddon) this, 5992, -4, -1, 6, 2827, -1, "(46,5992): -1, -1, 5", 1);// 81
			AddComplexComponent( (BaseAddon) this, 10392, -4, 2, 0, 2960, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 2803, -1, -4, 0, 2960, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 2802, -5, -3, 0, 2960, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 5992, -4, 0, 3, 2827, -1, "(20,5992): -1, 0, 2", 1);// 85
			AddComplexComponent( (BaseAddon) this, 5992, -4, 0, 6, 2827, -1, "(47,5992): -1, 0, 5", 1);// 86
			AddComplexComponent( (BaseAddon) this, 5992, -4, 1, 6, 2827, -1, "(48,5992): -1, 1, 5", 1);// 87
			AddComplexComponent( (BaseAddon) this, 5992, -3, -1, 6, 2827, -1, "(49,5992): 0, -1, 5", 1);// 88
			AddComplexComponent( (BaseAddon) this, 10328, -1, 0, 0, 2827, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 10328, -1, -1, 0, 2827, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 10328, -1, 1, 0, 2827, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 5992, -4, -1, 2, 2827, -1, "(10,5992): -1, -1, 1", 1);// 92
			AddComplexComponent( (BaseAddon) this, 5992, -4, 0, 2, 2827, -1, "(11,5992): -1, 0, 1", 1);// 93
			AddComplexComponent( (BaseAddon) this, 5992, -2, 0, 2, 2827, -1, "(17,5992): 1, 0, 1", 1);// 94
			AddComplexComponent( (BaseAddon) this, 5992, -3, -1, 2, 2827, -1, "(13,5992): 0, -1, 1", 1);// 95
			AddComplexComponent( (BaseAddon) this, 5992, -2, 1, 2, 2827, -1, "(18,5992): 1, 1, 1", 1);// 96
			AddComplexComponent( (BaseAddon) this, 5992, -2, -1, 5, 2827, -1, "(43,5992): 1, -1, 4", 1);// 97
			AddComplexComponent( (BaseAddon) this, 5992, -3, 1, 4, 2827, -1, "(33,5992): 0, 1, 3", 1);// 98
			AddComplexComponent( (BaseAddon) this, 2802, -5, 0, 0, 2960, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 5028, -4, 1, 7, 2655, -1, "(61,5028): -1, 1, 6", 1);// 100
			AddComplexComponent( (BaseAddon) this, 3530, -2, 0, 7, 2827, -1, "(59,3530): 1, 0, 6", 1);// 101
			AddComplexComponent( (BaseAddon) this, 5028, -4, -1, 7, 2659, -1, "(62,5028): -1, -1, 6", 1);// 102
			AddComplexComponent( (BaseAddon) this, 5992, -3, 0, 6, 2827, -1, "(50,5992): 0, 0, 5", 1);// 103
			AddComplexComponent( (BaseAddon) this, 5992, -4, -1, 3, 2827, -1, "(19,5992): -1, -1, 2", 1);// 104
			AddComplexComponent( (BaseAddon) this, 5992, -3, 0, 4, 2827, -1, "(32,5992): 0, 0, 3", 1);// 105
			AddComplexComponent( (BaseAddon) this, 2797, -2, 0, 0, 2960, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 2797, -1, 1, 0, 2960, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 5992, -2, 0, 4, 2827, -1, "(35,5992): 1, 0, 3", 1);// 108
			AddComplexComponent( (BaseAddon) this, 5992, -3, 0, 5, 2827, -1, "(41,5992): 0, 0, 4", 1);// 109
			AddComplexComponent( (BaseAddon) this, 5992, -3, 0, 2, 2827, -1, "(14,5992): 0, 0, 1", 1);// 110
			AddComplexComponent( (BaseAddon) this, 5992, -4, 1, 2, 2827, -1, "(12,5992): -1, 1, 1", 1);// 111
			AddComplexComponent( (BaseAddon) this, 5992, -4, -1, 4, 2827, -1, "(28,5992): -1, -1, 3", 1);// 112
			AddComplexComponent( (BaseAddon) this, 3530, -3, -1, 7, 2827, -1, "(55,3530): 0, -1, 6", 1);// 113
			AddComplexComponent( (BaseAddon) this, 3530, -3, 1, 7, 2827, -1, "(57,3530): 0, 1, 6", 1);// 114
			AddComplexComponent( (BaseAddon) this, 3530, -2, -1, 7, 2827, -1, "(58,3530): 1, -1, 6", 1);// 115
			AddComplexComponent( (BaseAddon) this, 5992, -2, 0, 6, 2827, -1, "(53,5992): 1, 0, 5", 1);// 116
			AddComplexComponent( (BaseAddon) this, 5992, -2, -1, 6, 2827, -1, "(52,5992): 1, -1, 5", 1);// 117
			AddComplexComponent( (BaseAddon) this, 5992, -3, 1, 1, 2827, -1, "(6,5992): 0, 1, 0", 1);// 118
			AddComplexComponent( (BaseAddon) this, 5992, -2, 0, 1, 2827, -1, "(8,5992): 1, 0, 0", 1);// 119
			AddComplexComponent( (BaseAddon) this, 2797, -1, 0, 0, 2960, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 5992, -2, 1, 6, 2827, -1, "(54,5992): 1, 1, 5", 1);// 121
			AddComplexComponent( (BaseAddon) this, 5992, -2, 1, 1, 2827, -1, "(9,5992): 1, 1, 0", 1);// 122
			AddComplexComponent( (BaseAddon) this, 5992, -4, -1, 5, 2827, -1, "(37,5992): -1, -1, 4", 1);// 123
			AddComplexComponent( (BaseAddon) this, 3530, -2, 1, 7, 2827, -1, "(60,3530): 1, 1, 6", 1);// 124
			AddComplexComponent( (BaseAddon) this, 2797, -3, 2, 0, 2960, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 2803, 1, -4, 0, 2960, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 2797, 3, 0, 0, 2960, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 2805, 3, 4, 0, 2960, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 5029, 3, 2, 3, 2827, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 2805, 2, 4, 0, 2960, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 2803, 4, -4, 0, 2960, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1981, 1, -3, 13, 1, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 2797, 3, 2, 0, 2960, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 5015, 4, 2, 5, 2827, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 2797, 4, -3, 0, 2960, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 2803, 3, -4, 0, 2960, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 2797, 4, 0, 0, 2960, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1981, 2, -3, 0, 1, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 2952, 1, 1, 0, 2827, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 2797, 1, -1, 0, 2960, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 2798, 5, 4, 0, 2960, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 2797, 3, -2, 0, 2960, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 2804, 5, -3, 0, 2960, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 2805, 4, 4, 0, 2960, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 2805, 1, 4, 0, 2960, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 2797, 2, -3, 0, 2960, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 2797, 3, -3, 0, 2960, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 2797, 1, -3, 0, 2960, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 2797, 2, 1, 0, 2960, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 2797, 0, -3, 0, 2960, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 2804, 5, -1, 0, 2960, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 2797, 4, -2, 0, 2960, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 2797, 2, 2, 0, 2960, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 1801, 4, 3, 0, 2827, -1, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 1801, 1, 3, 0, 2827, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 2804, 5, 1, 0, 2960, -1, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 2804, 5, -2, 0, 2960, -1, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 5015, 1, 2, 5, 2827, -1, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 2804, 5, 2, 0, 2960, -1, "", 1);// 160
			AddComplexComponent( (BaseAddon) this, 2797, 3, -1, 0, 2960, -1, "", 1);// 161
			AddComplexComponent( (BaseAddon) this, 2797, 2, 3, 0, 2960, -1, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 2512, 1, -2, 12, 2999, -1, "Volume", 1);// 163
			AddComplexComponent( (BaseAddon) this, 1801, 3, 3, 0, 2827, -1, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 2804, 5, 0, 0, 2960, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 2797, 4, 1, 0, 2960, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 2797, 3, 3, 0, 2960, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 2797, 0, 3, 0, 2960, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 1981, 4, -3, 13, 1, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 5015, 4, 3, 5, 2827, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1981, 3, -3, 13, 1, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 2797, 1, 1, 0, 2960, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 1981, 3, -3, 0, 1, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 7154, 4, 1, 6, 2763, -1, "Remote", 1);// 175
			AddComplexComponent( (BaseAddon) this, 1848, 1, -3, 0, 1, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 2804, 5, 3, 0, 2960, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 1801, 4, 2, 0, 2827, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 1981, 2, -3, 13, 1, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 2797, 1, 3, 0, 2960, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 2801, 5, -4, 0, 2960, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 2797, 4, -1, 0, 2960, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 2797, 0, 1, 0, 2960, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 2803, 2, -4, 0, 2960, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 1985, 0, -3, 13, 1, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 2797, 1, 2, 0, 2960, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 2797, 0, 2, 0, 2960, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 2797, 4, 3, 0, 2960, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 1848, 4, -3, 0, 1, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 2797, 2, -2, 0, 2960, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 1986, 5, -3, 0, 1, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 1848, 4, -3, 10, 1, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 2803, 0, -4, 0, 2960, -1, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 2797, 2, 0, 0, 2960, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 2797, 4, 2, 0, 2960, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 1801, 2, 3, 0, 2827, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 2797, 2, -1, 0, 2960, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 2805, 0, 4, 0, 2960, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 2797, 0, 0, 0, 2960, -1, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 2797, 0, -2, 0, 2960, -1, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 2797, 3, 1, 0, 2960, -1, "", 1);// 201
			AddComplexComponent( (BaseAddon) this, 5015, 2, 3, 5, 2827, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 7889, 2, -3, 15, 2963, 1, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 7889, 1, -3, 15, 2963, 1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 1848, 4, -3, 5, 1, -1, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 1986, 5, -3, 6, 1, -1, "", 1);// 206
			AddComplexComponent( (BaseAddon) this, 1848, 1, -3, 5, 1, -1, "", 1);// 207
			AddComplexComponent( (BaseAddon) this, 1985, 0, -3, 7, 1, -1, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 2952, 4, 1, 0, 2827, -1, "", 1);// 209
			AddComplexComponent( (BaseAddon) this, 9039, 3, -2, 0, 0, -1, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 1986, 5, -3, 13, 1, -1, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1985, 0, -3, 0, 1, -1, "", 1);// 212
			AddComplexComponent( (BaseAddon) this, 5015, 1, 3, 5, 2827, -1, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 5015, 3, 3, 5, 2827, -1, "", 1);// 214
			AddComplexComponent( (BaseAddon) this, 7714, 3, -3, 15, 2827, -1, "DVD Player", 1);// 215
			AddComplexComponent( (BaseAddon) this, 2512, 1, -2, 6, 2999, -1, "On/Off", 1);// 216
			AddComplexComponent( (BaseAddon) this, 1848, 1, -3, 10, 1, -1, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 2797, 1, 0, 0, 2960, -1, "", 1);// 218
			AddComplexComponent( (BaseAddon) this, 2797, 0, -1, 0, 2960, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 1801, 1, 2, 0, 2827, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 5029, 2, 2, 3, 2827, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 2512, 1, -2, 9, 2999, -1, "Channel", 1);// 222
			AddComplexComponent( (BaseAddon) this, 2797, 1, -2, 0, 2960, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 2453, 1, 1, 6, 0, -1, "Hot Chocolate", 1);// 224

		}

		public AutumnDreamBedroomWEAddon( Serial serial ) : base( serial )
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

	public class AutumnDreamBedroomWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AutumnDreamBedroomWEAddon();
			}
		}

		[Constructable]
		public AutumnDreamBedroomWEAddonDeed()
		{
			Name = "AutumnDreamBedroomWE";
		}

		public AutumnDreamBedroomWEAddonDeed( Serial serial ) : base( serial )
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