using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class Dog : Head
    {
        // Properties - describing it 
        // Fields
        // Contructors
        // Methods - what kind of things would a dog head do?
        public override string Talk() 
        {
          return "Bark! I'm a dog head....";
        }

        public string Lick()
        {
          return "Taste like human.";
        }
        
    }
}
