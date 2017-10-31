using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop
            for (int i = 1; i <= 10000000; i++)
            {
                //Divisible By Both 3 And 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz Buzz");
                    Console.Beep(5000, 100);
                }
                //Divisible By 3
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fizz");
                    Console.Beep(7000, 100);
                }
                //Divisible By 5
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Buzz");
                    Console.Beep(9000, 100);
                }
                else if (i == 59)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HELLO!!");
                }
                //Otherwise, Just Print The Number
                else
                {
                    Console.WriteLine(i);
                }
            }

            //Wait
            Console.WriteLine("\nPress Any Key To Exit... ");
            Console.ReadKey();
        }
    }
}
