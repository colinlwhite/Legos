using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    abstract class LegsBase
    {
      // Properties
      public bool Hairy { get; set; }
      public Colors Color { get; set; }
      public bool CanBend { get; set; }
      public Length Length { get; set; }

      // Contrustor Method
      public LegsBase(Length length, Colors color)
      {
          // Setting the properties above 
          Length = length;
          Color = color;
      }

     // Methods
     public virtual void Jump()
     {
        Console.WriteLine("Weeee!!!!!");        
     }

     public void Kick(Minifigure personToKick)
     {
       GetType();
        Console.WriteLine($"{personToKick.Name} just got kicked. Ha ha ha. {GetType().Name} You're not even a scientist");
     }

     public void Walk() 
     {
        Console.WriteLine("Took a few steps");        
        
     }
    }

    enum Length
    {
      Short,
      Medium,
      Long,
      SuperLong,
      
    }

}