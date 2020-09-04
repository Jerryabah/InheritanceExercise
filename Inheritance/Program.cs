using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            /*Create an object of your Bird class
            *  give values to your members using the object of your Bird class
            *  
            * Creatively display the class member values 
            */
            
            Bird bird = new Bird();
            bird.HasFeathers = true;
            bird.WingColor = true;
            bird.LegCount = 2;
            bird.Age = 4;
            
            Console.WriteLine("I have a Bird");
            Console.WriteLine("My bird has the following charactersitics:");
            Console.WriteLine($"- Has Feathers: {bird.HasFeathers}");
            Console.WriteLine($"- Has Wings: {bird.WingColor}");
            Console.WriteLine($"- Has {bird.LegCount} legs.");
            Console.WriteLine($"- And is {bird.Age} years old.\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile crocodile = new Reptile();
            crocodile.Age = 12;
            crocodile.AreColdBlooded = true;
            crocodile.AreVertebrates = true;
            crocodile.BreatheThroughLungs = true;
            crocodile.LandAirSea = "Sea";

            Console.WriteLine("I once visited a rain forest in Africa.");
            Console.WriteLine("During the visit I saw a crocodile that has the following charactersitics:");
            Console.WriteLine($"- Age: {crocodile.Age}");
            Console.WriteLine($"- Are Cold Blooded: {crocodile.AreColdBlooded}.");
            Console.WriteLine($"- Are Vertebrates: {crocodile.AreVertebrates}.");
            Console.WriteLine($"- Breathe through their lungs: {crocodile.BreatheThroughLungs}.");
            Console.WriteLine($"- and lives in the {crocodile.LandAirSea}.");
        }
    }
}
