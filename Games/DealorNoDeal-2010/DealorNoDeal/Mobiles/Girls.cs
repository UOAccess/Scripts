using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	public class Girls : BaseCreature
	{
		[Constructable]
		public Girls( int i, Mobile m, Mobile bm ) : base( AIType.AI_Animal, FightMode.Aggressor, 20, 1, 0.2, 0.4 )
		{
			PlayerMobile pm = m as PlayerMobile;

			if ( pm == null )
				return;

			Howey bc = bm as Howey;

			if ( bc == null )
				return;

			Body = 0x191;
			CantWalk = true;
			Blessed = true;
			Frozen = true;

			AddItem( new GirlsDress() );
			AddItem( new GirlsSandals() );

			Item item = new DoNDCase();
			item.Name = "Case #" + i;
			item.Hue = 986;
			item.LootType = LootType.Blessed;

			EquipItem( item );
			
			Direction = Direction.South;
		}

		public override void OnThink()
		{
			Direction = Direction.South;
			
			if ( Frozen == false )
				Frozen = true;

			base.OnThink();
			return;
		}

		public Girls( Serial serial ) : base( serial )
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