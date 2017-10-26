using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4")
            {
                //Mean
                Console.Clear();
                Console.WriteLine("Choose An Option");
                Console.WriteLine("1. Area Of Triangle");
                Console.WriteLine("2. Area Of Rectangle");
                Console.WriteLine("3. Area Of Circle");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    //Triangle
                    Console.WriteLine();
                    Console.Write("Base: ");
                    float Width = float.Parse(Console.ReadLine());
                    Console.Write("Hight: ");
                    float Hight = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (0.5 * Width * Hight));
                }
                else if (choice == "2")
                {
                    //Rectangle
                    Console.WriteLine();
                    Console.Write("Base: ");
                    float Width = float.Parse(Console.ReadLine());
                    Console.Write("Lenght: ");
                    float Lenght = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (Width * Lenght));

                }
                else if (choice == "3")
                {
                    //Circle
                    Console.WriteLine();
                    Console.Write("Radius: ");
                    float Radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (Math.PI * Radius * Radius));
                }

                //Wait
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();

            }
        }
    }
}
