using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class Minifigure
    {

        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public LegsBase Legs { get; set; }

        // Constructors - what does this class have to have to exist
        public Minifigure(string name, Head head, Torso body, LegsBase legs)
        {
          Head = head;
          Body = body;
          Name = name;
          Legs = legs;
        }

        public void Greet()
        {
          Body.Wave();
          Head.Talk();
          Legs.Walk();
        }
    }
}
