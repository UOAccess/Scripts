// Anti-Gravity Diamond by Snobothehobo
using System;
using Server;

namespace Server.Items
{
	public class AntiGravityDiamond : Item
	{
        private string m_dateobtained;

        [Constructable]
		public AntiGravityDiamond() : this( 1 )
		{
		}

		[Constructable]
		public AntiGravityDiamond( int amount ) : base( 0xF26 )
		{
			Name = "Anti-Gravity Diamond";
			Stackable = false;
			Hue = 38;
		// Edit the weight here.
			Weight = -5000;

            DateTime dt = DateTime.Now;
            m_dateobtained = dt.ToString("y");
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
            list.Add("Obtained in ({0})", m_dateobtained);
        }

        public AntiGravityDiamond( Serial serial ) : base( serial )
		{
		}

		

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

            writer.Write((string)this.m_dateobtained);
        }

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        this.m_dateobtained = reader.ReadString();
                        break;
                    }
            }
        }
	}
}