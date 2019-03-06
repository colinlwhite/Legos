using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class OrangeLegs : LegsBase
    {
      // Constructor 
      // Base Class legs constructor in legs has to take two parameters too 
      // Have to construct the legs abstract class and have to pass in length and color 
      public OrangeLegs(Length legLength) : base(legLength, Colors.Orange)
      {
        Hairy = true;
        CanBend = true;
      }
      
      public override void Jump()
      {
        Console.WriteLine("Orange legs loose control and flail in the air!");
      }
      
        
    }
}