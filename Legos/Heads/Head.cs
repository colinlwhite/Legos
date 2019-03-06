using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
// abstract is just there to be inherited - can't be instantiated 
    abstract class Head
    {
        // Properties - describing it 
        public Colors Color { get; protected set; }
        public HairLength HairLength { get; protected set; }
        public string EarSize { get; protected set; }

        // Fields
        // Contructors
        // Methods - what kind of things would an atronaut do?
        public virtual string Talk() 
        {
          return "Houston we have a problem...";
        }
        
    }
}
