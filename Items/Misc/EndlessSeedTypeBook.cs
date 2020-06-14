using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;
using Server.Engines.Plants;
using Server.Mobiles;

namespace Server.Items
{
	public class EndlessSeedTypeTarget : Target
	{
		private EndlessSeedTypeBook m_Book;
		
		public EndlessSeedTypeTarget( EndlessSeedTypeBook Book ) : base( 1, false, TargetFlags.None )
		{
			m_Book = Book;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			if ( target is Seed )
			{
				Seed seed = (Seed)target;
				if ( (seed).ShowType == true )
				{
					from.SendMessage( "That seed is already discovered!");
				}
				else if( seed.RootParent != from )
				{
					from.SendMessage( "You must have the seed in your backpack!" );
				}
				else
				{
					(seed).ShowType = true;
					from.SendMessage( "You successfully discover the seed." );
				}
			}
			else from.SendMessage( "You can only discover seeds!" );
		}
	}
}

public class EndlessSeedTypeBook : Item
{
	[Constructable]
    public EndlessSeedTypeBook()
        : base(0xFBE)
	{
		Weight = 0;
		LootType = LootType.Blessed;
		Name = "A Un-Ending Seed Discoverey Book";
		//Hue = 1266;
	}
	
	public EndlessSeedTypeBook(Serial serial) : base(serial)
	{
	}
	public override void Serialize( GenericWriter writer )
	{
		base.Serialize( writer );
		writer.Write( (int) 0 );
	}
	public override void Deserialize( GenericReader reader )
	{
		base.Deserialize( reader );
		int version = reader.ReadInt();
	}
		
	public override void OnDoubleClick( Mobile from )
	{
		if ( !IsChildOf( from.Backpack ) ) from.SendLocalizedMessage( 1042001 );
		else
		{
			from.SendMessage("What seed would you like to discover?");
			from.Target = new EndlessSeedTypeTarget( this );
		}
	}
}