using System;
using Server;

namespace Server.Items
{
	public class LeprechaunFourLeafClover : WarMace
	{
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public LeprechaunFourLeafClover()
		{
			Hue = 1436;
			Name = "leprechaun's four leaf clover";
			Attributes.WeaponSpeed = 30;
			Attributes.WeaponDamage = 50;
			Attributes.Luck = 200;
			WeaponAttributes.UseBestSkill = 1;
			LootType = LootType.Blessed;
			Identified = true;
		}

		public LeprechaunFourLeafClover( Serial serial ) : base( serial )
		{
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060662, "St. Patrick's Day\t2005" );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}