using System;
using Server;

namespace Server.Items
{
	public class ExodusParry : MetalKiteShield  
	{
		public override int ArtifactRarity{ get{ return 9; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ExodusParry()
		{
			Weight = 0; 
            		Name = "Exodus' Parry"; 
            		Hue = 1161;

			Attributes.AttackChance = 15;
			Attributes.DefendChance = 15;
			Attributes.Luck = 50;
			Attributes.SpellChanneling = 1;
			Attributes.SpellDamage = 5;
			Attributes.WeaponDamage = 5;
			ArmorAttributes.SelfRepair = 3;

			ColdBonus = 5;
			EnergyBonus = 4;
			FireBonus = 5;
			PhysicalBonus = 5;
			PoisonBonus = 5;

		}

		public ExodusParry( Serial serial ) : base( serial )
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