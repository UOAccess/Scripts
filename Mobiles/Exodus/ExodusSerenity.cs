using System;
using Server;

namespace Server.Items
{
	public class ExodusSerenity : LeatherArms 
	{
		public override int ArtifactRarity{ get{ return 9; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ExodusSerenity()
		{
			Weight = 0; 
            		Name = "Exodus' Serenity"; 
            		Hue = 1175;
			Attributes.BonusDex = 4;
			Attributes.BonusHits = 5;
			Attributes.BonusInt = 3;
			Attributes.BonusStr = 5;
			Attributes.LowerManaCost = 5;
			Attributes.LowerRegCost = 23;
			Attributes.Luck = 50;
			Attributes.NightSight = 1;
			Attributes.WeaponDamage = 5;
			ArmorAttributes.SelfRepair = 3;
			ColdBonus = 7;
			EnergyBonus = 3;
			FireBonus = 3;
			PhysicalBonus = 4;
			PoisonBonus = 5;
			StrRequirement = 0;

		}

		public ExodusSerenity( Serial serial ) : base( serial )
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