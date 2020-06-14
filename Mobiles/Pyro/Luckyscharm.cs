// Created Home Wrecker aka Amon//
/////////////////////////////////
using System;
using Server;
namespace Server.Items
{
 public class Luckyscharm : GoldNecklace
 {
 [Constructable]
 public Luckyscharm()
     {
         Hue = 1159;
         Name = "Lucky's Charm";
         Attributes.BonusHits = 5;
         Attributes.BonusMana = 5;
         Attributes.BonusStam = 5;
         Attributes.CastRecovery = 6;
         Attributes.CastSpeed = 2;
         Attributes.LowerManaCost = 25;
         Attributes.LowerRegCost = 25;
         Attributes.Luck = 500;
         Attributes.NightSight = 1;
         Attributes.RegenMana = 5;
         
     }
public Luckyscharm( Serial serial ) : base( serial )
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
