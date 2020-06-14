using System; 
using Server; 

namespace Server.Items 
{ 
   public class MagicOrcHelm : Item 
   { 
      [Constructable] 
      public MagicOrcHelm() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public MagicOrcHelm( int amount ) : base( 0x1F0B ) 
      {
	 Name = "A Magical Orc Helm";
	 Stackable = false;
	 Hue = 1152;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public MagicOrcHelm( Serial serial ) : base( serial ) 
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