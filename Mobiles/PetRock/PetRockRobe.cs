
/////////////////////////////
//Created by some fuckstick//
/////////////////////////////
using System;
using Server.Items;
using Server.Mobiles;
using Server.Engines.XmlSpawner2;

namespace Server.Items
{
	
	public class PetRockRobe : Robe
	{

		[Constructable]
		public PetRockRobe()
		{
            ItemID = 9860;
			Weight = 0.000001;
            Name = "Pet Rock Robe";
            Hue = 88;
			XmlAttach.AttachTo(this, new XmlSocketable(4));
            XmlAttach.AttachTo(this, new XmlSockets(4));
			Attributes.BonusHits = 100;
			Attributes.Luck = 500;
			Attributes.ReflectPhysical = 35;
			Attributes.AttackChance = 75;
			Attributes.BonusDex = 175;
			Attributes.BonusInt = 175;
			Attributes.BonusMana = 175;
			Attributes.BonusStam = 175;
			Attributes.CastRecovery = 18;
			Attributes.CastSpeed = 16;
			Attributes.DefendChance = 75;
			Attributes.EnhancePotions = 275;
			Attributes.LowerManaCost = 100;
			Attributes.LowerRegCost = 100;
			Attributes.NightSight = 1;
			Attributes.RegenHits = 275;
			Attributes.RegenMana = 275;
			Attributes.RegenStam = 275;
			Attributes.SpellDamage = 275;
			Attributes.WeaponDamage = 275;
            

		}

        public PetRockRobe(Serial serial): base(serial)
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
		public override void OnDoubleClick( Mobile from )
		{
            Item y = from.Backpack.FindItemByType(typeof(PetRockRobe));
			if ( y !=null )
			{

                if (this.ItemID == 9860) this.ItemID = 7939;
                else if (this.ItemID == 7939) this.ItemID = 9860;

			}
			else
			{ 
                               	from.SendMessage( "You must have the item in your pack to take down the hood it." ); 
                        }
		}
	}
}