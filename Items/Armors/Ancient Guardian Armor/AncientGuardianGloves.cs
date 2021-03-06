// Created by Script Creator
// From Aries at Revenge of the Gods
using System;
using Server;
namespace Server.Items
{
 public class AncientGuardianGloves : LeatherGloves
 {
 public override int InitMinHits{ get{ return 100;}}
 public override int InitMaxHits{ get{ return 100;}}
 [Constructable]
 public AncientGuardianGloves()
     {
         Name = "Ancient Guardian Arms";
	 Hue = 0x8e4;
         ColdBonus = 5;
         EnergyBonus = 5;
         PhysicalBonus = 5;
         PoisonBonus = 5;
         FireBonus = 5;
         ArmorAttributes.SelfRepair = 5;
         Attributes.BonusHits = 25;
         Attributes.BonusInt = 15;
         Attributes.BonusMana = 15;
			ArmorAttributes.MageArmor = 1;
         Attributes.BonusStr = 10;
         Attributes.CastRecovery = 1;
         Attributes.CastSpeed = 1;
         Attributes.EnhancePotions = 10;
         Attributes.LowerManaCost = 8;
         Attributes.LowerRegCost = 10;
         Attributes.Luck = 40;
         Attributes.ReflectPhysical = 5;
         Attributes.RegenHits = 5;
         Attributes.RegenMana = 25;
         Attributes.SpellDamage = 19;
         IntRequirement = 50;
     }
public AncientGuardianGloves( Serial serial ) : base( serial )
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
