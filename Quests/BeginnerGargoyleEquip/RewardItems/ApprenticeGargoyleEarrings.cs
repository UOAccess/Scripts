using System;
using Server;

namespace Server.Items
{
	public class ApprenticeGargoyleEarrings : SilverEarrings
	{
                public override Race RequiredRace{ get { return Race.Gargoyle; } }
		public override bool CanBeWornByGargoyles{ get{ return true; } }

		[Constructable]
		public ApprenticeGargoyleEarrings()
		{
			Name = "Hero Apprentice Gargoyle Earrings";
            ItemID =   0x4213;
						
			Attributes.BonusInt = 3;
			Attributes.RegenMana = 2;
			Attributes.SpellDamage = 5;
			LootType = LootType.Blessed;
		}

		public ApprenticeGargoyleEarrings( Serial serial ) : base( serial )
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