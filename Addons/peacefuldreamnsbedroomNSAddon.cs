
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
	public class peacefuldreamnsbedroomNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4554, -3, 3, 2}// 41	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new peacefuldreamnsbedroomNSAddonDeed();
			}
		}

		[ Constructable ]
		public peacefuldreamnsbedroomNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 10070, -2, -2, 2, 2540, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 10072, -1, -3, 2, 2540, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2795, -2, -2, 2, 2736, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2791, -3, -1, 2, 2736, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2792, -1, -3, 2, 2736, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 10332, -2, -1, 2, 1192, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 10070, -3, -2, 2, 2540, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 10072, -2, -3, 2, 2540, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2791, -3, -2, 2, 2736, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2788, -3, -3, 2, 2736, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2792, -2, -3, 2, 2736, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 6, 2816, -1, "", 22);// 12
			AddComplexComponent( (BaseAddon) this, 5029, -1, -1, 8, 2816, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2795, -2, -1, 2, 2736, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2795, -1, -2, 2, 2736, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2795, -1, -1, 2, 2736, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10072, -2, -2, 2, 2540, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4632, -1, -1, 3, 2816, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 2, 2816, -1, "", 2);// 19
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 7, 2816, -1, "", 2);// 20
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 3, 2816, -1, "", 2);// 21
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 4, 2816, -1, "", 2);// 22
			AddComplexComponent( (BaseAddon) this, 2791, -3, 3, 2, 2736, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 7, 2816, -1, "", 2);// 24
			AddComplexComponent( (BaseAddon) this, 3530, -1, 0, 8, 2816, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2795, -1, 3, 2, 2736, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2789, -3, 4, 2, 2736, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2794, -2, 4, 2, 2736, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2795, -1, 2, 2, 2736, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2795, -2, 1, 2, 2736, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2795, -1, 2, 2, 2736, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2795, -2, 0, 2, 2736, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2795, -2, 3, 2, 2736, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2791, -3, 2, 2, 2736, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2795, -2, 2, 2, 2736, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2795, -1, 1, 2, 2736, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2791, -3, 1, 2, 2736, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2794, -1, 4, 2, 2736, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2795, -1, 0, 2, 2736, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2791, -3, 0, 2, 2736, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 6, 2816, -1, "", 2);// 42
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 4, 2816, -1, "", 2);// 43
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 5, 2816, -1, "", 2);// 44
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 5, 2816, -1, "", 2);// 45
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 4, 2816, -1, "", 2);// 46
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 3, 2816, -1, "", 2);// 47
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 7, 2816, -1, "", 2);// 48
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 6, 2816, -1, "", 2);// 49
			AddComplexComponent( (BaseAddon) this, 3530, -1, 1, 8, 2816, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 3, 2816, -1, "", 2);// 51
			AddComplexComponent( (BaseAddon) this, 10072, 0, -3, 2, 2540, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 6, 2816, -1, "", 2);// 53
			AddComplexComponent( (BaseAddon) this, 2795, 1, -2, 2, 2736, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2792, 0, -3, 2, 2736, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 5029, 1, -1, 8, 2816, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2795, 2, -1, 2, 2288, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 2, 2816, -1, "", 2);// 58
			AddComplexComponent( (BaseAddon) this, 10332, 2, -1, 2, 1192, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 2793, 3, -2, 2, 2736, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2795, 0, -1, 2, 2736, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 3744, 0, -2, 2, 2816, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 10072, 2, -3, 2, 2540, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 4632, 0, -1, 3, 2816, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2793, 3, -1, 2, 2736, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 2795, 2, -2, 2, 2736, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 10079, 2, -2, 2, 2540, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2842, 2, -1, 10, 0, 2, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 2795, 1, -1, 2, 2736, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 2795, 2, -1, 2, 2736, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2792, 2, -3, 2, 2736, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2790, 3, -3, 2, 2736, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 10072, 1, -3, 2, 2540, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2795, 0, -2, 2, 2736, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 2792, 1, -3, 2, 2736, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 10079, 1, -2, 3, 2540, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 5690, 0, -1, 8, 2816, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 4632, 1, -1, 3, 2816, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 10072, 2, -2, 2, 2540, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 5, 2816, -1, "", 2);// 80
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 3, 2816, -1, "", 2);// 81
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 4, 2816, -1, "", 2);// 82
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 4, 2816, -1, "", 2);// 83
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 3, 2816, -1, "", 2);// 84
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 2, 2816, -1, "", 2);// 85
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 7, 2816, -1, "", 2);// 86
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 7, 2816, -1, "", 2);// 87
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 6, 2816, -1, "", 2);// 88
			AddComplexComponent( (BaseAddon) this, 2795, 2, 0, 2, 2288, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 2795, 1, 2, 2, 2736, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 3976, 0, 4, 0, 2530, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 2795, 2, 3, 2, 2736, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 2794, 1, 4, 2, 2736, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 2795, 2, 1, 2, 2736, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 2795, 1, 0, 2, 2736, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 2795, 0, 2, 2, 2736, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 10257, 0, 2, 2, 2540, -1, "Hope Chest", 1);// 97
			AddComplexComponent( (BaseAddon) this, 2793, 3, 2, 2, 2736, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 2794, 0, 4, 2, 2736, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 2795, 0, 0, 2, 2736, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 2794, 2, 4, 2, 2736, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 2795, 2, 0, 2, 2660, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 2793, 3, 1, 2, 2736, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 2793, 3, 3, 2, 2736, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 2795, 1, 1, 2, 2736, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 2787, 3, 4, 2, 2736, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 2795, 2, 0, 2, 2736, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 2795, 1, 3, 2, 2736, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 2795, 0, 1, 2, 2736, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 2793, 3, 0, 2, 2736, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 2795, 2, 2, 2, 2736, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 2795, 0, 3, 2, 2736, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 5990, 0, 0, 7, 2816, -1, "", 2);// 113
			AddComplexComponent( (BaseAddon) this, 5990, 1, 0, 7, 2816, -1, "", 2);// 114
			AddComplexComponent( (BaseAddon) this, 5990, 0, 0, 6, 2816, -1, "", 2);// 115
			AddComplexComponent( (BaseAddon) this, 5990, 1, 1, 3, 2816, -1, "", 2);// 116
			AddComplexComponent( (BaseAddon) this, 7857, 2, 3, 2, 2314, -1, "Rockers", 1);// 117
			AddComplexComponent( (BaseAddon) this, 8479, 2, 3, 4, 2314, -1, "Rocking Horse", 1);// 118
			AddComplexComponent( (BaseAddon) this, 5990, 1, 0, 6, 2816, -1, "", 2);// 119
			AddComplexComponent( (BaseAddon) this, 5990, 1, 0, 5, 2816, -1, "", 2);// 120
			AddComplexComponent( (BaseAddon) this, 5990, 0, 0, 5, 2816, -1, "", 2);// 121
			AddComplexComponent( (BaseAddon) this, 2668, 0, 2, 10, 2816, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 5990, 1, 0, 4, 2816, -1, "", 2);// 123
			AddComplexComponent( (BaseAddon) this, 5990, 0, 0, 4, 2816, -1, "", 2);// 124
			AddComplexComponent( (BaseAddon) this, 5990, 0, 0, 3, 2816, -1, "", 2);// 125
			AddComplexComponent( (BaseAddon) this, 5990, 1, 0, 3, 2816, -1, "", 2);// 126
			AddComplexComponent( (BaseAddon) this, 5990, 0, 1, 7, 2816, -1, "", 2);// 127
			AddComplexComponent( (BaseAddon) this, 5990, 1, 1, 7, 2816, -1, "", 2);// 128
			AddComplexComponent( (BaseAddon) this, 5990, 1, 1, 6, 2816, -1, "", 2);// 129
			AddComplexComponent( (BaseAddon) this, 5990, 0, 1, 3, 2816, -1, "", 2);// 130
			AddComplexComponent( (BaseAddon) this, 5990, 0, 1, 4, 2816, -1, "", 2);// 131
			AddComplexComponent( (BaseAddon) this, 3530, 1, 1, 8, 2816, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 5990, 0, 1, 5, 2816, -1, "", 2);// 133
			AddComplexComponent( (BaseAddon) this, 5990, 0, 1, 6, 2816, -1, "", 2);// 134
			AddComplexComponent( (BaseAddon) this, 3530, 0, 0, 8, 2816, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 5990, 1, 1, 4, 2816, -1, "", 2);// 136
			AddComplexComponent( (BaseAddon) this, 5990, 1, 1, 5, 2816, -1, "", 2);// 137
			AddComplexComponent( (BaseAddon) this, 3530, 1, 0, 8, 2816, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 3530, 0, 1, 8, 2816, -1, "", 1);// 139

		}

		public peacefuldreamnsbedroomNSAddon( Serial serial ) : base( serial )
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

	public class peacefuldreamnsbedroomNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new peacefuldreamnsbedroomNSAddon();
			}
		}

		[Constructable]
		public peacefuldreamnsbedroomNSAddonDeed()
		{
			Name = "peacefuldreamnsbedroomNS";
		}

		public peacefuldreamnsbedroomNSAddonDeed( Serial serial ) : base( serial )
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