using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Goodbye World!");
            Console.Beep();
            Console.Beep(4000, 2000);
            Console.Title = "My Program";
            Console.ReadLine();
        }
    }   
}
