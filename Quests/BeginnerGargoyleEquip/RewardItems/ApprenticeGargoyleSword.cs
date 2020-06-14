using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeGargoyleSword : Katana
	{ 
				
		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }
        public override Race RequiredRace{ get { return Race.Gargoyle; } }
		public override bool CanBeWornByGargoyles{ get{ return true; } }

		[Constructable]
		public ApprenticeGargoyleSword()
		{
			
			Name = "Hero Apprentice Gargoyle Sword";
            ItemID =2312;
            Layer = Layer.OneHanded;
			Weight = 10;

			WeaponAttributes.UseBestSkill = 1;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponDamage = 35;
			Attributes.WeaponSpeed = 15;
			Attributes.Luck = 25;
			
			LootType = LootType.Blessed;
			
		} 
		
		public ApprenticeGargoyleSword( Serial serial ) : base( serial )
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
