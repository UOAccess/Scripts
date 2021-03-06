/////////////////////////////////////
//**Generated by Ryan**//
/////////////////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class NoxArms : LeatherArms
	{
	 	public override int ArtifactRarity{ get{ return 10; } }
	 	public override int InitMinHits{ get{ return 255; } }
	 	public override int InitMaxHits{ get{ return 255; } }

	 	[Constructable]
	 	public NoxArms()
	 	{
	 	 	Name = "Arms of the Swamp Queen";
	 	 	Hue = 1272;
	 	 	ArmorAttributes.MageArmor = 1;
	 	 	ArmorAttributes.SelfRepair = 8;
            PhysicalBonus = 10;
            FireBonus = 10;
            EnergyBonus = 10;
            ColdBonus = 10;
            PoisonBonus = 10;
            Attributes.BonusInt = 5;
		    Attributes.DefendChance = 15;
			Attributes.Luck = 100;
			Attributes.NightSight = 1;
            Attributes.ReflectPhysical = 10;
			Attributes.SpellDamage = 10;
	 	}

	 	public NoxArms(Serial serial) : base( serial )
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
