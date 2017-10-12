using System;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Write Your Age: ");
            string age = Console.ReadLine();
            
            Console.WriteLine($"Welcome To My Program {name} So You're {age} Well Have Fun Exploring My Program");

            // Wait At End
            Console.ReadKey();
        }
    }
}
