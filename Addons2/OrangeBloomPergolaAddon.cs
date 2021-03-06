
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
	public class OrangeBloomPergolaAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10076, -6, -6, 0}, {10721, -5, -5, 20}, {10721, -5, -4, 20}// 1	2	3	
			, {10721, -5, -3, 20}, {10721, -5, -2, 20}, {10721, -5, -1, 20}// 4	5	6	
			, {10721, -5, 0, 20}, {10721, -5, 1, 20}, {10721, -4, -5, 20}// 7	8	9	
			, {10721, -4, -4, 20}, {10721, -4, -3, 20}, {10721, -4, -2, 20}// 10	11	12	
			, {10721, -4, -1, 20}, {10721, -4, 0, 20}, {10721, -4, 1, 20}// 13	14	15	
			, {10722, -5, -6, 20}, {10722, -4, -6, 20}, {10723, -6, -5, 20}// 16	17	18	
			, {10723, -6, -4, 20}, {10723, -6, -3, 20}, {10723, -6, -2, 20}// 19	20	21	
			, {10723, -6, -1, 20}, {10723, -6, 0, 20}, {10723, -6, 1, 20}// 22	23	24	
			, {10724, -6, -6, 20}, {3380, -4, -4, 21}, {10076, -6, 6, 0}// 25	26	30	
			, {10721, -5, 2, 20}, {10721, -5, 3, 20}, {10721, -5, 4, 20}// 31	32	33	
			, {10721, -5, 5, 20}, {10721, -5, 6, 20}, {10721, -4, 2, 20}// 34	35	36	
			, {10721, -4, 3, 20}, {10721, -4, 4, 20}, {10721, -4, 5, 20}// 37	38	39	
			, {10721, -4, 6, 20}, {10723, -6, 2, 20}, {10723, -6, 3, 20}// 40	41	42	
			, {10723, -6, 4, 20}, {10723, -6, 5, 20}, {10723, -6, 6, 20}// 43	44	45	
			, {10076, 6, -6, 0}, {10721, -3, -5, 20}, {10721, -3, -4, 20}// 49	50	51	
			, {10721, -3, -3, 20}, {10721, -3, -1, 20}, {10721, -3, 0, 20}// 52	53	54	
			, {10721, -3, 1, 20}, {10721, -2, -5, 20}, {10721, -2, -4, 20}// 55	56	57	
			, {10721, -2, -3, 20}, {10721, -2, -2, 20}, {10721, -2, -1, 20}// 58	59	60	
			, {10721, -2, 0, 20}, {10721, -2, 1, 20}, {10721, -1, -5, 20}// 61	62	63	
			, {10721, -1, -4, 20}, {10721, -1, -3, 20}, {10721, -1, -2, 20}// 64	65	66	
			, {10721, -1, -1, 20}, {10721, -1, 0, 20}, {10721, -1, 1, 20}// 67	68	69	
			, {10721, 0, -5, 20}, {10721, 0, -4, 20}, {10721, 0, -3, 20}// 70	71	72	
			, {10721, 0, -2, 20}, {10721, 0, -1, 20}, {10721, 0, 0, 20}// 73	74	75	
			, {10721, 0, 1, 20}, {10721, 1, -5, 20}, {10721, 1, -4, 20}// 76	77	78	
			, {10721, 1, -3, 20}, {10721, 1, -2, 20}, {10721, 1, -1, 20}// 79	80	81	
			, {10721, 1, 0, 20}, {10721, 1, 1, 20}, {10721, 2, -5, 20}// 82	83	84	
			, {10721, 2, -4, 20}, {10721, 2, -3, 20}, {10721, 2, -2, 20}// 85	86	87	
			, {10721, 2, -1, 20}, {10721, 2, 0, 20}, {10721, 2, 1, 20}// 88	89	90	
			, {10721, 3, -5, 20}, {10721, 3, -4, 20}, {10721, 3, -3, 20}// 91	92	93	
			, {10721, 3, -2, 20}, {10721, 3, -1, 20}, {10721, 3, 0, 20}// 94	95	96	
			, {10721, 3, 1, 20}, {10721, 4, -5, 20}, {10721, 4, -4, 20}// 97	98	99	
			, {10721, 4, -3, 20}, {10721, 4, -2, 20}, {10721, 4, -1, 20}// 100	101	102	
			, {10721, 4, 0, 20}, {10721, 4, 1, 20}, {10721, 5, -5, 20}// 103	104	105	
			, {10721, 5, -4, 20}, {10721, 5, -3, 20}, {10721, 5, -2, 20}// 106	107	108	
			, {10721, 5, -1, 20}, {10721, 5, 0, 20}, {10721, 5, 1, 20}// 109	110	111	
			, {10721, 6, -5, 20}, {10721, 6, -4, 20}, {10721, 6, -3, 20}// 112	113	114	
			, {10721, 6, -2, 20}, {10721, 6, -1, 20}, {10721, 6, 0, 20}// 115	116	117	
			, {10721, 6, 1, 20}, {10722, -3, -6, 20}, {10722, -2, -6, 20}// 118	119	120	
			, {10722, -1, -6, 20}, {10722, 0, -6, 20}, {10722, 1, -6, 20}// 121	122	123	
			, {10722, 2, -6, 20}, {10722, 3, -6, 20}, {10722, 4, -6, 20}// 124	125	126	
			, {10722, 5, -6, 20}, {10722, 6, -6, 20}, {3380, -1, -4, 21}// 127	128	129	
			, {3380, 3, -4, 21}, {3380, 6, -3, 21}, {3380, 4, -1, 21}// 130	131	132	
			, {3380, 1, -2, 21}, {10721, -3, -2, 20}, {3380, -3, -2, 21}// 133	134	135	
			, {3380, 2, 1, 21}, {3380, -1, 0, 21}, {10076, 6, 6, 0}// 136	137	158	
			, {10721, -3, 2, 20}, {10721, -3, 3, 20}, {10721, -3, 4, 20}// 159	160	161	
			, {10721, -3, 5, 20}, {10721, -3, 6, 20}, {10721, -2, 2, 20}// 162	163	164	
			, {10721, -2, 3, 20}, {10721, -2, 4, 20}, {10721, -2, 5, 20}// 165	166	167	
			, {10721, -2, 6, 20}, {10721, -1, 2, 20}, {10721, -1, 3, 20}// 168	169	170	
			, {10721, -1, 4, 20}, {10721, -1, 5, 20}, {10721, -1, 6, 20}// 171	172	173	
			, {10721, 0, 2, 20}, {10721, 0, 3, 20}, {10721, 0, 4, 20}// 174	175	176	
			, {10721, 0, 5, 20}, {10721, 0, 6, 20}, {10721, 1, 2, 20}// 177	178	179	
			, {10721, 1, 3, 20}, {10721, 1, 4, 20}, {10721, 1, 5, 20}// 180	181	182	
			, {10721, 1, 6, 20}, {10721, 2, 2, 20}, {10721, 2, 3, 20}// 183	184	185	
			, {10721, 2, 4, 20}, {10721, 2, 5, 20}, {10721, 2, 6, 20}// 186	187	188	
			, {10721, 3, 2, 20}, {10721, 3, 3, 20}, {10721, 3, 4, 20}// 189	190	191	
			, {10721, 3, 5, 20}, {10721, 3, 6, 20}, {10721, 4, 2, 20}// 192	193	194	
			, {10721, 4, 3, 20}, {10721, 4, 4, 20}, {10721, 4, 5, 20}// 195	196	197	
			, {10721, 4, 6, 20}, {10721, 5, 2, 20}, {10721, 5, 3, 20}// 198	199	200	
			, {10721, 5, 4, 20}, {10721, 5, 5, 20}, {10721, 5, 6, 20}// 201	202	203	
			, {10721, 6, 2, 20}, {10721, 6, 3, 20}, {10721, 6, 4, 20}// 204	205	206	
			, {10721, 6, 5, 20}, {10721, 6, 6, 20}, {3380, 0, 3, 21}// 207	208	209	
			, {3380, -2, 5, 21}, {3380, -3, 2, 21}, {3380, 6, 2, 21}// 210	211	212	
			, {3380, 4, 4, 22}, {7949, 2, 5, 23}, {7950, 3, 5, 23}// 213	214	215	
			, {7950, 6, 6, 23}, {7949, 6, 5, 23}, {7949, 5, 6, 23}// 216	217	218	
			, {7949, 2, 6, 25}// 219	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OrangeBloomPergolaAddonDeed();
			}
		}

		[ Constructable ]
		public OrangeBloomPergolaAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3214, -4, -2, 23, 2692, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 3214, -4, 0, 26, 2779, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 3214, -5, -5, 21, 2660, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 3214, -4, 5, 21, 2692, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 3214, -4, 2, 26, 2660, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 3214, -4, 4, 21, 2672, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 3214, 5, 0, 21, 2672, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 3214, 5, -4, 21, 2779, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 3214, 4, -3, 21, 2660, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 3214, 3, -2, 21, 2672, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 3214, 2, -1, 21, 2692, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 3214, 1, 0, 21, 2779, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 3214, 0, 1, 21, 2672, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 3214, 4, 0, 40, 2655, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 3214, 6, 0, 21, 2692, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 3214, 6, -1, 21, 2779, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 3214, -3, 1, 26, 2672, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 3214, -2, 0, 26, 2655, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 3214, -1, -1, 26, 2660, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 3214, 0, -2, 26, 2672, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 3214, 1, -3, 26, 2692, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 3214, 2, -4, 26, 2660, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 3214, -3, -3, 23, 2672, -1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 3214, -2, -4, 23, 2655, -1, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 3214, 1, -4, 26, 2672, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 3214, 4, 1, 26, 2660, -1, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 3214, 4, 4, 22, 2672, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 3214, 0, 3, 21, 2672, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 3214, 1, 4, 21, 2672, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 3214, 3, 2, 21, 2779, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 3214, 3, 4, 26, 2692, -1, "", 1);// 224
			AddComplexComponent( (BaseAddon) this, 3214, 1, 6, 26, 2655, -1, "", 1);// 225
			AddComplexComponent( (BaseAddon) this, 3214, 5, 2, 26, 2655, -1, "", 1);// 226
			AddComplexComponent( (BaseAddon) this, 3214, 5, 6, 26, 2655, -1, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 3214, 6, 5, 26, 2779, -1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 3214, -1, 2, 21, 2660, -1, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 3214, -2, 3, 21, 2672, -1, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 3214, -3, 4, 21, 2655, -1, "", 1);// 231
			AddComplexComponent( (BaseAddon) this, 3214, 0, 6, 26, 2672, -1, "", 1);// 232
			AddComplexComponent( (BaseAddon) this, 3214, 2, 3, 26, 2672, -1, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 3214, 6, 4, 26, 2692, -1, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 3214, 4, 7, 31, 2660, -1, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 3214, 0, 5, 26, 2779, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 3214, -1, 6, 26, 2660, -1, "", 1);// 237

		}

		public OrangeBloomPergolaAddon( Serial serial ) : base( serial )
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

	public class OrangeBloomPergolaAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OrangeBloomPergolaAddon();
			}
		}

		[Constructable]
		public OrangeBloomPergolaAddonDeed()
		{
			Name = "OrangeBloomPergola";
		}

		public OrangeBloomPergolaAddonDeed( Serial serial ) : base( serial )
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