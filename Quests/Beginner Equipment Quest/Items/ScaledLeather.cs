using System; 
using Server; 

namespace Server.Items 
{ 
   public class ScaledLeather : Item 
   { 
      [Constructable] 
      public ScaledLeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ScaledLeather( int amount ) : base( 0x1081 ) 
      {
	 Name = "Scaled Leather";
	 Stackable = false;
	 Hue = 475;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public ScaledLeather( Serial serial ) : base( serial ) 
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