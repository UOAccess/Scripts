using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeShield : MetalKiteShield
	{ 
				
		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

		public override int BasePhysicalResistance{ get{ return 0; } }
		public override int BaseFireResistance{ get{ return 0; } }
		public override int BaseColdResistance{ get{ return 0; } }
		public override int BasePoisonResistance{ get{ return 0; } }
		public override int BaseEnergyResistance{ get{ return 0; } }

		public override int AosStrReq{ get{ return 15; } }
		public override int OldStrReq{ get{ return 15; } } 
		
		[Constructable]
		public ApprenticeShield()
		{
			Hue = 57;
			Name = "Hero Apprentice Shield";
			Weight = 10;
			
			Attributes.SpellChanneling = 1;
			Attributes.DefendChance = 5;
			Attributes.AttackChance = 5;
			Attributes.Luck = 15;
			
			LootType = LootType.Blessed;
			
			PhysicalBonus = 5;
			FireBonus = 5;
			ColdBonus = 5;
			PoisonBonus = 5;			
			EnergyBonus = 5;
		} 
		
		public ApprenticeShield( Serial serial ) : base( serial )
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
