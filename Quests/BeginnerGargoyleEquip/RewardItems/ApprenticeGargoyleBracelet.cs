using System;
using Server;

namespace Server.Items
{
	public class ApprenticeGargoyleBracelet : SilverBracelet
	{
                public override Race RequiredRace{ get { return Race.Gargoyle; } }
		public override bool CanBeWornByGargoyles{ get{ return true; } }

		[Constructable]
		public ApprenticeGargoyleBracelet()
		{
			Name = "Hero Apprentice Gargoyle Bracelet";
                        ItemID = 16913;
						
			Attributes.BonusDex = 3;
			Attributes.RegenStam = 3;
			Attributes.CastSpeed = 1;
                          LootType = LootType.Blessed;
			
		}

		public ApprenticeGargoyleBracelet( Serial serial ) : base( serial )
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