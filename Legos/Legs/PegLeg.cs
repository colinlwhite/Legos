using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class PegLeg : LegsBase
    {
      // constructor - base legs constructor in legs has to take two parameters too 
        public PegLeg(Length legLength) 
        : base(legLength, Colors.Tan)
        {

        }

        public override void Jump()
        {
          Console.WriteLine($"The {(Hairy ? "hairy " : "")} peg legs don't jump.");
        }
      
        
    }
}