
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
	public class VampDungunCoffinsAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4306, -1, -2, 0}, {4651, -2, -2, 0}, {4650, 2, -2, 0}// 32	35	67	
			, {14013, 0, 1, 0}, {4308, 2, 3, 0}, {4654, 3, 3, 0}// 80	104	112	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new VampDungunCoffinsAddonDeed();
			}
		}

		[ Constructable ]
		public VampDungunCoffinsAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2743, -4, 2, 0, 2574, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2739, -1, -3, 0, 2574, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2739, -3, 2, 0, 2574, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2743, -4, -1, 0, 2574, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2740, -1, -4, 0, 2574, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7466, -1, -3, 0, 2273, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 7479, -3, 1, 0, 2273, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2739, -3, 0, 0, 2574, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2743, -4, 1, 0, 2574, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 7467, -1, -4, 0, 2273, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2740, -2, -4, 0, 2574, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2748, -2, 1, 0, 2574, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2748, -1, 2, 0, 2574, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2743, -4, 0, 0, 2574, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 7467, -1, 2, 0, 2273, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2743, -4, -3, 0, 2574, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4627, -1, 1, 0, 2118, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2748, -1, 1, 0, 2574, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2748, -2, 2, 0, 2574, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2739, -3, -2, 0, 2574, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2748, -2, 0, 0, 2574, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2739, -3, 1, 0, 2574, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2748, -1, -1, 0, 2574, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 4630, -1, 0, 0, 2118, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 4628, -2, 1, 0, 2118, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2748, -2, -2, 0, 2574, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2739, -2, -3, 0, 2574, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2739, -3, -3, 0, 2574, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2743, -4, -2, 0, 2574, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 4622, -2, -1, 0, 2118, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 7481, -3, -1, 0, 2273, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 7480, -3, 0, 0, 2273, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 4629, -2, 0, 0, 2118, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 4623, -1, -1, 0, 2118, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2748, -1, -2, 0, 2574, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2740, -3, -4, 0, 2574, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2748, -2, -1, 0, 2574, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2739, -3, -1, 0, 2574, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2744, -4, -4, 0, 2574, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2748, -1, 0, 0, 2574, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 7466, -1, 3, 0, 2273, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2854, -3, 3, 0, 0, 1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2748, -2, 3, 0, 2574, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2742, -2, 4, 0, 2574, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2743, -4, 3, 0, 2574, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2742, -1, 4, 0, 2574, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2742, -3, 4, 0, 2574, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2748, -1, 3, 0, 2574, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 2739, -3, 3, 0, 2574, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2747, -4, 4, 0, 2574, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 2748, 1, 2, 0, 2574, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 2740, 2, -4, 0, 2574, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2740, 3, -4, 0, 2574, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 7479, 2, 1, 0, 2273, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2739, 3, -3, 0, 2574, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 2748, 0, -1, 0, 2574, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 2748, 2, -2, 0, 2574, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 2854, 3, -3, 0, 0, 1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2745, 4, -4, 0, 2574, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 2741, 4, 0, 0, 2574, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 2748, 3, 1, 0, 2574, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 7465, 0, -3, 0, 2273, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2748, 1, -1, 0, 2574, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 7468, 0, -4, 0, 2273, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 2741, 4, 1, 0, 2574, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 2748, 3, -1, 0, 2574, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 7480, 2, 0, 0, 2273, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2740, 1, -4, 0, 2574, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 7481, 2, -1, 0, 2273, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 2748, 3, -2, 0, 2574, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2739, 0, -3, 0, 2574, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 2748, 2, -1, 0, 2574, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 2748, 2, 0, 0, 2574, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 7458, 1, -4, 0, 2273, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 7464, 1, -3, 0, 2273, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 2748, 3, 0, 0, 2574, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 2741, 4, -3, 0, 2574, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 4625, 0, 0, 0, 2118, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 2739, 1, -3, 0, 2574, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 2740, 0, -4, 0, 2574, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 2739, 2, -3, 0, 2574, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 7468, 0, 2, 0, 2273, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 2748, 2, 1, 0, 2574, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 4624, 0, -1, 0, 2118, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 2741, 4, 2, 0, 2574, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 2748, 1, -2, 0, 2574, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 2748, 0, -2, 0, 2574, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 2748, 0, 1, 0, 2574, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 2748, 3, 2, 0, 2574, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 4626, 0, 1, 0, 2118, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 7458, 1, 2, 0, 2273, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 2748, 0, 0, 0, 2574, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 2741, 4, -1, 0, 2574, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 2748, 1, 0, 0, 2574, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 2748, 0, 2, 0, 2574, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 2741, 4, -2, 0, 2574, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 2748, 1, 1, 0, 2574, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 2748, 2, 2, 0, 2574, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 2742, 3, 4, 0, 2574, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 2748, 2, 3, 0, 2574, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 2748, 1, 3, 0, 2574, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 2742, 2, 4, 0, 2574, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 2746, 4, 4, 0, 2574, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 7464, 1, 3, 0, 2273, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 2748, 0, 3, 0, 2574, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 2742, 0, 4, 0, 2574, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 2741, 4, 3, 0, 2574, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 2742, 1, 4, 0, 2574, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 7465, 0, 3, 0, 2273, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 2748, 3, 3, 0, 2574, -1, "", 1);// 116

		}

		public VampDungunCoffinsAddon( Serial serial ) : base( serial )
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

	public class VampDungunCoffinsAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new VampDungunCoffinsAddon();
			}
		}

		[Constructable]
		public VampDungunCoffinsAddonDeed()
		{
			Name = "VampDungunCoffins";
		}

		public VampDungunCoffinsAddonDeed( Serial serial ) : base( serial )
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