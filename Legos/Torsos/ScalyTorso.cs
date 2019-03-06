using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class ScalyTorso : Torso
    {
     // contructor 
     public ScalyTorso() 
     : base (4, Sex.Other, Colors.Tan, "Hard is a rock")
     {
        
     }

     public override void Wave()
     {
       Console.WriteLine(@"Fragile Waving");
     }

    }
}