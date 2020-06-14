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
	public class LJCottageAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LJCottageAddonDeed();
			}
		}

		[ Constructable ]
		public LJCottageAddon()
		{
			AddComponent( new AddonComponent( 9977 ), 4, 0, 26 );
			AddComponent( new AddonComponent( 2882 ), 4, 0, 0 );
			AddComponent( new AddonComponent( 9977 ), 4, 1, 26 );
			AddComponent( new AddonComponent( 9977 ), 4, 2, 26 );
			AddComponent( new AddonComponent( 9977 ), 4, 3, 26 );
			AddComponent( new AddonComponent( 3645 ), 4, -3, 0 );
			AddComponent( new AddonComponent( 9977 ), 4, -3, 26 );
			AddComponent( new AddonComponent( 9977 ), 4, -2, 26 );
			AddComponent( new AddonComponent( 7135 ), 4, -2, 0 );
			AddComponent( new AddonComponent( 9977 ), 4, -1, 26 );
			AddComponent( new AddonComponent( 2881 ), 4, -1, 0 );
			AddComponent( new AddonComponent( 1 ), 4, -1, 0 );
			AddComponent( new AddonComponent( 9977 ), 4, 4, 26 );
			AddComponent( new AddonComponent( 9977 ), 4, 5, 26 );
			AddComponent( new AddonComponent( 1854 ), 1, 5, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, 5, 32 );
			AddComponent( new AddonComponent( 9977 ), 2, 5, 30 );
			AddComponent( new AddonComponent( 10368 ), 0, 4, 0 );
			AddComponent( new AddonComponent( 9976 ), 0, 4, 29 );
			AddComponent( new AddonComponent( 1849 ), 0, 5, 0 );
			AddComponent( new AddonComponent( 9976 ), 0, 5, 29 );
			AddComponent( new AddonComponent( 9978 ), -3, 5, 23 );
			AddComponent( new AddonComponent( 10368 ), -3, 4, 0 );
			AddComponent( new AddonComponent( 10368 ), -3, 4, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, 4, 23 );
			AddComponent( new AddonComponent( 149 ), -3, 4, 0 );
			AddComponent( new AddonComponent( 10368 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, -2, 25 );
			AddComponent( new AddonComponent( 10368 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 9976 ), 0, -3, 29 );
			AddComponent( new AddonComponent( 7760 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 2620 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 10368 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 9976 ), 0, -2, 29 );
			AddComponent( new AddonComponent( 7757 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 1 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 2602 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 10368 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 9976 ), 0, -1, 29 );
			AddComponent( new AddonComponent( 7754 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 2860 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, 1, 27 );
			AddComponent( new AddonComponent( 10368 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, 0, 27 );
			AddComponent( new AddonComponent( 2860 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 10368 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, 3, 27 );
			AddComponent( new AddonComponent( 9976 ), 0, 3, 29 );
			AddComponent( new AddonComponent( 10368 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 10368 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, 3, 32 );
			AddComponent( new AddonComponent( 10368 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, 2, 32 );
			AddComponent( new AddonComponent( 5453 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 10368 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, 1, 32 );
			AddComponent( new AddonComponent( 10368 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 145 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 9977 ), 3, 2, 28 );
			AddComponent( new AddonComponent( 10368 ), 3, -3, 0 );
			AddComponent( new AddonComponent( 14120 ), 3, -3, 37 );
			AddComponent( new AddonComponent( 2401 ), 3, -3, 17 );
			AddComponent( new AddonComponent( 1 ), 3, -3, 17 );
			AddComponent( new AddonComponent( 148 ), 3, -3, 0 );
			AddComponent( new AddonComponent( 151 ), 3, -4, 0 );
			AddComponent( new AddonComponent( 145 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 9977 ), 3, -1, 28 );
			AddComponent( new AddonComponent( 9977 ), 2, -3, 30 );
			AddComponent( new AddonComponent( 10368 ), 2, -3, 0 );
			AddComponent( new AddonComponent( 2407 ), 2, -3, 17 );
			AddComponent( new AddonComponent( 10368 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, -3, 27 );
			AddComponent( new AddonComponent( 7761 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 10 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, -1, 25 );
			AddComponent( new AddonComponent( 10 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, -1, 27 );
			AddComponent( new AddonComponent( 7755 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, -3, 25 );
			AddComponent( new AddonComponent( 2594 ), -2, -3, 14 );
			AddComponent( new AddonComponent( 2667 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, 2, 25 );
			AddComponent( new AddonComponent( 5735 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 10368 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 10368 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, 3, 25 );
			AddComponent( new AddonComponent( 10368 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, 0, 25 );
			AddComponent( new AddonComponent( 2594 ), -2, 0, 13 );
			AddComponent( new AddonComponent( 5737 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 10368 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, 2, 27 );
			AddComponent( new AddonComponent( 2860 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 146 ), 0, -4, 0 );
			AddComponent( new AddonComponent( 153 ), -4, 1, 0 );
			AddComponent( new AddonComponent( 9978 ), -4, 1, 21 );
			AddComponent( new AddonComponent( 9977 ), -2, -4, 0 );
			AddComponent( new AddonComponent( 146 ), -2, -4, 0 );
			AddComponent( new AddonComponent( 146 ), -2, -4, 0 );
			AddComponent( new AddonComponent( 9978 ), -4, 3, 21 );
			AddComponent( new AddonComponent( 145 ), -4, 3, 0 );
			AddComponent( new AddonComponent( 10368 ), -3, 3, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, 3, 23 );
			AddComponent( new AddonComponent( 3130 ), -3, 3, 1 );
			AddComponent( new AddonComponent( 10368 ), -3, 2, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, 2, 23 );
			AddComponent( new AddonComponent( 2860 ), -3, 2, 0 );
			AddComponent( new AddonComponent( 10368 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, 1, 23 );
			AddComponent( new AddonComponent( 2860 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 9978 ), -4, -1, 21 );
			AddComponent( new AddonComponent( 145 ), -4, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 153 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 9977 ), 3, 1, 28 );
			AddComponent( new AddonComponent( 10368 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 9977 ), 3, 0, 28 );
			AddComponent( new AddonComponent( 145 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 10368 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 145 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 9977 ), 3, 3, 28 );
			AddComponent( new AddonComponent( 10368 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, 0, 32 );
			AddComponent( new AddonComponent( 10368 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, -1, 32 );
			AddComponent( new AddonComponent( 7753 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, -2, 32 );
			AddComponent( new AddonComponent( 7758 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 7135 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 10368 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, -3, 30 );
			AddComponent( new AddonComponent( 7759 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 146 ), 1, -4, 0 );
			AddComponent( new AddonComponent( 9977 ), 3, 5, 28 );
			AddComponent( new AddonComponent( 10368 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 9977 ), 3, 4, 28 );
			AddComponent( new AddonComponent( 144 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 152 ), 2, 4, 0 );
			AddComponent( new AddonComponent( 9977 ), 2, 4, 30 );
			AddComponent( new AddonComponent( 10368 ), 2, 4, 0 );
			AddComponent( new AddonComponent( 10368 ), 1, 4, 0 );
			AddComponent( new AddonComponent( 146 ), 1, 4, 0 );
			AddComponent( new AddonComponent( 9977 ), 1, 4, 32 );
			AddComponent( new AddonComponent( 9978 ), -1, 5, 27 );
			AddComponent( new AddonComponent( 1849 ), -1, 5, 0 );
			AddComponent( new AddonComponent( 10368 ), -1, 4, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, 4, 27 );
			AddComponent( new AddonComponent( 10368 ), -2, 4, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, 4, 25 );
			AddComponent( new AddonComponent( 146 ), -2, 4, 0 );
			AddComponent( new AddonComponent( 1856 ), -2, 5, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, 5, 25 );
			AddComponent( new AddonComponent( 145 ), -4, 4, 0 );
			AddComponent( new AddonComponent( 9978 ), -4, 4, 21 );
			AddComponent( new AddonComponent( 9978 ), -4, 5, 21 );
			AddComponent( new AddonComponent( 10 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 10368 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, -1, 23 );
			AddComponent( new AddonComponent( 10368 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, -2, 23 );
			AddComponent( new AddonComponent( 9978 ), -4, 2, 21 );
			AddComponent( new AddonComponent( 145 ), -4, 2, 0 );
			AddComponent( new AddonComponent( 9977 ), -3, -4, 0 );
			AddComponent( new AddonComponent( 146 ), -3, -4, 0 );
			AddComponent( new AddonComponent( 147 ), -4, -4, 0 );
			AddComponent( new AddonComponent( 9978 ), -4, -3, 21 );
			AddComponent( new AddonComponent( 145 ), -4, -3, 0 );
			AddComponent( new AddonComponent( 153 ), -4, -2, 0 );
			AddComponent( new AddonComponent( 9978 ), -4, -2, 21 );
			AddComponent( new AddonComponent( 10368 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 9978 ), -2, 1, 25 );
			AddComponent( new AddonComponent( 5736 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 10368 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 9977 ), 2, 2, 30 );
			AddComponent( new AddonComponent( 9977 ), 2, 3, 30 );
			AddComponent( new AddonComponent( 10368 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 10368 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 6420 ), 2, 0, 9 );
			AddComponent( new AddonComponent( 9977 ), 2, 0, 30 );
			AddComponent( new AddonComponent( 4090 ), 2, 1, 13 );
			AddComponent( new AddonComponent( 10368 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 9977 ), 2, 1, 30 );
			AddComponent( new AddonComponent( 2941 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 4105 ), 2, 1, 9 );
			AddComponent( new AddonComponent( 10368 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 9977 ), 2, -2, 30 );
			AddComponent( new AddonComponent( 10368 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 9977 ), 2, -1, 30 );
			AddComponent( new AddonComponent( 146 ), 2, -4, 0 );
			AddComponent( new AddonComponent( 9977 ), 2, -4, 30 );
			AddComponent( new AddonComponent( 9977 ), 3, -2, 28 );
			AddComponent( new AddonComponent( 10368 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 153 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 145 ), -4, 0, 0 );
			AddComponent( new AddonComponent( 9978 ), -4, 0, 21 );
			AddComponent( new AddonComponent( 152 ), -1, -4, 0 );
			AddComponent( new AddonComponent( 10368 ), -3, -3, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, -3, 23 );
			AddComponent( new AddonComponent( 2665 ), -3, -3, 0 );
			AddComponent( new AddonComponent( 10368 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 9978 ), -1, -2, 27 );
			AddComponent( new AddonComponent( 7756 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 10368 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 9976 ), 0, 0, 29 );
			AddComponent( new AddonComponent( 9976 ), 0, 1, 29 );
			AddComponent( new AddonComponent( 10368 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 9976 ), 0, 2, 29 );
			AddComponent( new AddonComponent( 10368 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 10368 ), -3, 0, 0 );
			AddComponent( new AddonComponent( 9978 ), -3, 0, 23 );
			AddComponent( new AddonComponent( 2860 ), -3, 0, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 4090 );
			AddComponent( ac, 2, 1, 13 );
			ac = new AddonComponent( 10 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 10 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 10 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, -2, 28 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, 3, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, -3, 30 );
			ac = new AddonComponent( 7135 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, -3, -4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 147 );
			AddComponent( ac, -4, -4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, 1, -4, 0 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, 2, -4, 0 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 152 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, -4, 0 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 153 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 153 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 153 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 153 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 151 );
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 6420 );
			AddComponent( ac, 2, 0, 9 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, 3, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, 2, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, 1, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, 0, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, -1, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, -2, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, -3, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, 3, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, 2, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, 1, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, 0, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, -1, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, -2, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, -3, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 3, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 2, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 1, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 0, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, -1, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, -2, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, -3, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, -2, 27 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, -3, 27 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, -3, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, 3, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, 2, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, 1, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, 0, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, -1, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, -2, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, 3, 28 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, 2, 28 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, 0, 28 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, -1, 28 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, 2, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, 1, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, 0, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, -1, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, -2, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, -4, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, 1, 32 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, 0, 32 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, -1, 32 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, -2, 32 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, -3, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, 2, 32 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, 3, 32 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, 3, 29 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, 1, 29 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, -4, -3, 0 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, 2, 29 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, -1, 29 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, -3, -4, 0 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, -3, 29 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, 3, 27 );
			ac = new AddonComponent( 2860 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, 1, 28 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, 0, 29 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, -2, 29 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, 2, 27 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, 1, 27 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, 0, 27 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, -1, 27 );
			ac = new AddonComponent( 14120 );
			AddComponent( ac, 3, -3, 37 );
			ac = new AddonComponent( 7135 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 4105 );
			AddComponent( ac, 2, 1, 9 );
			ac = new AddonComponent( 5453 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 3130 );
			AddComponent( ac, -3, 3, 1 );
			ac = new AddonComponent( 148 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 2860 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 2860 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2860 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2860 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 2860 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 5737 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 5736 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 5735 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 2620 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 2667 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 2665 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1856 );
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 1854 );
			AddComponent( ac, 1, 5, 0 );
			ac = new AddonComponent( 1849 );
			AddComponent( ac, 0, 5, 0 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 145 );
			AddComponent( ac, -4, 4, 0 );
			ac = new AddonComponent( 152 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, 5, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -4, 4, 21 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, 5, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -3, 4, 23 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 5, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 4, 25 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, 5, 27 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, 5, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 4, 4, 26 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, 5, 28 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 3, 4, 28 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, 5, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 2, 4, 30 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, 5, 32 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 1, 4, 32 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, 5, 29 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, 0, 4, 29 );
			ac = new AddonComponent( 146 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -1, 4, 27 );
			ac = new AddonComponent( 1849 );
			AddComponent( ac, -1, 5, 0 );
			ac = new AddonComponent( 149 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 144 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 10368 );
			AddComponent( ac, 2, 4, 0 );

		}

		public LJCottageAddon( Serial serial ) : base( serial )
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

	public class LJCottageAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LJCottageAddon();
			}
		}

		[Constructable]
		public LJCottageAddonDeed()
		{
			Name = "LJCottage";
		}

		public LJCottageAddonDeed( Serial serial ) : base( serial )
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