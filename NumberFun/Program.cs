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
            Console.WriteLine("Enter Number1 ");
            float Num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            float Num2 = float.Parse(Console.ReadLine());

                //Output
            Console.WriteLine("Number 1 plus Number 2 =" + (Num1 + Num2));
            Console.WriteLine("Number 1 Times Number 2 =" + (Num1 * Num2));
            Console.WriteLine("Number 1 Minus Number 2 =" + (Num1 - Num2));
            Console.WriteLine("Number 1 Divided By Number 2 =" + (Num1 / Num2));

                //Wait At End
            Console.ReadLine();
        }
    }
}
