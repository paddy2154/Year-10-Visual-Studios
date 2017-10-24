using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter To Start...");
            Console.BackgroundColor = ConsoleColor.Blue;
            int Number = int.Parse(Console.ReadLine());

            for (int Num = 1; Num <= Number; Num++)
            {
                Console.Write(Num);
            }

            // WAIT AT END
            Console.ReadLine();
        }
    }
}
