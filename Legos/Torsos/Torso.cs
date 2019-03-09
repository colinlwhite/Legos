using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    abstract class Torso
    {
      // Four properties
      // Properties are CamelCase / Capitalized
      // We're customizing the accessibility of all the setters 
      // Protected Access Modifier 
      // Access is limited to the containing class or types(other classes) derived/obtained from the containing class.
      public int NumberOfArms { get; protected set; }
      public string FitnessOfAbdomen { get; protected set; }
      public Sex Sex { get; protected set; }
      // HOW DID WE GET ACCESS TO COLOR IN TORSO.CS WHEN WE'RE NOT INHERITING ANYTHING AND THE FILE IS SOMEWHERE ELSE?
      public Colors Color { get; protected set; }
      // Constructor method that takes four parameters
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
    // An enum provides an efficient way to define a set of named integral constants that may be assigned to a variable
    // An enum is basically a list of related constants 
    // enums make your code easier to read
    // Internal Access Modifier? 
    internal enum Sex 
    {
      Male,
      Female,
      Other,
      Shrug,

    }
}