
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
	public class GuysAsianBedroomWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7755, 1, 1, 0}, {10314, 3, 2, 0}, {7757, 2, 0, 0}// 2	3	20	
			, {7758, 3, 0, 0}, {7760, 2, -1, 0}, {7759, 3, -1, 0}// 53	58	60	
			, {7753, 3, 1, 0}, {7756, 1, 0, 0}, {2895, 2, -2, 0}// 62	63	96	
			, {7754, 2, 1, 0}, {7761, 1, -1, 0}, {2456, -2, 2, 7}// 100	101	117	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GuysAsianBedroomWEAddonDeed();
			}
		}

		[ Constructable ]
		public GuysAsianBedroomWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5990, -3, 0, 1, 2747, -1, "", 2);// 1
			AddComplexComponent( (BaseAddon) this, 2795, 3, -2, 0, 2751, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2795, 2, -1, 0, 2751, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 10079, -4, -1, 0, 2747, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 2, 2747, -1, "", 2);// 7
			AddComplexComponent( (BaseAddon) this, 2795, 0, 2, 0, 2751, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2794, 3, 3, 0, 2751, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2795, 1, 2, 0, 2751, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 2, 2747, -1, "", 2);// 11
			AddComplexComponent( (BaseAddon) this, 5990, -2, 1, 3, 1, -1, "", 2);// 12
			AddComplexComponent( (BaseAddon) this, 2792, 2, -3, 0, 2751, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2795, 0, -2, 0, 2751, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5990, -2, -1, 2, 2747, -1, "", 2);// 15
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 0, 2747, -1, "", 2);// 16
			AddComplexComponent( (BaseAddon) this, 10082, -3, 1, 0, 2747, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2794, -1, 3, 0, 2751, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 5990, -2, 0, 1, 2747, -1, "", 2);// 19
			AddComplexComponent( (BaseAddon) this, 2789, -3, 3, 0, 2751, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3530, -1, 1, 5, 2747, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2793, 4, 0, 0, 2751, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 3530, -2, 1, 5, 2747, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 5990, -2, -1, 2, 1, -1, "", 2);// 25
			AddComplexComponent( (BaseAddon) this, 3530, -2, 0, 4, 2747, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2795, -1, 0, 0, 2751, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2795, -2, 2, 0, 2751, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 5990, -2, 1, 3, 1, -1, "", 2);// 29
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 1, 2747, -1, "", 2);// 30
			AddComplexComponent( (BaseAddon) this, 2792, -1, -3, 0, 2751, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 5990, -3, 1, 3, 1, -1, "", 2);// 32
			AddComplexComponent( (BaseAddon) this, 2788, -3, -3, 0, 2751, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2792, 1, -3, 0, 2751, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2795, 0, 1, 0, 2751, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2792, -2, -3, 0, 2751, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 3, 1, -1, "", 2);// 37
			AddComplexComponent( (BaseAddon) this, 3530, -1, -1, 5, 2747, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2795, -2, 1, 0, 2751, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 3, 1, -1, "", 2);// 40
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 2, 2747, -1, "", 2);// 41
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 0, 2747, -1, "", 2);// 42
			AddComplexComponent( (BaseAddon) this, 2795, -2, -1, 0, 2751, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2795, 3, 2, 0, 2751, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2795, -1, 1, 0, 2751, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2795, 2, 0, 0, 2751, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2791, -3, -1, 0, 2751, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2795, 1, -1, 0, 2751, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 10079, -4, 0, 0, 2747, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2794, 0, 3, 0, 2751, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 2842, -2, -2, 7, 0, 10, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2795, 1, 1, 0, 2751, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 10069, -3, 2, 0, 2747, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 1, 2747, -1, "", 2);// 55
			AddComplexComponent( (BaseAddon) this, 5990, -3, 0, 4, 1, -1, "", 2);// 56
			AddComplexComponent( (BaseAddon) this, 5990, -3, -1, 3, 1, -1, "", 2);// 57
			AddComplexComponent( (BaseAddon) this, 8968, 3, -2, 0, 2751, -1, "Slippers", 1);// 59
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 3, 1, -1, "", 2);// 61
			AddComplexComponent( (BaseAddon) this, 2795, 2, 1, 0, 2751, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 3, 1, -1, "", 2);// 65
			AddComplexComponent( (BaseAddon) this, 5990, -3, 0, 0, 2747, -1, "", 2);// 66
			AddComplexComponent( (BaseAddon) this, 2795, 0, 0, 0, 2751, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 5990, -2, 1, 0, 2747, -1, "", 2);// 68
			AddComplexComponent( (BaseAddon) this, 10079, -4, -2, 0, 2747, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 10069, -3, -2, 0, 2747, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 5990, -2, 1, 1, 2747, -1, "", 2);// 71
			AddComplexComponent( (BaseAddon) this, 2792, 0, -3, 0, 2751, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 2795, -2, -2, 0, 2751, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 5028, -3, -1, 4, 2747, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 10328, -2, -2, 0, 2747, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 5990, -2, -1, 3, 1, -1, "", 2);// 76
			AddComplexComponent( (BaseAddon) this, 5990, -3, 0, 2, 1, -1, "", 2);// 77
			AddComplexComponent( (BaseAddon) this, 2791, -3, 2, 0, 2751, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 2795, -1, 2, 0, 2751, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 5990, -2, 0, 0, 2747, -1, "", 2);// 80
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 2, 2747, -1, "", 2);// 81
			AddComplexComponent( (BaseAddon) this, 2795, 3, -1, 0, 2751, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 2795, 0, -1, 0, 2751, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 2787, 4, 3, 0, 2751, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 2795, -2, 0, 0, 2751, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 5990, -3, 1, 4, 1, -1, "", 2);// 86
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 2, 2747, -1, "", 2);// 87
			AddComplexComponent( (BaseAddon) this, 2795, 3, 0, 0, 2751, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 0, 2747, -1, "", 2);// 89
			AddComplexComponent( (BaseAddon) this, 5990, -3, -1, 1, 2747, -1, "", 2);// 90
			AddComplexComponent( (BaseAddon) this, 2793, 4, -2, 0, 2751, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 4633, -3, 0, 0, 2747, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 2794, 1, 3, 0, 2751, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 2795, 3, 1, 0, 2751, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 2794, 2, 3, 0, 2751, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 2795, 2, 2, 0, 2751, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 2793, 4, 2, 0, 2751, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 10328, -2, 2, 0, 2747, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 5990, -3, 1, 0, 2747, -1, "", 2);// 102
			AddComplexComponent( (BaseAddon) this, 5990, -3, -1, 2, 1, -1, "", 2);// 103
			AddComplexComponent( (BaseAddon) this, 10076, -4, -3, 0, 2747, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 2794, -2, 3, 0, 2751, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 5990, -2, -1, 1, 2747, -1, "", 2);// 106
			AddComplexComponent( (BaseAddon) this, 2792, 3, -3, 0, 2751, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 2791, -3, 0, 0, 2751, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 5028, -3, 1, 5, 2747, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 3, 1, -1, "", 2);// 110
			AddComplexComponent( (BaseAddon) this, 10189, 2, -2, 3, 0, -1, "Robe", 1);// 111
			AddComplexComponent( (BaseAddon) this, 5990, -2, 0, 2, 2747, -1, "", 2);// 112
			AddComplexComponent( (BaseAddon) this, 2795, 1, -2, 0, 2751, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 2795, -1, -2, 0, 2751, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 3530, -1, 0, 5, 2747, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 5990, -3, 0, 3, 1, -1, "", 2);// 116
			AddComplexComponent( (BaseAddon) this, 5990, -3, 1, 1, 2747, -1, "", 2);// 118
			AddComplexComponent( (BaseAddon) this, 2791, -3, -2, 0, 2751, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 2795, 1, 0, 0, 2751, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 3, 2747, -1, "", 2);// 121
			AddComplexComponent( (BaseAddon) this, 2795, -1, -1, 0, 2751, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 2791, -3, 1, 0, 2751, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 3530, -2, -1, 4, 2747, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 5990, -3, -1, 0, 2747, -1, "", 2);// 125
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 3, 1, -1, "", 2);// 126
			AddComplexComponent( (BaseAddon) this, 7713, -1, -1, 6, 2670, -1, "Playboy", 1);// 127
			AddComplexComponent( (BaseAddon) this, 5990, -1, 1, 1, 2747, -1, "", 2);// 128
			AddComplexComponent( (BaseAddon) this, 5990, -2, 1, 2, 2747, -1, "", 2);// 129
			AddComplexComponent( (BaseAddon) this, 10082, -3, -3, 0, 2747, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 5990, -1, 0, 0, 2747, -1, "", 2);// 131
			AddComplexComponent( (BaseAddon) this, 5990, -2, -1, 0, 2747, -1, "", 4);// 132
			AddComplexComponent( (BaseAddon) this, 10079, -4, 2, 0, 2747, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 2795, 2, -2, 0, 2751, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 4633, -3, -1, 0, 2747, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 2790, 4, -3, 0, 2751, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 5690, -3, 0, 5, 2747, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 10136, -2, -2, 12, 2999, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 4633, -3, 1, 0, 2747, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 10079, -4, 1, 0, 2747, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 2793, 4, -1, 0, 2751, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 2793, 4, 1, 0, 2751, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 5990, -2, 0, 2, 1, -1, "", 2);// 143

		}

		public GuysAsianBedroomWEAddon( Serial serial ) : base( serial )
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

	public class GuysAsianBedroomWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GuysAsianBedroomWEAddon();
			}
		}

		[Constructable]
		public GuysAsianBedroomWEAddonDeed()
		{
			Name = "GuysAsianBedroomWE";
		}

		public GuysAsianBedroomWEAddonDeed( Serial serial ) : base( serial )
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