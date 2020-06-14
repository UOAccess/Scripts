using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeSword : Katana
	{ 
				
		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

		[Constructable]
		public ApprenticeSword()
		{
			Hue = 57;
			Name = "Hero Apprentice Sword";
			Weight = 10;
			
			Attributes.SpellChanneling = 1;
			Attributes.WeaponDamage = 35;
			Attributes.WeaponSpeed = 15;
			Attributes.Luck = 25;
			
			LootType = LootType.Blessed;
			
		} 
		
		public ApprenticeSword( Serial serial ) : base( serial )
		{
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
