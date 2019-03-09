using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class FitTorso : Torso
    {
      // constructor overloading 
      // no return type on constructor methods
      // Since we're inheriting Torso.cs we get access to its properties
      // The parameters like numberOfArms, sex and color are lowercase. They're not properties
      // I can name the parameters whatever I want
      public FitTorso(int numberOfArms, Sex sex = Sex.Shrug, Colors color = Colors.Red) 
      // base is taking us to Torso.cs
      : base(numberOfArms,sex,color, "OMG, so fit." )
      {
      }

      // Method 
      public void Crunch(int howManyCrunches)
      {
        FitnessOfAbdomen = FitnessOfAbdomen + "Even more fit!";
        Console.WriteLine($"I just did {howManyCrunches}, bro.");
      }

      public override void Wave()
      {
        base.Wave();
        Console.WriteLine("Is this working?");
      }
        
    }

}