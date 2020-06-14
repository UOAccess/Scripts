using System; 
using Server; 

namespace Server.Items 
{ 
   public class ToadEye : Item 
   { 
      [Constructable] 
      public ToadEye() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public ToadEye( int amount ) : base( 0x108A ) 
      {
	 Name = "A Toad's Eye";
	 Stackable = false;
	 Weight = 0.1; 
         Amount = amount; 
      } 

      public ToadEye( Serial serial ) : base( serial ) 
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