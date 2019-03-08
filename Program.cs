using System;

namespace legos
{
    class Program
    {
        // The Main() method is the entry point a C# program from where the execution starts.
        // static: It means Main Method can be called without an object.
        // void: The Main method doesn’t return anything.
        // String []args: For accepting the zero-indexed command line arguments. args is the user-defined name. So you can change it by a valid identifer. [] must come before the args otherwise compiler will give errors.
        static void Main(string[] args)
        {
        // Intializing four new objects 
        var myDogHead = new Dog();
        var martinHead = new Bald();
        var astronaught = new Astronaut();
        // The FitTorso constructor in FitTorso.cs takes 3 parameters 
        // (int numberOfArms, Sex sex = Sex.Shrug, Colors color = Colors.Red) 
        var fitTorso = new FitTorso(2, Sex.Male, Colors.Freckles);
        fitTorso.Crunch(12);

        var adamsLegs = new OrangeLegs(Length.Short);

        // Passing these into the constructor
        var minifigure = new Minifigure("Adam", martinHead, fitTorso, adamsLegs);
        minifigure.Greet();
        Console.ReadLine();

    }
}

}
