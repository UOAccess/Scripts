/*
 created by:
     /\       
____/_ \____  ### ### ### ### #  ### ### # ##  ##  ###
\  ___\ \  /  #   #   # # # # #  # # # # # # # # # #
 \/ /  \/ /   ### ##  ### # # #  ### # # # # # ##  ##
 / /\__/_/\     # #   # # # # #  # # # # # # # # # #
/__\ \_____\  ### ### # # # ###  # # # ### ##  # # ###
    \  /             http://www.wftpradio.net/
     \/       
*/
using System;
using Server;
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Engines;

namespace Server.Items
{
    public class BroadswordOfEvolution : Broadsword
    {

	public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.CrushingBlow; } }
	public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }

        private int mEvolutionPoints = 0;

        private int mBoundToSoul = 0;// Start binding value as zero.

        [CommandProperty(AccessLevel.GameMaster)]
        public int EvolutionPoints { get { return mEvolutionPoints; } set { mEvolutionPoints = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public int BoundToSoul { get { return mBoundToSoul; } set { mBoundToSoul = value; } }

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        [Constructable]
        public BroadswordOfEvolution()
        {
            Name = "Broadsword Of Evolution";
            Hue = 0x4F2;
            WeaponAttributes.UseBestSkill = 1;

            Attributes.Luck = 100;
            WeaponAttributes.SelfRepair = 100;

            Attributes.WeaponDamage = 1;
            Attributes.WeaponSpeed = 10;
            Attributes.SpellChanneling = 1;
            BoundToSoul = 0;
        }

        public BroadswordOfEvolution(Serial serial)
            : base(serial)
        {
        }

        /*public override void OnHit(Mobile attacker, Mobile defender, double Damagebonus)
        {
            if (Utility.Random(2) == 1)
            {
                ApplyGain();
            }

            base.OnHit(attacker, defender,Damagebonus);
        }*/
        public override void OnHit(Mobile attacker, IDamageable damageable, double damageBonus)
        {
            if (Utility.Random(10) == 1)
            {
                ApplyGain();
            }
            base.OnHit(attacker, damageable, damageBonus);
        }

        public void ApplyGain()
        {
            int expr;
            if (mEvolutionPoints < 2500)
            {
                mEvolutionPoints++;
                //this.Name = "Broadsword Of Evolution (" + mEvolutionPoints.ToString() + ")";

                if ((mEvolutionPoints / 100) > 0)
                {
                    expr = mEvolutionPoints / 100;

                    this.WeaponAttributes.HitHarm = expr;
                    this.WeaponAttributes.HitMagicArrow = expr;
                }

                if ((mEvolutionPoints / 200) > 0)
                {
                    expr = mEvolutionPoints / 100;

                    this.WeaponAttributes.HitLightning = expr;
                    this.WeaponAttributes.HitFireball = expr;
                    this.Attributes.WeaponDamage = expr;
                }

                if ((25 + (mEvolutionPoints / 200)) > 0) this.Attributes.WeaponSpeed = (25 + (mEvolutionPoints / 200));

                if ((mEvolutionPoints / 2000) > 0)
                {
                    expr = mEvolutionPoints / 1000;

                    this.Attributes.CastRecovery = expr;
                    this.Attributes.CastSpeed = expr;
                }
                InvalidateProperties();

            }
        }
        public override bool OnEquip(Mobile from)
        {
            if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                BoundToSoul = from.Serial; //Bind to a serial on first time equiped.
                this.Name = "<BASEFONT COLOR=#2E9AFE>" + from.Name.ToString() + "'s Broadsword Of Evolution";//Change item name and add who it is bound to. "Player's Soul Sword"
                from.Emote("*" + from.Name + " feels a weird energy overwhelming their body*");
                base.OnEquip(from);
                return true;//Allow it to bind to the first player to equip it after creation.
                            //Will show in [props as ParentEntity and RootParentEntitty as [m] Serial, "Player Name"
            }
            else if (BoundToSoul == from.Serial) //Check to see if sword is bound to who is equiping it.
            {
                base.OnEquip(from);
                return true; //Allow player who had bound to sword to equip it.
            }
            else
            {
                from.SendMessage("Sorry but this armor does not belong to you.");
                return false; //Disallow any one else from equiping the sword.
            }
        }
        public override void AddNameProperty(ObjectPropertyList list)
        {
            base.AddNameProperty(list);
            if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                list.Add("<BASEFONT COLOR=#666699>"/*Green*/ + "[Un-Bound]" + "<BASEFONT COLOR=#FFFFFF>"/*Back to White*/ );
            }
            else if (BoundToSoul > 0)//Once the sword is bound it will show the Evolution Points.
            {// \n puts the stuff after it on a new line
                list.Add("<BASEFONT COLOR=#666699>"/*Green*/ + "[Soulbound]\n" + "<BASEFONT COLOR=#669966>" + "Evolution Points: " + mEvolutionPoints.ToString() + "<BASEFONT COLOR=#FFFFFF>"/*Back to White*/ );
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1);
            writer.Write(mBoundToSoul);//Serialize who it is bound to.
            writer.Write(mEvolutionPoints);

        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    {
                        mBoundToSoul = reader.ReadInt();
                        goto case 0;
                    }
                case 0:
                    {
                        mEvolutionPoints = reader.ReadInt();
                        break;
                    }
            }
        }
    }
}
