using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Goodbye World!");
            Console.Title = "My Program";
            Console.ReadLine();
        }
    }   
}
