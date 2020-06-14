
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
	public class witchycauldronSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3263, 0, -2, 1}, {3205, -1, -1, 8}, {7134, 0, 0, 0}// 1	2	4	
			, {3264, 1, -2, 1}, {4072, 0, -1, 1}, {3571, 0, 1, 1}// 7	8	9	
			, {3263, -1, -1, 1}, {3205, -2, -1, 1}, {4077, 1, 1, 1}// 10	13	14	
			, {4073, -1, 1, 1}, {4074, 0, 0, 1}, {4078, 1, 0, 1}// 15	16	19	
			, {3264, -2, 1, 1}, {4075, 1, -1, 1}, {4071, -1, -1, 1}// 20	21	22	
			, {4070, -1, 0, 1}, {4076, 0, 1, 1}, {3205, -1, -2, 1}// 23	24	25	
			, {3263, -2, 0, 1}// 26	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new witchycauldronSAddonDeed();
			}
		}

		[ Constructable ]
		public witchycauldronSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2912, 2, -1, 1, 1194, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2911, 2, 0, 1, 1194, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3834, 1, 0, 1, 1355, -1, "Ancient Spellbook", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2918, -1, 2, 1, 1194, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 6571, 0, 0, 4, 0, 29, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2541, 0, 0, 4, 1194, -1, "a cauldron", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2917, 0, 2, 1, 1194, -1, "", 1);// 18

		}

		public witchycauldronSAddon( Serial serial ) : base( serial )
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

	public class witchycauldronSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new witchycauldronSAddon();
			}
		}

		[Constructable]
		public witchycauldronSAddonDeed()
		{
			Name = "witchycauldronS";
		}

		public witchycauldronSAddonDeed( Serial serial ) : base( serial )
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