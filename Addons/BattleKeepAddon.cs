/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BattleKeepAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BattleKeepAddonDeed();
			}
		}

		[ Constructable ]
		public BattleKeepAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 5482 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, 3, 50 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 0, 10 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1864;
			AddComponent( ac, -2, -2, 10 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 1169 );
			ac.Hue = 2958;
			AddComponent( ac, -2, -4, 50 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -1, -5, 10 );
			ac = new AddonComponent( 3731 );
			AddComponent( ac, 0, 3, 50 );
			ac = new AddonComponent( 5480 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, 3, 50 );
			ac = new AddonComponent( 16115 );
			AddComponent( ac, -5, -1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -2, -3, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, -3, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, -3, 50 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -1, -3, 10 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 1, 30 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 3, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 1, 5 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -1, -4, 5 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -2, 0, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, 1, 50 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, 0, -4, 5 );
			ac = new AddonComponent( 1958 );
			ac.Hue = 1810;
			AddComponent( ac, -4, -1, 30 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, -3, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -2, -2, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, -1, 50 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, -4, 15 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -3, 15 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, 3, 50 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 0, 25 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 0, 20 );
			ac = new AddonComponent( 16129 );
			AddComponent( ac, 1, -5, 19 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 0, 10 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, -2, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 3, 20 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, -4, 50 );
			ac = new AddonComponent( 9546 );
			AddComponent( ac, -5, 1, 0 );
			ac = new AddonComponent( 1956 );
			ac.Hue = 1810;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, -1, 25 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, 2, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, -3, 5 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 20 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 0, 5 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 1, 15 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 3, 5 );
			ac = new AddonComponent( 16116 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -4, 2, 32 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 25 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -2, -4, 19 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 0, 15 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, -1, 15 );
			ac = new AddonComponent( 1959 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 3, 45 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, -4, 50 );
			ac = new AddonComponent( 1957 );
			ac.Hue = 1810;
			AddComponent( ac, -1, -3, 15 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 3, 35 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -4, 2, 19 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, -4, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 2, 15 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 2, 5 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 2, 35 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 0, 15 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, -4, 5 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, 1, -4, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 2, 10 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 35 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -4, -2, 19 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -3, 3, 19 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, 0, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 9543 );
			AddComponent( ac, -5, 0, 19 );
			ac = new AddonComponent( 19533 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -3, -3, 19 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, -1, 20 );
			ac = new AddonComponent( 1957 );
			ac.Hue = 1810;
			AddComponent( ac, 0, -4, 10 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, -2, 5 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -1, -4, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -3, 10 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, -2, 15 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 16116 );
			AddComponent( ac, -1, -5, 19 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, -2, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 5 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 16128 );
			AddComponent( ac, 0, -5, 19 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 30 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -2, 10 );
			ac = new AddonComponent( 9543 );
			AddComponent( ac, -5, 0, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 3, 30 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -3, -3, 33 );
			ac = new AddonComponent( 1959 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 2, 40 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 3, 40 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, 0, -5, 10 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, 2, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, 1, 50 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -2, -4, 33 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -1, -4, 10 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 3, 25 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, 0, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, -1, 10 );
			ac = new AddonComponent( 19533 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 9546 );
			AddComponent( ac, -5, 1, 32 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -4, 1, 28 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 1, 25 );
			ac = new AddonComponent( 16115 );
			AddComponent( ac, -5, -1, 19 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -1, -5, 5 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 3, 10 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, -4, 50 );
			ac = new AddonComponent( 16129 );
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -1, 5 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -2, 1, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -2, 20 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 0, 25 );
			ac = new AddonComponent( 9541 );
			AddComponent( ac, -4, -2, 33 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 1958 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 0, 30 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 1, 10 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -1, -3, 5 );
			ac = new AddonComponent( 1958 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -2, 25 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -5, -1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 1, 20 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -1, 25 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 10 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 0, 5 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 1, 20 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -2, -1, 50 );
			ac = new AddonComponent( 16129 );
			AddComponent( ac, 1, -5, 30 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 1, 25 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, 3, 15 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 2, 40 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -5, 0, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, 1, -4, 5 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 2, 20 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 2, 15 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, -1, 50 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 1957 );
			ac.Hue = 1810;
			AddComponent( ac, -1, -4, 15 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -4, 0, 30 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -1, 20 );
			ac = new AddonComponent( 1958 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -3, 20 );
			ac = new AddonComponent( 9546 );
			AddComponent( ac, -5, 1, 19 );
			ac = new AddonComponent( 16116 );
			AddComponent( ac, -1, -5, 32 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 16128 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, -2, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, 1, 15 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -1, 10 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, 0, 50 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 2, 30 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, -3, 15 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -2, 15 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, -4, 0 );
			ac = new AddonComponent( 1962 );
			ac.Hue = 1810;
			AddComponent( ac, -2, -3, 20 );
			ac = new AddonComponent( 1957 );
			ac.Hue = 1810;
			AddComponent( ac, -2, -2, 20 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -3, 5 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, 2, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 1, 10 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, -1, 5 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, -3, 10 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -3, -1, 15 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, -1, 50 );
			ac = new AddonComponent( 16115 );
			AddComponent( ac, -5, -1, 33 );
			ac = new AddonComponent( 1956 );
			ac.Hue = 1810;
			AddComponent( ac, 1, -3, 5 );
			ac = new AddonComponent( 1958 );
			ac.Hue = 1810;
			AddComponent( ac, -3, 1, 35 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -3, 3, 32 );
			ac = new AddonComponent( 9543 );
			AddComponent( ac, -5, 0, 33 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, 1, 50 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 0, 20 );
			ac = new AddonComponent( 16128 );
			AddComponent( ac, 0, -5, 32 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -3, -2, 5 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1955 );
			ac.Hue = 1810;
			AddComponent( ac, -2, 2, 25 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -2, -4, 10 );
			ac = new AddonComponent( 1955 );
			AddComponent( ac, -4, 1, 5 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 5508 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 7165 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 5483 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 489 );
			AddComponent( ac, -2, 1, 50 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -2, -1, 57 );
			ac = new AddonComponent( 490 );
			AddComponent( ac, -2, 0, 57 );
			ac = new AddonComponent( 3731 );
			AddComponent( ac, 0, 3, 50 );
			ac = new AddonComponent( 115 );
			ac.Hue = 2318;
			AddComponent( ac, -2, -3, 50 );
			ac = new AddonComponent( 115 );
			ac.Hue = 2318;
			AddComponent( ac, -2, 1, 50 );
			ac = new AddonComponent( 3700 );
			AddComponent( ac, 0, 2, 50 );
			ac = new AddonComponent( 3700 );
			AddComponent( ac, 0, 2, 50 );
			ac = new AddonComponent( 9550 );
			AddComponent( ac, 0, 5, 18 );
			ac = new AddonComponent( 5537 );
			ac.Hue = 2318;
			AddComponent( ac, 1, 6, 24 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 1, 4, 50 );
			ac = new AddonComponent( 39 );
			ac.Hue = 2318;
			AddComponent( ac, 1, 4, 50 );
			ac = new AddonComponent( 9550 );
			AddComponent( ac, 0, 5, 33 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -2, 4, 32 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -2, 4, 19 );
			ac = new AddonComponent( 9548 );
			AddComponent( ac, -1, 5, 35 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 0, 4, 50 );
			ac = new AddonComponent( 9548 );
			AddComponent( ac, -1, 5, 0 );
			ac = new AddonComponent( 9544 );
			AddComponent( ac, 1, 5, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 1;
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, -1, 4, 50 );
			ac = new AddonComponent( 9555 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 1;
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 9550 );
			AddComponent( ac, 0, 5, 0 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, 1, 4, 16 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, 1, 4, 32 );
			ac = new AddonComponent( 1172 );
			ac.Hue = 2318;
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 9544 );
			AddComponent( ac, 1, 5, 18 );
			ac = new AddonComponent( 9548 );
			AddComponent( ac, -1, 5, 18 );
			ac = new AddonComponent( 9544 );
			AddComponent( ac, 1, 5, 33 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 3730 );
			AddComponent( ac, 0, 4, 50 );
			ac = new AddonComponent( 3730 );
			AddComponent( ac, 0, 4, 50 );
			ac = new AddonComponent( 3729 );
			AddComponent( ac, 0, 5, 50 );
			ac = new AddonComponent( 3729 );
			AddComponent( ac, 0, 5, 50 );
			ac = new AddonComponent( 5536 );
			ac.Hue = 2318;
			AddComponent( ac, 0, 6, 24 );
			ac = new AddonComponent( 115 );
			ac.Hue = 2318;
			AddComponent( ac, -1, 4, 50 );
			ac = new AddonComponent( 3732 );
			AddComponent( ac, 3, 0, 50 );
			ac = new AddonComponent( 7960 );
			ac.Hue = 1817;
			AddComponent( ac, 4, 2, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 3, 2, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 1;
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 9539 );
			AddComponent( ac, 5, 1, 32 );
			ac = new AddonComponent( 9539 );
			AddComponent( ac, 5, 1, 0 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, 4, 1, 32 );
			ac = new AddonComponent( 16131 );
			AddComponent( ac, 5, -1, 32 );
			ac = new AddonComponent( 16131 );
			AddComponent( ac, 5, -1, 20 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 4, -2, 19 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 1;
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 9543 );
			AddComponent( ac, 5, 0, 31 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 2, -3, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 2, -2, 50 );
			ac = new AddonComponent( 16131 );
			AddComponent( ac, 5, -1, 0 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 9543 );
			AddComponent( ac, 5, 0, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, 4, 1, 15 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 4, -1, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 4, 1, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 4, 0, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 3, 1, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 3, 0, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 2, 2, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 2, 1, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 2, 0, 50 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 3, -3, 19 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, -1, 50 );
			ac = new AddonComponent( 9539 );
			AddComponent( ac, 5, 1, 16 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 2, -4, 19 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 2, -1, 50 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 4, -2, 33 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2318;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 2, 3, 50 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 1;
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 3, -1, 50 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 2, -4, 30 );
			ac = new AddonComponent( 9543 );
			AddComponent( ac, 5, 0, 19 );
			ac = new AddonComponent( 1172 );
			ac.Hue = 2318;
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 7960 );
			ac.Hue = 1817;
			AddComponent( ac, 4, 3, 55 );
			ac = new AddonComponent( 1172 );
			ac.Hue = 2318;
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 2, -4, 0 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 1180 );
			ac.Hue = 2958;
			AddComponent( ac, 3, -2, 50 );
			ac = new AddonComponent( 1172 );
			ac.Hue = 2318;
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 5648 );
			ac.Hue = 2318;
			AddComponent( ac, 6, 0, 24 );
			ac = new AddonComponent( 3733 );
			AddComponent( ac, 4, 0, 50 );
			ac = new AddonComponent( 115 );
			ac.Hue = 2318;
			AddComponent( ac, 2, -3, 50 );
			ac = new AddonComponent( 3700 );
			AddComponent( ac, 3, 0, 50 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 4, 0, 50 );
			ac = new AddonComponent( 16133 );
			AddComponent( ac, 3, -3, 34 );
			ac = new AddonComponent( 3733 );
			AddComponent( ac, 4, 0, 50 );
			ac = new AddonComponent( 39 );
			ac.Hue = 2318;
			AddComponent( ac, 2, 3, 50 );
			ac = new AddonComponent( 39 );
			ac.Hue = 2318;
			AddComponent( ac, 4, 1, 50 );
			ac = new AddonComponent( 39 );
			ac.Hue = 2318;
			AddComponent( ac, 3, 2, 50 );
			ac = new AddonComponent( 115 );
			ac.Hue = 2318;
			AddComponent( ac, 4, -1, 50 );
			ac = new AddonComponent( 5647 );
			ac.Hue = 2318;
			AddComponent( ac, 6, 1, 24 );
			ac = new AddonComponent( 3732 );
			AddComponent( ac, 3, 0, 50 );
			ac = new AddonComponent( 3700 );
			AddComponent( ac, 3, 0, 50 );
			ac = new AddonComponent( 3734 );
			AddComponent( ac, 5, 0, 50 );
			ac = new AddonComponent( 3734 );
			AddComponent( ac, 5, 0, 50 );
			ac = new AddonComponent( 7960 );
			ac.Hue = 1817;
			AddComponent( ac, 3, 4, 55 );
			ac = new AddonComponent( 7960 );
			ac.Hue = 1817;
			AddComponent( ac, 2, 4, 50 );
			ac = new AddonComponent( 7960 );
			ac.Hue = 1817;
			AddComponent( ac, 4, 4, 61 );

		}

		public BattleKeepAddon( Serial serial ) : base( serial )
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

	public class BattleKeepAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BattleKeepAddon();
			}
		}

		[Constructable]
		public BattleKeepAddonDeed()
		{
			Name = "BattleKeep";
		}

		public BattleKeepAddonDeed( Serial serial ) : base( serial )
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