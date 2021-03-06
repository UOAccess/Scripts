
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
	public class LuminariWinterSidewalkAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6077, -1, -2, 0}, {6092, 2, 0, 0}, {6090, -2, -2, 0}// 1	4	5	
			, {6092, 2, -3, 0}, {6077, 1, 1, 0}, {6077, -1, -4, 0}// 6	8	9	
			, {6077, 1, -2, 0}, {6077, 1, -4, 0}, {6092, 2, 1, 0}// 10	11	12	
			, {6090, -2, -1, 0}, {6077, -1, -3, 0}, {6077, -1, 1, 0}// 13	14	15	
			, {6077, 0, 1, 0}, {6090, -2, 0, 0}, {6090, -2, -3, 0}// 16	17	18	
			, {6090, -2, -4, 0}, {6077, 1, -3, 0}, {6092, 2, -1, 0}// 19	20	21	
			, {6090, -2, 1, 0}, {6077, 0, -4, 0}, {6077, -1, 0, 0}// 22	23	26	
			, {6077, 0, -3, 0}, {6077, 1, 0, 0}, {6077, 0, 0, 0}// 27	28	29	
			, {6077, 0, -1, 0}, {6092, 2, -2, 0}, {6077, 1, -1, 0}// 30	31	32	
			, {6092, 2, -4, 0}, {6077, -1, -1, 0}, {6077, 0, -2, 0}// 33	35	36	
			, {6077, 0, 2, 0}, {6090, -2, 3, 0}, {6089, 0, 5, 0}// 37	38	39	
			, {6077, 1, 4, 0}, {6092, 2, 4, 0}, {6077, 1, 2, 0}// 40	41	42	
			, {6087, 2, 5, 0}, {6089, 1, 5, 0}, {6077, 0, 3, 0}// 43	44	45	
			, {6077, -1, 3, 0}, {6088, -2, 5, 0}, {6090, -2, 4, 0}// 48	49	50	
			, {6090, -2, 2, 0}, {6077, 1, 3, 0}, {6089, -1, 5, 0}// 52	53	55	
			, {6077, -1, 4, 0}, {6077, 0, 4, 0}, {6092, 2, 3, 0}// 56	57	58	
			, {6092, 2, 2, 0}, {6077, -1, 2, 0}// 59	60	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LuminariWinterSidewalkAddonDeed();
			}
		}

		[ Constructable ]
		public LuminariWinterSidewalkAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9405, -1, 0, 0, 2698, 1, "A Luminari", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9405, -1, -4, 0, 2999, 1, "A Luminari", 1);// 3
			AddComplexComponent( (BaseAddon) this, 9405, 1, -2, 0, 2896, 0, "A Luminari", 1);// 7
			AddComplexComponent( (BaseAddon) this, 9405, -1, -2, 0, 2896, 1, "A Luminari", 1);// 24
			AddComplexComponent( (BaseAddon) this, 9405, 1, 0, 0, 2698, 0, "A Luminari", 1);// 25
			AddComplexComponent( (BaseAddon) this, 9405, 1, -4, 0, 2999, 0, "A Luminari", 1);// 34
			AddComplexComponent( (BaseAddon) this, 9405, 1, 2, 0, 2705, 0, "A Luminari", 1);// 46
			AddComplexComponent( (BaseAddon) this, 9405, -1, 4, 0, 2718, 1, "A Luminari", 1);// 47
			AddComplexComponent( (BaseAddon) this, 9405, -1, 2, 0, 2705, 1, "A Luminari", 1);// 51
			AddComplexComponent( (BaseAddon) this, 9405, 1, 4, 0, 2718, 0, "A Luminari", 1);// 54

		}

		public LuminariWinterSidewalkAddon( Serial serial ) : base( serial )
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

	public class LuminariWinterSidewalkAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LuminariWinterSidewalkAddon();
			}
		}

		[Constructable]
		public LuminariWinterSidewalkAddonDeed()
		{
			Name = "LuminariWinterSidewalk";
		}

		public LuminariWinterSidewalkAddonDeed( Serial serial ) : base( serial )
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