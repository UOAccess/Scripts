
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
	public class marketstallAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2760, -5, -4, 0}, {2760, -5, -2, 0}, {2760, -5, 0, 0}// 2	4	6	
			, {2760, -5, 2, 0}, {2760, -5, 4, 0}, {2760, -4, -5, 0}// 8	10	11	
			, {2760, -4, -3, 0}, {2760, -4, -1, 0}, {2760, -4, 1, 0}// 13	15	17	
			, {2760, -4, 3, 0}, {2760, -3, -4, 0}, {2760, -3, -2, 0}// 19	22	24	
			, {2760, -3, 0, 0}, {2760, -3, 2, 0}, {2760, -3, 4, 0}// 26	28	30	
			, {2760, -2, -5, 0}, {2760, -2, -3, 0}, {2760, -2, -1, 0}// 31	33	35	
			, {2760, -2, 1, 0}, {2760, -2, 3, 0}, {2760, -1, -4, 0}// 37	39	48	
			, {2760, -1, -2, 0}, {2760, -1, 0, 0}, {2760, -1, 2, 0}// 50	52	54	
			, {2760, -1, 4, 0}, {2760, 0, -5, 0}, {2760, 0, -3, 0}// 56	57	59	
			, {2760, 0, -1, 0}, {2760, 0, 1, 0}, {2760, 0, 3, 0}// 61	63	65	
			, {2760, 1, -4, 0}, {2760, 1, -2, 0}, {2760, 1, 0, 0}// 68	70	72	
			, {2760, 1, 2, 0}, {2760, 1, 4, 0}, {2760, 2, -5, 0}// 74	76	77	
			, {2760, 2, -3, 0}, {2760, 2, -1, 0}, {2760, 2, 1, 0}// 79	81	83	
			, {2760, 2, 3, 0}, {2760, 3, -4, 0}, {2760, 3, -2, 0}// 85	88	90	
			, {2760, 3, 0, 0}, {2760, 3, 2, 0}, {2760, 3, 4, 0}// 92	94	96	
			, {2760, 4, -5, 0}, {2760, 4, -3, 0}, {2760, 4, -1, 0}// 97	99	101	
			, {2760, 4, 1, 0}, {2760, 4, 3, 0}// 103	105	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new marketstallAddonDeed();
			}
		}

		[ Constructable ]
		public marketstallAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2760, -5, -5, 0, 1153, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2760, -5, -3, 0, 1153, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2760, -5, -1, 0, 1153, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2760, -5, 1, 0, 1153, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2760, -5, 3, 0, 1153, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2760, -4, -4, 0, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2760, -4, -2, 0, 1153, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2760, -4, 0, 0, 1153, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2760, -4, 2, 0, 1153, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2760, -4, 4, 0, 1153, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2760, -3, -5, 0, 1153, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2760, -3, -3, 0, 1153, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2760, -3, -1, 0, 1153, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2760, -3, 1, 0, 1153, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2760, -3, 3, 0, 1153, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2760, -2, -4, 0, 1153, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2760, -2, -2, 0, 1153, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2760, -2, 0, 0, 1153, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2760, -2, 2, 0, 1153, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2760, -2, 4, 0, 1153, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2879, -4, 3, 0, 1, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2879, -4, -4, 0, 1, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2878, -3, -4, 0, 1, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2878, -2, -4, 0, 1, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2877, -3, 3, 0, 1, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2877, -2, 3, 0, 1, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2760, -1, -5, 0, 1153, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2760, -1, -3, 0, 1153, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2760, -1, -1, 0, 1153, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2760, -1, 1, 0, 1153, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 2760, -1, 3, 0, 1153, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 2760, 0, -4, 0, 1153, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 2760, 0, -2, 0, 1153, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2760, 0, 0, 0, 1153, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 2760, 0, 2, 0, 1153, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2760, 0, 4, 0, 1153, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 2760, 1, -5, 0, 1153, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2760, 1, -3, 0, 1153, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 2760, 1, -1, 0, 1153, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2760, 1, 1, 0, 1153, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2760, 1, 3, 0, 1153, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 2760, 2, -4, 0, 1153, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 2760, 2, -2, 0, 1153, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 2760, 2, 0, 0, 1153, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 2760, 2, 2, 0, 1153, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 2760, 2, 4, 0, 1153, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 2760, 3, -5, 0, 1153, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 2760, 3, -3, 0, 1153, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 2760, 3, -1, 0, 1153, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 2760, 3, 1, 0, 1153, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 2760, 3, 3, 0, 1153, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 2760, 4, -4, 0, 1153, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 2760, 4, -2, 0, 1153, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 2760, 4, 0, 0, 1153, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 2760, 4, 2, 0, 1153, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 2760, 4, 4, 0, 1153, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 2878, -1, -4, 0, 1, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 2878, 0, -4, 0, 1, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 2878, 1, -4, 0, 1, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 2878, 2, -4, 0, 1, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 2879, 3, -4, 0, 1, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 2877, 2, 3, 0, 1, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 2877, 1, 3, 0, 1, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 2877, 0, 3, 0, 1, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 2877, -1, 3, 0, 1, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 2879, 3, 3, 0, 1, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 2877, 3, -3, 0, 1, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 2877, 3, -2, 0, 1, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 2877, 3, -1, 0, 1, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 2877, 3, 0, 0, 1, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 2877, 3, 1, 0, 1, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 2877, 3, 2, 0, 1, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 2581, 5, -4, 20, 0, 1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 2591, 4, -5, 0, 33, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 2595, 3, -5, 13, 0, 1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 2591, 4, 4, 0, 33, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 2582, 5, 5, 20, 0, 1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 2595, 3, 4, 12, 0, 1, "", 1);// 128

		}

		public marketstallAddon( Serial serial ) : base( serial )
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

	public class marketstallAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new marketstallAddon();
			}
		}

		[Constructable]
		public marketstallAddonDeed()
		{
			Name = "marketstall";
		}

		public marketstallAddonDeed( Serial serial ) : base( serial )
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