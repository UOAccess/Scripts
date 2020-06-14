using System;
using Server;
using Server.Items;

namespace Server.Misc
{
	public class StPatricksDay2005 : GiftGiver
	{
		public static void Initialize()
		{
			GiftGiving.Register( new StPatricksDay2005() );
		}

		public override DateTime Start{ get{ return new DateTime( 2005, 3, 17 ); } }
		public override DateTime Finish{ get{ return new DateTime( 2005, 3, 31 ); } }

		public override void GiveGift( Mobile mob )
		{
			GiftBox box = new GiftBox();
			box.Hue = Utility.RandomList( 1436 );

			box.DropItem( new FineIrishAle() );
			box.DropItem( new IrishDrinkingMug() );
			box.DropItem( new LeprechaunFourLeafClover() );

			int random = Utility.Random( 100 );

			if ( random < 30 )
				box.DropItem( new LeprechaunShirt() );
			else if ( random < 40 )
				box.DropItem( new LeprechaunPants() );
			else if ( random < 50 )
				box.DropItem( new LeprechaunGloves() );
			else if ( random < 60 )
				box.DropItem( new LeprechaunBoots() );
			else
				box.DropItem( new LeprechaunHat() );

			switch ( GiveGift( mob, box ) )
			{
				case GiftResult.Backpack:
					mob.SendMessage( 0x482, "Happy St. Patrick's Day from the team!  Gift items have been placed in your backpack." );
					break;
				case GiftResult.BankBox:
					mob.SendMessage( 0x482, "Happy St. Patrick's Day from the team!  Gift items have been placed in your bank box." );
					break;
			}
		}
	}
}