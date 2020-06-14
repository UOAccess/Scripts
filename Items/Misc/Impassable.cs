using System;
using Server;
using Server.Items;

namespace Server.Items
{

	public class Impassable : Item
	{
		/// <summary>
        /// This is an Item that was created to make invisible 
        /// barriers for players not be able to pass.
        /// </summary>
        [Constructable]
        public Impassable() : base(0x1184)
		{
            Weight = 0;
            Name = "An Impassable Object";
            Visible = false;
            Movable = false;

		}

        public Impassable(Serial serial)
            : base(serial)
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
