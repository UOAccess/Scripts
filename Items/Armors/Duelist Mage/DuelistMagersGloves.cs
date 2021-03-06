// Created by Script Creator
// From Aries at Revenge of the Gods
using System;
using Server;
namespace Server.Items
{
 public class DuelistMagersGloves : LeatherGloves
 {
 public override int InitMinHits{ get{ return 100;}}
 public override int InitMaxHits{ get{ return 100;}}
 [Constructable]
 public DuelistMagersGloves()
     {
	 Hue = 326;
	LootType = LootType.Blessed;
         Name = "Mage Gloves";
         ColdBonus = 2;
         EnergyBonus = 2;
         PhysicalBonus = 2;
         PoisonBonus = 2;
         FireBonus = 2;
         Attributes.BonusHits = 4;
         Attributes.BonusInt = 3;
         Attributes.BonusMana = 2;
         Attributes.BonusStr = 3;
         Attributes.CastRecovery = 1;
         Attributes.LowerManaCost = 5;
         Attributes.LowerRegCost = 5;
         Attributes.Luck = 40;
         Attributes.ReflectPhysical = 3;
         Attributes.RegenHits = 3;
         Attributes.RegenMana = 4;
         Attributes.SpellDamage = 3;
         IntRequirement = 90;
     }
public DuelistMagersGloves( Serial serial ) : base( serial )
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