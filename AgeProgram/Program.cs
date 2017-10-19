using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Your BirthDate");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            //Calculation
            int age = DateTime.Today.Year - birthday.Year;
            {
                Console.WriteLine($"You Are {age}");
            }

            //Selection
            if (age < 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else if (age < 13)
            {
                Console.WriteLine($"You're A {age} Year Old Child");
            }
            else if (age < 20)
            {
                Console.WriteLine($"You're a {age} Year Old Teenager");
            }
            else if (age < 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else
            {
                Console.WriteLine($"You're A {age} Adult");
            }





            Console.WriteLine("Input Your Age: ");
            int Age = int.Parse (Console.ReadLine());


            //Input
            if (Age < 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else if (Age < 13)
            {
                Console.WriteLine("Your A Child");
            }
            else if (Age < 20)
            {
                Console.WriteLine("Your A Teenager");
            }
            else if (Age < 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else
            {
                Console.WriteLine("Your An Adult");
            }
            

            //Wait At End
            Console.ReadKey();
        }
    }
}
