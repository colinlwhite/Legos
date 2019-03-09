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
        // Intializing four new objects which are calling other classes and their constructor methods
        // An object is an instance of a class
        var myDogHead = new Dog();
        var martinHead = new Bald();
        var astronaught = new Astronaut();
        // The FitTorso constructor in FitTorso.cs takes 3 parameters 
        // (int numberOfArms, Sex sex = Sex.Shrug, Colors color = Colors.Red) 
        var fitTorso = new FitTorso(2, Sex.Male, Colors.Freckles);
        // calling the crunch method which is held within the FitTorso class
        // The method took an integer as a parameter
        fitTorso.Crunch(12);
        // The OrangeLegs constructor method took one parameter
        // We can use the Length enum because enums are by default public
        var adamsLegs = new OrangeLegs(Length.Short);
        // Passing these into the constructor which takes 4 parameters
        // Everything except the string "adam" is an object
        var minifigure = new Minifigure("Adam", martinHead, fitTorso, adamsLegs);
        // The Greet method calls 3 other methods

        // SECOND PARAM
        // The martinHead object calls the Bald class
        // In Minifigure.cs the Bald class is set to the Head property
        // Within the Greet Method, The Head property calls the Talk() method
        // Since Head property is essentially just Bald.cs it calls the Talk() method

        // THIRD PARAM
        // The fitTorso object calls the FitTorso class
        // In Minifigure.cs the FitTorso class is set to the Body property
        // Within the Greet Method, The Body property calls the Wave() method 
        // Since the Body property is essentially just FitTorso.cs it calls the Wave() method
        // The Wave() method in FitTorso.cs calls 
            // base.Wave()
                // base is going back to the superclass of FitTorso.cs which is Torso.cs 
                // In Torso.cs the Wave() method is just console writing "Waves hello works"
            // Console.WriteLine("Is it working?");

        // FOURTH PARAM
        // The adamsLegs object calls the OrangeLegs class
        // In Minifigure.cs the OrangeLegs class is passed to Legs property 
        // Within the Greet Method, the Legs property calls the Walk() property 
        // There isn't a Walk() method within the OrangeLegs class so it's in the superclass
        // The Walk() method console writes "Took a few steps"


        minifigure.Greet();
        // Body.Wave();
            // "Waves hello works"
            // "Is it working?"
        // Head.Talk();
            // "I pity the fool"
        // Legs.Walk();
            // "Took a few steps"
        Console.ReadLine();

    }
}

}
