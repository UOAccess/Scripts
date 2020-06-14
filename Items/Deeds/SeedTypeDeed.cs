using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;
using Server.Engines.Plants;

namespace Server.Items
{
	public class SeedTypeTarget : Target
	{
		private SeedTypeBook m_Deed;
		
		public SeedTypeTarget( SeedTypeBook Deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = Deed;
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
					m_Deed.Delete();
				}
			}
			else from.SendMessage( "You can only discover seeds!" );
		}
	}
}

public class SeedTypeBook : Item
{
	[Constructable]
    public SeedTypeBook()
        : base(0xFBE)
	{
		Weight = 0;
		LootType = LootType.Blessed;
		Name = "A Seed Discoverey Book";
		//Hue = 1266;
	}
	
	public SeedTypeBook(Serial serial) : base(serial)
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
			from.SendMessage("What seed would you like to discover?"  );
			from.Target = new SeedTypeTarget( this );
		}
	}
}