using System;
using System.Diagnostics.Metrics;

namespace MyFirstApp
{
    internal class Program
    {
        public static void Person()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}Hi! {name}! Where are you from?");
            var place = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine} I have never been to {place}. I bet it's nice.  Press any key to continue...");
            Console.ReadKey(true);
        }

        public static void Measure()
        {
            Console.WriteLine("Please input a Width:");
            // Safely parse width input
            if (!double.TryParse(Console.ReadLine(), out double width))
            {
                Console.WriteLine("Invalid input for width.");
                return; // Exit the method if input is not a valid integer
            }

            Console.WriteLine("Please input a Height:");
            // Safely parse height input
            if (!double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Invalid input for height.");
                return; // Exit the method if input is not a valid integer
            }

            // To calculate and display woodLength
            double woodLength = ((width + height) * 2) * 3.25;
            Console.WriteLine($"The length of the wood is: {woodLength}");
            
            

            // To calculate and display glass area.
            
            double glassArea = (width * height) * 2;
            Console.WriteLine($"The area of the glass is: {glassArea} square metres");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        public static void ChristmasCountdown()
        {
            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
            TimeSpan beforeChristmas = christmas - DateTime.Now;
            Console.WriteLine($"There are {beforeChristmas.Days} days until Christmas!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Person();
            Measure();
            ChristmasCountdown();
        }
    }
}

