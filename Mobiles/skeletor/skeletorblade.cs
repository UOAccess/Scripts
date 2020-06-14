using System;
using Server;

namespace Server.Items

{
              
              public class skeletorBlade : Scimitar
              {
              public override int ArtifactRarity{ get{ return 25; } } 
              public override int AosMinDamage{ get{ return 15; } }
              public override int AosMaxDamage{ get{ return 20; } }
	      public override float MlSpeed{ get{ return 2.75f; } }

	      public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DoubleStrike; } }
	      public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

	      public override int InitMinHits{ get{ return 255; } } // Set the minium amount of hit points for the weapon.
		public override int InitMaxHits{ get{ return 255; } }
              
                      [Constructable]
                      public skeletorBlade() 
                      {
                                        Weight = 4;
                                        Name = "Skeletors Blade";
                                        Hue = 1153;
              
                                        WeaponAttributes.DurabilityBonus = 60;
                                       // WeaponAttributes.HitDispel = 10;
                                        //WeaponAttributes.HitFireBall = 45;
                                        //WeaponAttributes.HitHarm = 58;
                                        WeaponAttributes.HitLeechHits = 45;
                                        WeaponAttributes.HitLeechMana = 46;
                                       // WeaponAttributes.HitLeechStam = 42;
                                        WeaponAttributes.HitLightning = 56;
                                        WeaponAttributes.HitLowerAttack = 47;
                                        //WeaponAttributes.HitLowerDefence = 15;
                                       // WeaponAttributes.HitMagicArrow = 51;
                                        WeaponAttributes.LowerStatReq = 100;
                                       // WeaponAttributes.MageWeapon = 1;
                                        //WeaponAttributes.ResistColdBonus = 10;
                                        //WeaponAttributes.ResistEnergyBonus = 10;
                                        //WeaponAttributes.ResistPhysicalBonus = 10;
                                        //WeaponAttributes.ResistPoisonBonus = 10;
                                        //WeaponAttributes.ResistFireBonus = 50;
                                        WeaponAttributes.SelfRepair = 100;
              
                                        //Attributes.AttackChance = 15;
                                        //Attributes.BonusDex = 5;
                                        Attributes.BonusHits = 10;
                                        //Attributes.BonusInt = 10;
                                        //Attributes.BonusMana = 10 ;
                                        //Attributes.BonusStam = 10;
                                       	//Attributes.CastRecovery = 2;
                                        //Attributes.CastSpeed = 1;
                                        //Attributes.DefendChance = 5;
                                        //Attributes.LowerManaCost = 5;
                                        //Attributes.LowerRegCost = 10;
                                        //Attributes.Luck = 100;
                                        //Attributes.NightSight = 1;
                                       	//Attributes.ReflectPhysical = 10;
                                        //Attributes.RegenHits = 25;
                                        //Attributes.RegenMana = 2;
                                        //Attributes.RegenStam = 10;
                                        Attributes.SpellChanneling = 1;
                                        //Attributes.SpellDamage = 10;
                                        //Attributes.WeaponDamage = 65;
                                        //Attributes.WeaponSpeed = 45;
              
                                                      Slayer = SlayerName.DaemonDismissal;
                                                      //LootType = LootType.Blessed;
                                    }
              
                      public skeletorBlade( Serial serial ) : base( serial )  
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
