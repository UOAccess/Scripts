using System;
using Server;

namespace Server.Items
{
	public class ExodusGuise : BoneHelm
	{
		public override int ArtifactRarity{ get{ return 9; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ExodusGuise()
		{
			Weight = 0; 
            		Name = "Exodus' Guise"; 
            		Hue = 1161;
			Attributes.BonusInt = 5;
			Attributes.DefendChance = 5;
			Attributes.Luck = 50;
			Attributes.WeaponDamage = 5;
			ArmorAttributes.MageArmor = 1;
			ArmorAttributes.SelfRepair = 3;
			ColdBonus = 8;
			EnergyBonus = 4;
			FireBonus = 3;
			PhysicalBonus = 5;
			PoisonBonus = 7;
			StrRequirement = 0;

		}

		public ExodusGuise( Serial serial ) : base( serial )
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