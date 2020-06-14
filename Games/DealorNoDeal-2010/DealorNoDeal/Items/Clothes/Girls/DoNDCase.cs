using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class DoNDCase : BaseEquipableLight
	{
		public override int LitItemID{ get { return 0xEFA; } }
		public override int UnlitItemID{ get { return 0xEFA; } }

		[Constructable]
		public DoNDCase() : base( 0xEFA )
		{
			Layer = Layer.TwoHanded;
			Light = LightType.Circle150;
			Movable = false;
		}

		public DoNDCase( Serial serial ) : base( serial )
		{
		}

		public override bool DisplayLootType{ get{ return false; } }

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
	}
}