using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class Astronaut : Head
    {
        // Properties - describing it 
        public List<string> Accessories { get; set; }
        // Fields
        // Contructors
        // Methods - what kind of things would an atronaut do?
        public override string Talk() 
        {
          return $"Houston we have a problem...I have {HairLength} ";
        }
        
    }
}