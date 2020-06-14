using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
//Faster Cast Recovery Deed
	public class CastRecoveryTarget : Target
	{
		private CastRecoveryDeed m_Deed;

		public CastRecoveryTarget( CastRecoveryDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}

		protected override void OnTarget( Mobile from, object target )
		{
			if ( target is BaseWeapon || target is BaseShield || target is BaseJewel )
			{
				Item item = (Item)target;
				if (item is BaseWeapon)
				{
					if ( ((BaseWeapon)item).Attributes.CastRecovery == 3 ) from.SendMessage( "That already has 2 faster cast recovery!");
					else
					{
						if( item.RootParent != from ) from.SendMessage( "You can not put faster cast recovery on that there!" );
						else
						{
							((BaseWeapon)item).Attributes.CastRecovery = 1;
							from.SendMessage( "You magically add faster cast recovery to your item...." );
							m_Deed.Delete();
						}
					}
				}
				if (item is BaseShield)
				{
					if ( ((BaseShield)item).Attributes.CastRecovery == 3 ) from.SendMessage( "That already has faster cast recovery!");
					else
					{
						if( item.RootParent != from ) from.SendMessage( "You cannot put faster cast recovery on that there!" );
						else
						{
							((BaseShield)item).Attributes.CastRecovery = 1;
							from.SendMessage( "You magically add faster cast recovery to your item...." );
							m_Deed.Delete();
						}
					}
				}
				if (item is BaseJewel)
				{
					if ( ((BaseJewel)item).Attributes.CastRecovery == 3 ) from.SendMessage( "That already has faster cast recovery!");
					else
					{
						if( item.RootParent != from ) from.SendMessage( "You cannot put faster cast recovery on that there!" );
						else
						{
							((BaseJewel)item).Attributes.CastRecovery = 1;
							from.SendMessage( "You magically add faster cast recovery to your item...." );
							m_Deed.Delete();
						}
					}
				}
			}
			else from.SendMessage( "You can not put faster cast recovery on that" );
		}
	}

	public class CastRecoveryDeed : Item
	{
		[Constructable]
		public CastRecoveryDeed() : base( 0x14F0 )
		{
			Name = "a Faster Cast Recovery deed";
			Hue = 0x492;
		}

		public CastRecoveryDeed(Serial serial) : base(serial){}
		public override void Serialize( GenericWriter writer ) {base.Serialize( writer ); writer.Write( (int) 0 );}
		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt();}

		public override bool DisplayLootType{ get{ return false; } }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) ) from.SendLocalizedMessage( 1042001 );
			else
			{
				from.SendMessage("What item would you like to add faster cast recovery to?"  );
				from.Target = new CastRecoveryTarget( this );
			 }
		}
	}
//Faster Casting Deed
	public class CastSpeedTarget : Target
	{
		private CastSpeedDeed m_Deed;

		public CastSpeedTarget( CastSpeedDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}

		protected override void OnTarget( Mobile from, object target )
		{
			if ( target is BaseWeapon || target is BaseShield || target is BaseJewel )
			{
				Item item = (Item)target;
				if (item is BaseWeapon)
				{
					if ( ((BaseWeapon)item).Attributes.CastSpeed == 2 ) from.SendMessage( "That already has 2 faster casting!");
					else
					{
						if( item.RootParent != from ) from.SendMessage( "You can not put faster casting on that there!" );
						else
						{
							((BaseWeapon)item).Attributes.CastSpeed = 1;
							from.SendMessage( "You magically add faster casting to your item...." );
							m_Deed.Delete();
						}
					}
				}
				if (item is BaseShield)
				{
					if ( ((BaseShield)item).Attributes.CastSpeed == 2 ) from.SendMessage( "That already has faster casting!");
					else
					{
						if( item.RootParent != from ) from.SendMessage( "You cannot put faster casting on that there!" );
						else
						{
							((BaseShield)item).Attributes.CastSpeed = 1;
							from.SendMessage( "You magically add faster casting to your item...." );
							m_Deed.Delete();
						}
					}
				}
				if (item is BaseJewel)
				{
					if ( ((BaseJewel)item).Attributes.CastSpeed == 2 ) from.SendMessage( "That already has faster casting!");
					else
					{
						if( item.RootParent != from ) from.SendMessage( "You cannot put faster casting on that there!" );
						else
						{
							((BaseJewel)item).Attributes.CastSpeed = 1;
							from.SendMessage( "You magically add faster casting to your item...." );
							m_Deed.Delete();
						}
					}
				}
			}
			else from.SendMessage( "You can not put faster casting on that" );
		}
	}

	public class CastSpeedDeed : Item
	{
		[Constructable]
		public CastSpeedDeed() : base( 0x14F0 )
		{
			Name = "a Faster Casting deed";
			Hue = 0x492;
		}

		public CastSpeedDeed(Serial serial) : base(serial){}
		public override void Serialize( GenericWriter writer ) {base.Serialize( writer ); writer.Write( (int) 0 );}
		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt();}

		public override bool DisplayLootType{ get{ return false; } }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) ) from.SendLocalizedMessage( 1042001 );
			else
			{
				from.SendMessage("What item would you like to add faster casting to?"  );
				from.Target = new CastSpeedTarget( this );
			 }
		}
	}
}