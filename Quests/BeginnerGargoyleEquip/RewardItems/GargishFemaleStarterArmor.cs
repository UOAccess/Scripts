using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class GargishFemaleStarterArmor : Bag
	{
		[Constructable]
		public GargishFemaleStarterArmor() : this(1)
		{
		}

		[Constructable]
		public GargishFemaleStarterArmor( int amount )
		{
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

		public GargishFemaleStarterArmor( Serial serial ) : base( serial )
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
