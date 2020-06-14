using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class GargishMaleStarterArmor : Bag
	{
		[Constructable]
		public GargishMaleStarterArmor() : this(1)
		{
		}

		[Constructable]
		public GargishMaleStarterArmor( int amount )
		{
            DropItem(new ApprenticeGargoyleWingArmor());
            DropItem(new ApprenticeMaleGargoyleChest());
            DropItem(new ApprenticeMaleGargoyleKilt());
            DropItem(new ApprenticeMaleGargoyleSleeves());
            DropItem(new ApprenticeMaleGargoyleLegs());

            DropItem(new ApprenticeFemaleGargoyleChest());
            DropItem(new ApprenticeFemaleGargoyleKilt());
            DropItem(new ApprenticeFemaleGargoyleSleeves());
            DropItem(new ApprenticeFemaleGargoyleLegs());
            
            DropItem(new ApprenticeGargoyleApron());
            DropItem(new ApprenticeGargoyleEarrings());
            DropItem(new ApprenticeGargoyleRing());
            DropItem(new ApprenticeGargoyleBracelet());
            DropItem(new ApprenticeGargoyleSword());
            DropItem(new ApprenticeGargoyleShield());
        }

		public GargishMaleStarterArmor( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
