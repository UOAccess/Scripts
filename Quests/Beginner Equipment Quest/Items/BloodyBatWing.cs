using System; 
using Server; 

namespace Server.Items 
{ 
   public class BloodyBatWing : Item 
   { 
      [Constructable] 
      public BloodyBatWing() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public BloodyBatWing( int amount ) : base( 0xF78 ) 
      {
	 Name = "A Bloody Bat Wing";
	 Stackable = false;
	 Hue = 38;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public BloodyBatWing( Serial serial ) : base( serial ) 
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