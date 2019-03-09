using System;

namespace legos
{
    class Bald : Head
    {
        // properties that are describing the class. 
        // However, further they're "auto-implemented properties"
        // 
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }

        // Fields 
        // Contructor 
        // Methods - what should be able to do
        public void Cut(HairLength newLength)
        {
          HairLength = HairLength.CompletelyBald;
        }

        public override string Talk() 
        {
          return "I'm going to figure this out";
        }
    }
// enums are inside of the namespace, not the Bald class and that's how we can access them
    internal enum HairLength 
    {
      CompletelyBald,
      Stubble, 
      Short, 
      Medium, 
      Long
    }
    internal enum Colors
    {
      Yellow, 
      Red, 
      Freckles, 
      Tan,
      Orange,
    }
}