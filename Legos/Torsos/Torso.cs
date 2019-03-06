using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    abstract class Torso
    {
      public int NumberOfArms { get; protected set; }
      public string FitnessOfAbdomen { get; protected set; }
      public Sex Sex { get; protected set; }
      public Colors Color { get; protected set; }
      // Contrcutor?
      protected Torso(int numberOfArms, Sex sex, Colors color, string fitnessOfAbdomen)
      {
        // setting propeties
        NumberOfArms = numberOfArms;
        Sex = sex;
        Color = color;
        FitnessOfAbdomen = fitnessOfAbdomen;
      }
      public virtual void Wave() 
      {
        Console.WriteLine("Waves hello works");
      }

      
        
    }

    internal enum Sex 
    {
      Male,
      Female,
      Other,
      Shrug,

    }
}