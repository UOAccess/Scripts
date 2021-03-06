/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_TreeHouseBaseAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_TreeHouseBaseAddonDeed();
			}
		}

		[ Constructable ]
		public AG_TreeHouseBaseAddon()
		{
			AddComponent( new AddonComponent( 12293 ), 2, -4, 45 );
			AddComponent( new AddonComponent( 11769 ), 2, -4, 65 );
			AddComponent( new AddonComponent( 11576 ), 2, -4, 65 );
			AddComponent( new AddonComponent( 11769 ), 2, -3, 65 );
			AddComponent( new AddonComponent( 12293 ), 2, -3, 45 );
			AddComponent( new AddonComponent( 11576 ), 2, -3, 65 );
			AddComponent( new AddonComponent( 12557 ), 2, -8, 45 );
			AddComponent( new AddonComponent( 11770 ), 2, -8, 65 );
			AddComponent( new AddonComponent( 12293 ), 1, 0, 45 );
			AddComponent( new AddonComponent( 12557 ), 1, 0, 45 );
			AddComponent( new AddonComponent( 11576 ), 1, 0, 65 );
			AddComponent( new AddonComponent( 11770 ), 1, 0, 65 );
			AddComponent( new AddonComponent( 12293 ), 1, -1, 45 );
			AddComponent( new AddonComponent( 11576 ), 1, -1, 65 );
			AddComponent( new AddonComponent( 12293 ), 1, -4, 45 );
			AddComponent( new AddonComponent( 11576 ), 1, -4, 65 );
			AddComponent( new AddonComponent( 12293 ), 1, -6, 45 );
			AddComponent( new AddonComponent( 12293 ), 1, -7, 45 );
			AddComponent( new AddonComponent( 2213 ), 1, -7, 45 );
			AddComponent( new AddonComponent( 11576 ), 0, -4, 65 );
			AddComponent( new AddonComponent( 12293 ), 0, -4, 45 );
			AddComponent( new AddonComponent( 12293 ), -3, -1, 45 );
			AddComponent( new AddonComponent( 11576 ), -3, -1, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, 1, 36 );
			AddComponent( new AddonComponent( 2213 ), -2, 1, 31 );
			AddComponent( new AddonComponent( 12293 ), -2, 2, 36 );
			AddComponent( new AddonComponent( 11576 ), -2, -5, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, -5, 45 );
			AddComponent( new AddonComponent( 11576 ), -2, -4, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, -4, 45 );
			AddComponent( new AddonComponent( 12293 ), -5, -4, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, -4, 65 );
			AddComponent( new AddonComponent( 12293 ), -5, -5, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, -5, 65 );
			AddComponent( new AddonComponent( 11769 ), -3, 8, 20 );
			AddComponent( new AddonComponent( 11769 ), -3, 7, 20 );
			AddComponent( new AddonComponent( 2214 ), 1, 6, 0 );
			AddComponent( new AddonComponent( 2206 ), 4, -3, 24 );
			AddComponent( new AddonComponent( 2214 ), 1, 7, 0 );
			AddComponent( new AddonComponent( 12293 ), 0, 7, 20 );
			AddComponent( new AddonComponent( 11769 ), 0, 8, 20 );
			AddComponent( new AddonComponent( 11770 ), 0, 8, 20 );
			AddComponent( new AddonComponent( 12293 ), 0, 8, 20 );
			AddComponent( new AddonComponent( 12293 ), 2, -2, 45 );
			AddComponent( new AddonComponent( 12556 ), 2, -2, 45 );
			AddComponent( new AddonComponent( 11769 ), 2, -2, 65 );
			AddComponent( new AddonComponent( 11576 ), 2, -2, 65 );
			AddComponent( new AddonComponent( 12557 ), -3, -8, 45 );
			AddComponent( new AddonComponent( 11770 ), -3, -8, 65 );
			AddComponent( new AddonComponent( 12557 ), -2, -8, 45 );
			AddComponent( new AddonComponent( 11770 ), -2, -8, 65 );
			AddComponent( new AddonComponent( 11576 ), -2, -7, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, -7, 45 );
			AddComponent( new AddonComponent( 11576 ), -2, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, -6, 45 );
			AddComponent( new AddonComponent( 11576 ), 0, -7, 65 );
			AddComponent( new AddonComponent( 12293 ), 0, -7, 45 );
			AddComponent( new AddonComponent( 11576 ), 0, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), 0, -6, 45 );
			AddComponent( new AddonComponent( 12293 ), 0, 0, 45 );
			AddComponent( new AddonComponent( 12557 ), 0, 0, 45 );
			AddComponent( new AddonComponent( 11576 ), 0, 0, 65 );
			AddComponent( new AddonComponent( 11770 ), 0, 0, 65 );
			AddComponent( new AddonComponent( 11770 ), 0, 0, 36 );
			AddComponent( new AddonComponent( 12293 ), 0, -5, 45 );
			AddComponent( new AddonComponent( 11576 ), 0, -5, 65 );
			AddComponent( new AddonComponent( 12557 ), -3, 0, 45 );
			AddComponent( new AddonComponent( 12293 ), -3, 0, 45 );
			AddComponent( new AddonComponent( 11770 ), -3, 0, 65 );
			AddComponent( new AddonComponent( 11576 ), -3, 0, 65 );
			AddComponent( new AddonComponent( 12289 ), -5, 1, 0 );
			AddComponent( new AddonComponent( 11769 ), -3, 2, 36 );
			AddComponent( new AddonComponent( 11576 ), -1, -5, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, -5, 45 );
			AddComponent( new AddonComponent( 12293 ), -1, 2, 36 );
			AddComponent( new AddonComponent( 12293 ), -1, 1, 36 );
			AddComponent( new AddonComponent( 2213 ), -1, 1, 32 );
			AddComponent( new AddonComponent( 11576 ), -4, -5, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, -5, 45 );
			AddComponent( new AddonComponent( 11576 ), -3, -3, 65 );
			AddComponent( new AddonComponent( 12293 ), -3, -3, 45 );
			AddComponent( new AddonComponent( 12293 ), -2, 7, 20 );
			AddComponent( new AddonComponent( 12293 ), -1, 5, 20 );
			AddComponent( new AddonComponent( 2213 ), -1, 5, 16 );
			AddComponent( new AddonComponent( 12293 ), -1, 4, 36 );
			AddComponent( new AddonComponent( 12293 ), -1, 3, 36 );
			AddComponent( new AddonComponent( 12556 ), -6, -1, 45 );
			AddComponent( new AddonComponent( 11769 ), -6, -1, 65 );
			AddComponent( new AddonComponent( 12556 ), -6, 0, 45 );
			AddComponent( new AddonComponent( 11769 ), -6, 0, 65 );
			AddComponent( new AddonComponent( 2213 ), -2, 5, 16 );
			AddComponent( new AddonComponent( 12293 ), -2, 5, 20 );
			AddComponent( new AddonComponent( 12293 ), -2, 6, 20 );
			AddComponent( new AddonComponent( 12293 ), 2, -1, 45 );
			AddComponent( new AddonComponent( 12556 ), 2, -1, 45 );
			AddComponent( new AddonComponent( 11576 ), 2, -1, 65 );
			AddComponent( new AddonComponent( 11769 ), 2, -1, 65 );
			AddComponent( new AddonComponent( 12293 ), 2, 0, 45 );
			AddComponent( new AddonComponent( 12562 ), 2, 0, 45 );
			AddComponent( new AddonComponent( 11769 ), 2, 0, 65 );
			AddComponent( new AddonComponent( 11576 ), 2, 0, 65 );
			AddComponent( new AddonComponent( 11770 ), 2, 0, 65 );
			AddComponent( new AddonComponent( 12293 ), 2, -5, 45 );
			AddComponent( new AddonComponent( 12556 ), 2, -5, 45 );
			AddComponent( new AddonComponent( 11769 ), 2, -5, 65 );
			AddComponent( new AddonComponent( 11576 ), 2, -5, 65 );
			AddComponent( new AddonComponent( 12556 ), 2, -7, 45 );
			AddComponent( new AddonComponent( 12293 ), 2, -7, 45 );
			AddComponent( new AddonComponent( 11576 ), 2, -7, 65 );
			AddComponent( new AddonComponent( 11769 ), 2, -7, 65 );
			AddComponent( new AddonComponent( 12556 ), 2, -6, 45 );
			AddComponent( new AddonComponent( 11769 ), 2, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), 2, -6, 45 );
			AddComponent( new AddonComponent( 11576 ), 2, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), 1, -3, 45 );
			AddComponent( new AddonComponent( 11576 ), 1, -3, 65 );
			AddComponent( new AddonComponent( 12293 ), 1, -5, 45 );
			AddComponent( new AddonComponent( 11576 ), 1, -5, 65 );
			AddComponent( new AddonComponent( 12293 ), 1, -2, 45 );
			AddComponent( new AddonComponent( 11576 ), 1, -2, 65 );
			AddComponent( new AddonComponent( 11576 ), 0, -3, 65 );
			AddComponent( new AddonComponent( 12293 ), 0, -3, 45 );
			AddComponent( new AddonComponent( 11576 ), 0, -2, 65 );
			AddComponent( new AddonComponent( 12293 ), 0, -2, 45 );
			AddComponent( new AddonComponent( 12557 ), -5, 0, 45 );
			AddComponent( new AddonComponent( 11770 ), -5, 0, 65 );
			AddComponent( new AddonComponent( 12293 ), -5, 0, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, 0, 65 );
			AddComponent( new AddonComponent( 12293 ), -5, -1, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, -1, 65 );
			AddComponent( new AddonComponent( 11576 ), -3, -4, 65 );
			AddComponent( new AddonComponent( 12293 ), -3, -4, 45 );
			AddComponent( new AddonComponent( 12293 ), -3, -5, 45 );
			AddComponent( new AddonComponent( 11576 ), -3, -5, 65 );
			AddComponent( new AddonComponent( 11576 ), -1, 0, 65 );
			AddComponent( new AddonComponent( 11770 ), -1, 0, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, 0, 45 );
			AddComponent( new AddonComponent( 11576 ), -2, -2, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, -2, 45 );
			AddComponent( new AddonComponent( 11769 ), 0, 5, 20 );
			AddComponent( new AddonComponent( 12293 ), 0, 5, 20 );
			AddComponent( new AddonComponent( 12293 ), 0, 6, 20 );
			AddComponent( new AddonComponent( 2206 ), 5, -4, 12 );
			AddComponent( new AddonComponent( 2206 ), 3, -3, 36 );
			AddComponent( new AddonComponent( 2206 ), 3, -4, 36 );
			AddComponent( new AddonComponent( 2206 ), 5, -3, 12 );
			AddComponent( new AddonComponent( 2206 ), 6, -4, 0 );
			AddComponent( new AddonComponent( 2206 ), 6, -3, 0 );
			AddComponent( new AddonComponent( 12293 ), -5, -6, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), -5, -7, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, -7, 65 );
			AddComponent( new AddonComponent( 12557 ), -5, -8, 45 );
			AddComponent( new AddonComponent( 11770 ), -5, -8, 65 );
			AddComponent( new AddonComponent( 12557 ), -4, -8, 45 );
			AddComponent( new AddonComponent( 11770 ), -4, -8, 65 );
			AddComponent( new AddonComponent( 12557 ), 1, -8, 45 );
			AddComponent( new AddonComponent( 11770 ), 1, -8, 65 );
			AddComponent( new AddonComponent( 12293 ), 0, -1, 45 );
			AddComponent( new AddonComponent( 11576 ), 0, -1, 65 );
			AddComponent( new AddonComponent( 11769 ), 0, 1, 36 );
			AddComponent( new AddonComponent( 12293 ), 0, 1, 36 );
			AddComponent( new AddonComponent( 11769 ), 0, 2, 36 );
			AddComponent( new AddonComponent( 12293 ), 0, 2, 36 );
			AddComponent( new AddonComponent( 11576 ), -1, -2, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, -2, 45 );
			AddComponent( new AddonComponent( 11576 ), -1, -3, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, -3, 45 );
			AddComponent( new AddonComponent( 11576 ), -4, -1, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, -1, 45 );
			AddComponent( new AddonComponent( 12557 ), -4, 0, 45 );
			AddComponent( new AddonComponent( 11770 ), -4, 0, 65 );
			AddComponent( new AddonComponent( 11576 ), -4, 0, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, 0, 45 );
			AddComponent( new AddonComponent( 11576 ), -4, -3, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, -3, 45 );
			AddComponent( new AddonComponent( 11576 ), -4, -2, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, -2, 45 );
			AddComponent( new AddonComponent( 12293 ), -2, -3, 45 );
			AddComponent( new AddonComponent( 11576 ), -2, -3, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, -4, 45 );
			AddComponent( new AddonComponent( 11576 ), -4, -4, 65 );
			AddComponent( new AddonComponent( 12556 ), -6, -5, 45 );
			AddComponent( new AddonComponent( 11769 ), -6, -5, 65 );
			AddComponent( new AddonComponent( 12556 ), -6, -4, 45 );
			AddComponent( new AddonComponent( 11769 ), -6, -4, 65 );
			AddComponent( new AddonComponent( 11769 ), 0, 3, 36 );
			AddComponent( new AddonComponent( 12293 ), 0, 3, 36 );
			AddComponent( new AddonComponent( 11770 ), 0, 4, 36 );
			AddComponent( new AddonComponent( 11769 ), 0, 4, 36 );
			AddComponent( new AddonComponent( 11770 ), 0, 4, 20 );
			AddComponent( new AddonComponent( 12293 ), 0, 4, 36 );
			AddComponent( new AddonComponent( 11769 ), -3, 4, 36 );
			AddComponent( new AddonComponent( 11769 ), -3, 3, 36 );
			AddComponent( new AddonComponent( 12293 ), -1, 8, 20 );
			AddComponent( new AddonComponent( 11770 ), -1, 8, 20 );
			AddComponent( new AddonComponent( 12293 ), -1, 7, 20 );
			AddComponent( new AddonComponent( 2206 ), 4, -4, 24 );
			AddComponent( new AddonComponent( 12289 ), 3, -7, 0 );
			AddComponent( new AddonComponent( 12289 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 12289 ), -6, -8, 0 );
			AddComponent( new AddonComponent( 12556 ), -6, -7, 45 );
			AddComponent( new AddonComponent( 11769 ), -6, -7, 65 );
			AddComponent( new AddonComponent( 12556 ), -6, -6, 45 );
			AddComponent( new AddonComponent( 11769 ), -6, -6, 65 );
			AddComponent( new AddonComponent( 11576 ), -4, -7, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, -7, 45 );
			AddComponent( new AddonComponent( 11576 ), -4, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), -4, -6, 45 );
			AddComponent( new AddonComponent( 11576 ), -3, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), -3, -6, 45 );
			AddComponent( new AddonComponent( 11576 ), -3, -7, 65 );
			AddComponent( new AddonComponent( 12293 ), -3, -7, 45 );
			AddComponent( new AddonComponent( 11576 ), -1, -6, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, -6, 45 );
			AddComponent( new AddonComponent( 11576 ), -1, -7, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, -7, 45 );
			AddComponent( new AddonComponent( 12557 ), -1, -8, 45 );
			AddComponent( new AddonComponent( 11770 ), -1, -8, 65 );
			AddComponent( new AddonComponent( 11770 ), 0, -8, 65 );
			AddComponent( new AddonComponent( 12557 ), 0, -8, 45 );
			AddComponent( new AddonComponent( 11576 ), -2, -1, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, -1, 45 );
			AddComponent( new AddonComponent( 11770 ), -2, 0, 65 );
			AddComponent( new AddonComponent( 11576 ), -2, 0, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, 0, 45 );
			AddComponent( new AddonComponent( 11576 ), -1, -4, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, -4, 45 );
			AddComponent( new AddonComponent( 11769 ), -3, 1, 36 );
			AddComponent( new AddonComponent( 12293 ), -5, -2, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, -2, 65 );
			AddComponent( new AddonComponent( 12293 ), -5, -3, 45 );
			AddComponent( new AddonComponent( 11576 ), -5, -3, 65 );
			AddComponent( new AddonComponent( 11576 ), -3, -2, 65 );
			AddComponent( new AddonComponent( 12293 ), -3, -2, 45 );
			AddComponent( new AddonComponent( 11576 ), -1, -1, 65 );
			AddComponent( new AddonComponent( 12293 ), -1, -1, 45 );
			AddComponent( new AddonComponent( 12293 ), -1, 6, 20 );
			AddComponent( new AddonComponent( 11770 ), -2, 8, 20 );
			AddComponent( new AddonComponent( 12293 ), -2, 8, 20 );
			AddComponent( new AddonComponent( 11769 ), -6, -3, 65 );
			AddComponent( new AddonComponent( 12556 ), -6, -3, 45 );
			AddComponent( new AddonComponent( 12556 ), -6, -2, 45 );
			AddComponent( new AddonComponent( 11769 ), -6, -2, 65 );
			AddComponent( new AddonComponent( 12293 ), -2, 3, 36 );
			AddComponent( new AddonComponent( 12293 ), -2, 4, 36 );
			AddComponent( new AddonComponent( 11769 ), -3, 6, 20 );
			AddComponent( new AddonComponent( 11769 ), -3, 5, 20 );
			AddonComponent ac;
			ac = new AddonComponent( 12289 );
			AddComponent( ac, -6, -8, 0 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -4, -8, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, 2, -8, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, -7, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, -7, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, 1, -8, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -1, -8, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -2, -8, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -3, -8, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -5, -8, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, 2, -7, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, 2, -6, 45 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -3, -8, 65 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, -6, 45 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, -7, 65 );
			ac = new AddonComponent( 2213 );
			AddComponent( ac, 1, -7, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, -7, 45 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -5, -8, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -4, -8, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 0, -8, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -2, -8, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, -6, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, -7, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, -6, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, -7, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, -7, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, -6, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, -7, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, -6, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, -7, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 1, -8, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, -6, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, -6, 65 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, -7, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, -7, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, -7, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, -7, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, -7, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, -6, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, -7, 45 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, -6, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, -7, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 2, -8, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, -7, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, -6, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -1, -8, 65 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, 0, -8, 45 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, -6, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, -7, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 0, 4, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, 0, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, -1, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, -5, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, 0, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, -1, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, -3, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 1, -5, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 0, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, -1, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, 1, 0, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, 0, 0, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -3, 0, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -4, 0, 45 );
			ac = new AddonComponent( 12557 );
			AddComponent( ac, -5, 0, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, 2, -5, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, 2, -2, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, 2, -1, 45 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, -3, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -5, 0, 65 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, 0, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, -1, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, -2, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, -3, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, -4, 45 );
			ac = new AddonComponent( 12556 );
			AddComponent( ac, -6, -5, 45 );
			ac = new AddonComponent( 12562 );
			AddComponent( ac, 2, 0, 45 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, 0, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, -3, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, -4, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, -5, 65 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, 0, 45 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 8, 20 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 5, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 7, 20 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, 0, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, -2, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, -5, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -3, 0, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -2, 0, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, -2, 65 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, -5, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 2, -3, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, -5, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, 0, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, -1, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, -3, 45 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 0, 8, 20 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 0, 5, 20 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 7, 20 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 6, 20 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 4, 36 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 3, 36 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 2, 36 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -3, 1, 36 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 0, 4, 36 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 0, 3, 36 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 0, 2, 36 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 0, 1, 36 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -4, 0, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, 0, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 2, -5, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 1, 0, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 1, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 1, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 1, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 1, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 1, -5, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, 0, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, -5, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, 0, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -1, -5, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, 0, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, -5, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, 0, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -4, -5, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, 0, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -1, 0, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 0, 0, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 1, 0, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 2, 0, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, 2, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, 0, -4, 65 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 1, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 1, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 1, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 2, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 2, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 2, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 8, 20 );
			ac = new AddonComponent( 12289 );
			AddComponent( ac, -5, 1, 0 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, -5, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, 0, 65 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, -3, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 0, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, -1, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, -3, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, -5, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 0, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, -1, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, -3, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, -5, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, -1, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, -3, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -3, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, 0, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, -1, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, -3, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -4, -5, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, -2, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, -4, 45 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -5, -5, 45 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 0, 4, 20 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -2, 8, 20 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, -1, 65 );
			ac = new AddonComponent( 11769 );
			AddComponent( ac, -6, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -3, -1, 65 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 0, 0, 36 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, 0, 8, 20 );
			ac = new AddonComponent( 11770 );
			AddComponent( ac, -1, 8, 20 );
			ac = new AddonComponent( 2213 );
			AddComponent( ac, -1, 1, 32 );
			ac = new AddonComponent( 2213 );
			AddComponent( ac, -2, 1, 31 );
			ac = new AddonComponent( 2213 );
			AddComponent( ac, -2, 5, 16 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 8, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 7, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 6, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 7, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 6, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 5, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 4, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 3, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 4, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -1, 3, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 4, 36 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 3, 36 );
			ac = new AddonComponent( 2213 );
			AddComponent( ac, -1, 5, 16 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, 0, 5, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 8, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 6, 20 );
			ac = new AddonComponent( 12293 );
			AddComponent( ac, -2, 5, 20 );
			ac = new AddonComponent( 2214 );
			AddComponent( ac, 1, 7, 0 );
			ac = new AddonComponent( 2214 );
			AddComponent( ac, 1, 6, 0 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -2, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, -1, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, -2, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, -3, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, -4, 65 );
			ac = new AddonComponent( 11576 );
			AddComponent( ac, -5, -5, 65 );
			ac = new AddonComponent( 12289 );
			AddComponent( ac, 3, -7, 0 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 4, -4, 24 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 4, -3, 24 );
			ac = new AddonComponent( 12289 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 3, -3, 36 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 5, -3, 12 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 6, -3, 0 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 3, -4, 36 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 5, -4, 12 );
			ac = new AddonComponent( 2206 );
			AddComponent( ac, 6, -4, 0 );

		}

		public AG_TreeHouseBaseAddon( Serial serial ) : base( serial )
		{
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

	public class AG_TreeHouseBaseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_TreeHouseBaseAddon();
			}
		}

		[Constructable]
		public AG_TreeHouseBaseAddonDeed()
		{
			Name = "AG_TreeHouseBase";
		}

		public AG_TreeHouseBaseAddonDeed( Serial serial ) : base( serial )
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