using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X ");
            float X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            float Y = float.Parse(Console.ReadLine());

            //Output
            Console.WriteLine($"{X} plus {Y} = {(X + Y)}");
            Console.WriteLine($"{X} Times {Y} = {(X * Y)}");
            Console.WriteLine($"{X} Minus {Y} = {(X - Y)}");
            Console.WriteLine($"{X} Divided By {Y} = {(X / Y)}");



                //Wait At End
            Console.ReadLine();
        }
    }
}
