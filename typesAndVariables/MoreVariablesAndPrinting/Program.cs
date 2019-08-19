using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String name = "Zed A. Shaw";
            int age = 35;
            double height = 74 * 2.54;  // inches to cm
            double weight = 180 * 0.453592; // lbs to kg
            String eyes = "Blue";
            String teeth = "White";
            String hair = "Brown";

            Console.WriteLine($"Let's talk about {name}.");
            Console.WriteLine($"He's {height} inches tall.");
            Console.WriteLine($"He's {height} pounds heavy.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"He's got {eyes} eyes and {hair} hair.");
            Console.WriteLine($"His teeth are usually {teeth} depending on the coffee.");

            Console.WriteLine($"If I add {age:0.##}, {height:0.##}, and {weight:0.##} I get {age + height + weight:0.##}.");

<<<<<<< Updated upstream
            Console.WriteLine("If I add " + myAge + ", " + myHeight + ", and " + myWeight
                               + " I get " + (myAge + myHeight + myWeight) + ".");

=======
>>>>>>> Stashed changes
            Console.ReadKey();
        }
    }
}