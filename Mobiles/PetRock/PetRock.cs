/* The Donation ONLY Picky Stygian Dragon - yes, way uber.  Hence, DONATION ONLY.
   Pet to pickup drops for players
   Based off The Picky Beetle - though I don't know who wrote that
   12/2015 DJ Qix
*/


using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Gumps;
using Server.Network;
using Server.ContextMenus;

namespace Server.Mobiles
{
    [CorpseName("a rock")]
    public class PetRock : BaseSABoss
    {
        private DateTime m_Delay;
        [Constructable]
        public PetRock()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.3, 0.5)
        {
            this.Name = "a pet rock";
            this.Body = 1431;
          //  this.BaseSoundID = 362;
          //  this.Hue = 2859;

            this.SetStr(7702, 45000);
            this.SetDex(7250, 45000);
            this.SetInt(7180, 45000);

            this.SetHits(100000, 450000);
            this.SetStam(7431, 25000);
            this.SetMana(7180, 25000);

            this.SetDamage(1330, 3355);

            this.SetDamageType(ResistanceType.Physical, 75);
            this.SetDamageType(ResistanceType.Fire, 50);
            this.SetDamageType(ResistanceType.Energy, 25);

            this.SetResistance(ResistanceType.Physical, 225);
            this.SetResistance(ResistanceType.Fire, 2225);
            this.SetResistance(ResistanceType.Cold, 225);
            this.SetResistance(ResistanceType.Poison, 225);
            this.SetResistance(ResistanceType.Energy, 225);

            this.SetSkill(SkillName.Anatomy, 9000.0);
            this.SetSkill(SkillName.MagicResist, 9000.0);
            this.SetSkill(SkillName.Tactics, 9000.0);
            this.SetSkill(SkillName.Wrestling, 9000.0);
            this.SetSkill(SkillName.Magery, 9000.0);

            this.Fame = 15000;
            this.Karma = -15000;

            this.VirtualArmor = 90;

            this.Tamable = true;
            ControlSlots = 6;
						MinTameSkill = 119.9;
						Container pack = Backpack;

								if ( pack != null )
									pack.Delete();

								pack = new StrongBackpack();
								pack.Movable = false;

								AddItem( pack );
		}

        				private DateTime m_NextPickup;

						public override void OnThink()
						{
							base.OnThink();

							if ( DateTime.Now < m_NextPickup )
								return;

						m_NextPickup = DateTime.Now + TimeSpan.FromSeconds( Utility.RandomMinMax( 0, 0 ) );

							Container pack = this.Backpack;

							if ( pack == null )
								return;

							ArrayList list = new ArrayList();

							foreach ( Item item in this.GetItemsInRange( 10 ) ) //Set your pickup range here
							{
								if ( item.Movable && item.Stackable )
								list.Add( item );
							}

							int pickedUp = 0;

							for ( int i = 0; i < list.Count; ++i )
							{
								Item item = (Item)list[i];

								if ( !pack.CheckHold( this, item, false, true ) )
									return;

								bool rejected;
									LRReason reject;

								NextActionTime = Core.TickCount;

								Lift( item, item.Amount, out rejected, out reject );

								if ( rejected )
									continue;

								Drop( this, Point3D.Zero );

								if ( ++pickedUp == 3 )
									break;
         			}
	                
      			}
          
						#region Pack Animal Methods
							public override bool OnBeforeDeath()
							{
								if ( !base.OnBeforeDeath() )
									return false;

									PackAnimal.CombineBackpacks( this );

									return true;
							}


							public override bool IsSnoop( Mobile from )
							{
								if ( PackAnimal.CheckAccess( this, from ) )
								return false;

								return base.IsSnoop( from );
							}

						public override bool OnDragDrop( Mobile from, Item item )
							{
								if ( CheckFeed( from, item ) )
									return true;

								if ( PackAnimal.CheckAccess( this, from ) )
							{
								AddToBackpack( item );
									return true;
							}

								return base.OnDragDrop( from, item );
							}

						public override bool CheckNonlocalDrop( Mobile from, Item item, Item target )
						{
							return PackAnimal.CheckAccess( this, from );
						}

						public override bool CheckNonlocalLift( Mobile from, Item item )
						{
							return PackAnimal.CheckAccess( this, from );
						}
                
        		public override void OnDoubleClick( Mobile from )
						{
							PackAnimal.TryPackOpen( this, from );
						}

						public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
						{
							base.GetContextMenuEntries( from, list );

							PackAnimal.GetContextMenuEntries( this, from, list );
						}
		#endregion
       	

        public PetRock(Serial serial)
            : base(serial)
        {
        }

        public override bool AlwaysMurderer
        {
            get
            {
                return false;
            }
        }
        public override Type[] UniqueSAList
        {
            get
            {
                return new Type[] { typeof(BurningAmber), typeof(DraconisWrath), typeof(DragonHideShield), typeof(FallenMysticsSpellbook), typeof(LifeSyphon), typeof(GargishSignOfOrder), typeof(HumanSignOfOrder), typeof(VampiricEssence) };
            }
        }
        public override Type[] SharedSAList
        {
            get
            {
                return new Type[] { typeof(AxesOfFury), typeof(PetrifiedSnake), typeof(SummonersKilt), typeof(GiantSteps), typeof(StoneDragonsTooth), typeof(TokenOfHolyFavor) };
            }
        }
        public override bool Unprovokable
        {
            get
            {
                return false;
            }
        }
        public override bool BardImmune
        {
            get
            {
                return true;
            }
        }
        public override bool GiveMLSpecial { get { return true; } }
        public override bool GivesMLMinorArtifact { get { return true; } }
        public override bool HasBreath
        {
            get
            {
                return true;
            }
        }// fire breath enabled
        public override bool AutoDispel
        {
            get
            {
                return !this.Controlled;
            }
        }
        public override int Meat
        {
            get
            {
                return 1;
            }
        }
        public override int Hides
        {
            get
            {
                return 3;
            }
        }
        public override HideType HideType
        {
            get
            {
                return HideType.Barbed;
            }
        }
        public override int Scales
        {
            get
            {
                return 7;
            }
        }
        public override ScaleType ScaleType
        {
            get
            {
                return (this.Body == 12 ? ScaleType.Yellow : ScaleType.Red);
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.AosSuperBoss, 1);
            this.AddLoot(LootPack.Gems, 1);
        }

        public override WeaponAbility GetWeaponAbility()
        {
            if (50.0 >= Utility.RandomDouble())
                return WeaponAbility.Bladeweave;
            else
                return WeaponAbility.TalonStrike;
        }

        public override void OnActionCombat()
        {
            /*
            if (DateTime.UtcNow > this.m_Delay)
            {
                switch (Utility.Random(2))
                {
                    case 0:
                        Ability.FlameCross(this);
                        this.m_Delay = DateTime.UtcNow + TimeSpan.FromSeconds(Utility.RandomMinMax(25, 35));
                        break;
                    case 1:
                        Ability.CrimsonMeteor(this, 35);
                        this.m_Delay = DateTime.UtcNow + TimeSpan.FromSeconds(Utility.RandomMinMax(20, 45));
                        break;
                }
            }
            */
            base.OnActionCombat();
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
