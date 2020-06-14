// By DxMonkey
// Ultima Eclipse 2010.
using System;
using Server;
using Server.Mobiles;
using Server.Network;
using Server.Multis;

namespace Server.Items
{
	public class RaceChangeDeed : Item
	{
		[Constructable]
		public RaceChangeDeed() : base( 0x14F0 )
		{
			Name = "Race Change Deed";
			Weight = 1.0;
			//LootType = LootType.Blessed;
			Hue = 2067;
		}

		public RaceChangeDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); //version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}

			else
			{

				if ( from.Race == Race.Elf && from.BodyValue == 605 )
				{
					from.Race = Race.Human;
                                        from.BodyValue = 400;
					from.SendMessage( 0x32, "You change from a male elf to a male human!" );
					this.Delete();
				}
				else if ( from.Race == Race.Elf && from.BodyValue == 606 )
				{
					from.Race = Race.Human;
                                        from.BodyValue = 401;
					from.SendMessage( 0x32, "You change from a female elf to a female human!" );
					this.Delete();
				}
				else if (from.Race == Race.Human && from.BodyValue == 400 )
				{
					from.Race = Race.Elf;
                                        from.BodyValue = 605;
					from.SendMessage( 0x32, "You change from a male human to a male elf!" );
					this.Delete();					
				}
				else if (from.Race == Race.Human && from.BodyValue == 401 )
				{
					from.Race = Race.Elf;
                                        from.BodyValue = 606;
					from.SendMessage( 0x32, "You change from a female human to a female elf!" );
					this.Delete();					
				}
				else
				{
					from.SendMessage( "You can't use this deed with your current race." );
				}
			}
		}
	}
}