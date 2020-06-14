//Order Shield Of Evolution By: Sean (http://www.wftpradio.net/)

using System;
using Server;

namespace Server.Items
{
	public class OrderShieldOfEvolution: OrderShield 
	{

        private int mEvolutionPoints = 0;

        private int mBoundToSoul = 0;// Start binding value as zero.

        [CommandProperty(AccessLevel.GameMaster)]
        public int EvolutionPoints { get { return mEvolutionPoints; } set { mEvolutionPoints = value; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public int BoundToSoul { get { return mBoundToSoul; } set { mBoundToSoul = value; } }

        public override int ArtifactRarity{ get{ return 666; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public OrderShieldOfEvolution()
		{	Name = "<BASEFONT COLOR=#B82121>Dragon Shield Of Evolution";
			Hue = 1175;
            //Resource = CraftResource.None;
            ArmorAttributes.SelfRepair = 10;
            BoundToSoul = 0;
        }

        public OrderShieldOfEvolution(Serial serial)
            : base(serial)
        {
        }

        public override int OnHit( BaseWeapon weapon, int damageTaken )
        {
            if (Utility.Random(7) == 1)
            {
                //Console.WriteLine("should be applying gain");
                ApplyGain();
            }

            return base.OnHit(weapon, damageTaken);
        }

        public void ApplyGain()
        {
            int expr;
            if (mEvolutionPoints < 750) // edit this to change how high you wish the Attributes to go 10000 means max attributes will be 100
            {
                mEvolutionPoints++;
                //this.Name = "Order Shield Of Evolution (" + mEvolutionPoints.ToString() + ")";

                if ((mEvolutionPoints / 1) > 0)
                {
                    expr = mEvolutionPoints / 1;

                    this.Attributes.AttackChance = expr;
                    this.Attributes.WeaponSpeed  = expr;
                    this.Attributes.BonusHits = expr;
                }

                if ((mEvolutionPoints / 2) > 0)
                {
                    expr = mEvolutionPoints / 1;

                    this.Attributes.WeaponDamage = expr;
                }

                if ((25 + (mEvolutionPoints / 2)) > 0) this.Attributes.WeaponSpeed = (25 + (mEvolutionPoints / 2));

                if ((mEvolutionPoints / 20) > 0)
                {
                    expr = mEvolutionPoints / 20;

                    this.Attributes.CastRecovery = expr;
                    this.Attributes.CastSpeed = expr;
                    this.Attributes.BonusStr = expr;
                    this.Attributes.BonusDex = expr;
                    this.Attributes.BonusInt = expr;
                }
                InvalidateProperties();


            }
        }

        public override bool OnDragLift(Mobile from)
        {
            if (from.AccessLevel >= AccessLevel.Seer)
            {
                return true;
            }
            else if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                BoundToSoul = from.Serial; //Bind to a serial on first time equiped.
                this.Name = "<BASEFONT COLOR=#B82121>" + from.Name.ToString() + "'s Dragon Shield Of Evolution";//Change item name and add who it is bound to. "Player's Soul Sword"
                from.Emote("*" + from.Name + " feels a weird energy overwhelming their body*");
                return true;//Allow it to bind to the first player to equip it after creation.
                            //Will show in [props as ParentEntity and RootParentEntitty as [m] Serial, "Player Name"
            }
            return base.OnDragLift(from);
        }

        public override bool OnEquip(Mobile from)
        {
            if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                BoundToSoul = from.Serial; //Bind to a serial on first time equiped.
                this.Name = "<BASEFONT COLOR=#B82121>" + from.Name.ToString() + "'s Dragon Shield Of Evolution";//Change item name and add who it is bound to. "Player's Soul Sword"
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
