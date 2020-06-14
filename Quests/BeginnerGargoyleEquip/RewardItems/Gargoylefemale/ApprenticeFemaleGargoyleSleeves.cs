using Server;
using System;
using Server.Items;

namespace Server.Items
{

	public class ApprenticeFemaleGargoyleSleeves :  LeatherArms
	{
		public override int InitMinHits{ get{ return 100; } }
		public override int InitMaxHits{ get{ return 100; } }
		
		public override int BasePhysicalResistance{ get{ return 0; } }
		public override int BaseFireResistance{ get{ return 0; } }
		public override int BaseColdResistance{ get{ return 0; } }
		public override int BasePoisonResistance{ get{ return 0; } }
		public override int BaseEnergyResistance{ get{ return 0; } }

		public override int AosStrReq{ get{ return 15; } }
		public override int OldStrReq{ get{ return 15; } } 
                public override Race RequiredRace{ get { return Race.Gargoyle; } }
		public override bool CanBeWornByGargoyles{ get{ return true; } }
                public override bool AllowMaleWearer{ get{ return false; } }

		
		
		[Constructable]
		public ApprenticeFemaleGargoyleSleeves() 
		{
			Hue = 57;
			Name = "Heroine Apprentice Female Gargoyle Sleeves";
			Weight = 5;
                        ItemID = 769;
			
			Attributes.LowerRegCost = 17;
			Attributes.RegenMana = 2;
			Attributes.LowerManaCost = 10;
			Attributes.Luck = 5;
			
			
			PhysicalBonus = 5;
			FireBonus = 5;
			ColdBonus = 5;
			PoisonBonus = 5;
			EnergyBonus = 5;
			
			LootType = LootType.Blessed;
				
		} 
		public ApprenticeFemaleGargoyleSleeves( Serial serial ) : base( serial )
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
