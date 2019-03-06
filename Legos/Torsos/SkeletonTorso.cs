using System;
using System.Collections.Generic;
using System.Text;


namespace legos
{
    class SkeletonTorso : Torso
    {
      public SkeletonTorso(int numberOfArms) 
      : base(numberOfArms,Sex.Shrug, Colors.Tan, "bony")
      {
      }
        public void Rattle() 
        {
          Console.WriteLine("Rattle Rattle.... ");
        }
    }

}