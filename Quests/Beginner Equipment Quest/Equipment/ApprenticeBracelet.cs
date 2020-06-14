using System;
using Server;

namespace Server.Items
{
	public class ApprenticeBracelet : SilverBracelet
	{

		[Constructable]
		public ApprenticeBracelet()
		{
			Name = "Hero Apprentice Bracelet";
						
			Attributes.BonusDex = 3;
			Attributes.RegenStam = 3;
			Attributes.CastSpeed = 1;
                     LootType = LootType.Blessed;
			
		}

		public ApprenticeBracelet( Serial serial ) : base( serial )
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