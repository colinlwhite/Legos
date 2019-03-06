using System;

namespace legos
{
    class Program
    {
        static void Main(string[] args)
        {
        var myDogHead = new Dog();
        var martinHead = new Bald();
        var astronaught = new Astronaut();

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
