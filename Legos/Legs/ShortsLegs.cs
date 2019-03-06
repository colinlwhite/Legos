using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class ShortsLegs : LegsBase
    {
      // Constructor 
      // Base Class legs constructor in legs has to take two parameters too 
      // Have to construct the legs abstract class and have to pass in length and color 
      public ShortsLegs(Length legLength, Colors shortsColor, bool isHairy) 
      : base(legLength, shortsColor)
      {
        Hairy = isHairy;
      }
      
      // public override void Jump()
      // {
      //   Console.WriteLine("Orange legs loose control and flail in the air!");
      // }
      
        
    }
}