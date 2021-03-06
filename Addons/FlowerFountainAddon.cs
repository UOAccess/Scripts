
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
	public class FlowerFountainAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13422, -2, -3, 14}, {13422, 0, 0, 1}, {13422, 0, 1, 1}// 3	33	34	
			, {13422, 0, 2, 1}, {13422, 0, 3, 1}, {13422, 1, 0, 1}// 35	36	37	
			, {13422, 1, 1, 1}, {13422, 1, 2, 1}, {13422, 1, 3, 1}// 38	39	40	
			, {13553, -1, 0, 2}, {13552, -1, 1, 3}, {13551, -1, 2, 3}// 41	42	43	
			, {13597, -2, -1, 8}, {13422, -3, -2, 14}, {13422, -2, -2, 14}// 44	45	46	
			, {13422, -1, -2, 14}, {3231, -2, -2, 22}, {13422, -2, 0, 8}// 47	48	49	
			, {13422, -2, 1, 8}, {13422, -1, 0, 1}, {13422, -1, 1, 1}// 50	51	52	
			, {13422, -1, 2, 1}, {13422, -1, -1, 1}, {13422, -2, -2, 1}// 53	54	55	
			, {13422, -2, -1, 1}, {13567, 0, 0, 2}, {13567, 0, 1, 2}// 56	57	58	
			, {13567, 0, 2, 2}, {13573, 1, 0, 2}, {13573, 1, 1, 2}// 59	60	61	
			, {13573, 1, 2, 2}, {3224, 0, 4, 9}, {3237, -2, 2, 8}// 62	63	64	
			, {3241, -3, 3, 1}, {219, -2, 3, 3}, {219, -1, 0, 12}// 65	66	67	
			, {219, 1, 0, 2}, {9037, 0, 3, 4}, {3224, 1, -1, 1}// 68	69	70	
			, {3338, 1, 1, 4}, {3205, 0, -2, 27}, {3231, 0, -2, 23}// 71	72	73	
			, {6815, 0, 0, 5}, {3203, -3, -1, 21}, {3203, 0, -1, 22}// 74	75	76	
			, {3149, 1, -1, 2}, {3149, 0, -1, 22}, {3149, -2, 2, 11}// 77	78	79	
			, {3149, -3, -1, 21}, {3149, 0, 4, 10}, {3245, 1, 4, 1}// 80	81	82	
			, {3246, 0, 4, 1}, {3246, -1, 4, 1}, {13603, -2, 0, 9}// 83	84	85	
			, {3210, -2, 1, 13}, {6817, -2, 0, 0}, {13422, 2, 0, 1}// 86	87	95	
			, {13422, 2, 1, 1}, {13422, 2, 2, 1}, {13422, 2, 3, 1}// 96	97	98	
			, {219, 2, 3, 11}, {3335, 2, 3, 4}, {3241, 2, -1, 9}// 99	100	101	
			, {3212, 3, 3, 1}, {3211, 2, 4, 1}, {3204, 3, 4, 7}// 102	103	104	
			, {3255, 3, 0, 8}, {3149, 3, 4, 7}, {3244, 3, 0, 1}// 105	106	107	
			, {3247, 3, 1, 1}, {3248, 3, 2, 1}// 108	109	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FlowerFountainAddonDeed();
			}
		}

		[ Constructable ]
		public FlowerFountainAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9537, -2, -3, 1, 1894, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 9551, -1, -3, 1, 1894, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9535, -3, -2, 1, 1894, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 9546, -3, -1, 1, 1894, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 9553, 0, -2, 1, 1894, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 471, -1, -1, 1, 1894, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 466, -3, -1, 1, 1894, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 470, -2, -1, 1, 1894, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 9543, 0, -1, 1, 1894, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 490, -1, 3, 1, 1894, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 489, 0, 3, 1, 1894, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 489, 1, 3, 1, 1894, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 489, 0, -1, 1, 1894, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 489, 1, -1, 1, 1894, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 224, 0, -1, 4, 1894, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 225, 1, -1, 4, 1894, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 231, -3, 0, 1, 1894, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 231, -3, 1, 1, 1894, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 231, -3, 2, 1, 1894, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 231, -3, 0, 4, 1894, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 231, -3, 1, 4, 1894, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 231, -3, 2, 4, 1894, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 231, -3, 0, 7, 1894, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 231, -3, 1, 7, 1894, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 231, -3, 2, 7, 1894, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 230, -2, 2, 1, 1894, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 230, -1, 2, 1, 1894, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 230, -2, 2, 4, 1894, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 230, -1, 2, 4, 1894, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 230, -1, 2, 7, 1894, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 230, -2, 2, 7, 1894, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 490, 2, 1, 1, 1894, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 490, 2, 0, 1, 1894, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 489, 2, -1, 1, 1894, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 488, 2, 3, 1, 1894, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 490, 2, 2, 1, 1894, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 227, 2, 0, 4, 1894, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 222, 2, -1, 4, 1894, -1, "", 1);// 94

		}

		public FlowerFountainAddon( Serial serial ) : base( serial )
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

	public class FlowerFountainAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FlowerFountainAddon();
			}
		}

		[Constructable]
		public FlowerFountainAddonDeed()
		{
			Name = "FlowerFountain";
		}

		public FlowerFountainAddonDeed( Serial serial ) : base( serial )
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