
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
	public class VampDungunGallowsAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4928, -4, -3, 0}, {4909, 0, -5, 0}, {4898, 2, -2, 0}// 2	3	4	
			, {4896, 2, -4, 0}, {4923, 1, -5, 0}, {12936, 2, -3, 0}// 10	14	26	
			, {4928, -4, -5, 0}, {11106, 0, -2, 0}, {4904, -4, -2, 0}// 30	32	33	
			, {12934, 2, -5, 0}, {4928, -4, -4, 0}, {12934, -4, -6, 0}// 36	43	52	
			, {4909, 1, -5, 0}, {12936, 2, 1, 0}, {4933, -4, 5, 0}// 53	55	57	
			, {4928, -4, -1, 0}, {11106, 1, 2, 0}, {413, 1, 2, 23}// 62	68	70	
			, {4904, -4, 2, 0}, {4896, 2, 3, 0}, {4928, -4, 0, 0}// 76	77	80	
			, {413, 2, 1, 33}, {441, -1, -1, 7}, {4931, -4, 1, 0}// 88	89	92	
			, {4931, -4, 4, 0}, {441, -1, 1, 7}, {4933, 0, 5, 0}// 93	95	96	
			, {414, 3, 3, 34}, {4928, -4, 3, 0}, {4933, 1, 5, 0}// 97	101	106	
			, {4897, 2, 4, 0}, {12936, 2, -1, 0}, {414, 5, 3, 55}// 112	125	129	
			, {4933, -3, 5, 0}, {4896, 2, 5, 0}, {4894, 2, 0, 0}// 134	137	138	
			, {4928, -4, 5, 0}, {12936, 2, 2, 0}// 140	142	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new VampDungunGallowsAddonDeed();
			}
		}

		[ Constructable ]
		public VampDungunGallowsAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4850, -1, -2, 0, 0, 0, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4850, 1, -2, 0, 0, 0, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4850, -3, -2, 0, 0, 0, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4850, -3, -5, 0, 0, 0, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 4850, -2, -3, 0, 0, 0, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2022, -3, -2, 7, 2273, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1291, 0, -2, 7, 2101, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4850, 1, -3, 0, 0, 0, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4850, 1, -4, 0, 0, 0, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1291, 0, -5, 7, 2101, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4850, 0, -4, 0, 0, 0, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2018, 0, -4, 8, 2273, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4850, 1, -5, 0, 0, 0, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4850, -2, -5, 0, 0, 0, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 4850, -3, -3, 0, 0, 0, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 4850, -1, -4, 0, 0, 0, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4850, -1, -5, 0, 0, 0, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 4850, -2, -4, 0, 0, 0, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 4850, -1, -3, 0, 0, 0, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 4850, -3, -4, 0, 0, 0, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1291, -1, -5, 7, 2101, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2022, -3, -3, 8, 2273, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1291, -2, -4, 7, 2101, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1291, -2, -3, 7, 2101, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1847, 0, -6, 0, 2224, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1847, -1, -6, 0, 2224, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1291, -1, -2, 7, 2101, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2018, -3, -4, 7, 2273, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1291, -2, -2, 7, 2101, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2022, 0, -3, 7, 2273, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2020, 0, -2, 7, 2273, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1056, -2, -5, 8, 2205, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1291, -1, -3, 7, 2101, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 4850, 0, -3, 0, 0, 0, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1291, 0, -3, 7, 2101, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 4850, -2, -2, 0, 0, 0, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1291, -1, -4, 7, 2101, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1291, -2, -5, 7, 2101, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1291, 0, -4, 7, 2101, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1847, -2, -6, 0, 2224, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1056, -2, -3, 7, 2204, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 1291, 0, 4, 7, 2101, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 4850, 1, 0, 0, 0, 0, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1291, -2, 3, 7, 2101, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1055, -2, 0, 7, 2302, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 4850, 1, 1, 0, 0, 0, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1823, -2, 6, 2, 2224, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1291, -1, 0, 7, 2101, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 4850, 1, -1, 0, 0, 0, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 4850, 1, 3, 0, 0, 0, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 4850, 1, 4, 0, 0, 0, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2022, -3, 3, 7, 2273, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 4850, -1, 5, 0, 0, 0, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 4850, 0, -1, 0, 0, 0, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 4850, 0, 0, 0, 0, 0, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 6660, 3, 3, 28, 1153, -1, "SirAJ", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1291, -1, 3, 7, 2101, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 4850, 0, 3, 0, 0, 0, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 1291, -2, 4, 7, 2101, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 2022, 0, 4, 7, 2273, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 4850, -3, 3, 0, 0, 0, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 4850, -2, -1, 0, 0, 0, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 4850, -2, 5, 0, 0, 0, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1291, -2, 1, 7, 2101, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 4850, -2, 1, 0, 0, 0, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 2022, -3, 1, 6, 2273, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 2017, -2, 4, 8, 2273, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1291, 0, 2, 7, 2101, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1291, 0, 5, 7, 2101, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 2022, -3, 0, 6, 2273, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 6659, 1, 0, 11, 1153, -1, "Bayouboy", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1823, 0, 6, 2, 2224, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1056, -2, 5, 7, 2205, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 4850, -3, 1, 0, 0, 0, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 4850, -3, 2, 0, 0, 0, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 4850, -3, 5, 0, 0, 0, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1291, -1, 4, 7, 2101, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1055, -2, -1, 7, 2302, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1291, -2, -1, 7, 2101, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1056, -2, 3, 7, 2204, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1291, -2, 0, 7, 2101, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 4850, -1, 1, 0, 0, 0, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 4850, -1, 0, 0, 0, 0, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 4850, 0, 1, 0, 0, 0, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 4850, -1, -1, 0, 0, 0, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 4850, -1, 2, 0, 0, 0, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 4850, -1, 4, 0, 0, 0, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 4850, -1, 3, 0, 0, 0, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 4850, -2, 0, 0, 0, 0, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1291, -1, 2, 7, 2101, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 4850, -3, -1, 0, 0, 0, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 4850, -2, 2, 0, 0, 0, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 4850, -2, 3, 0, 0, 0, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 4850, -2, 4, 0, 0, 0, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1291, 0, 3, 7, 2101, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 2022, -3, -1, 6, 2273, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1291, -1, 5, 7, 2101, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1291, -1, 1, 7, 2101, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 4850, -3, 4, 0, 0, 0, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 2021, 1, 3, 8, 2273, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1291, -2, 2, 7, 2101, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1291, -2, 5, 7, 2101, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 2020, 0, 5, 7, 2273, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 2022, -3, 2, 7, 2273, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1823, -1, 6, 2, 2224, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 4850, -3, 0, 0, 0, 0, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 2019, -2, 5, 8, 2273, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 4850, 0, 4, 0, 0, 0, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1291, -1, -1, 7, 2101, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 4850, 0, 2, 0, 0, 0, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 1055, -2, 1, 7, 2302, -1, "", 1);// 149

		}

		public VampDungunGallowsAddon( Serial serial ) : base( serial )
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

	public class VampDungunGallowsAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new VampDungunGallowsAddon();
			}
		}

		[Constructable]
		public VampDungunGallowsAddonDeed()
		{
			Name = "VampDungunGallows";
		}

		public VampDungunGallowsAddonDeed( Serial serial ) : base( serial )
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