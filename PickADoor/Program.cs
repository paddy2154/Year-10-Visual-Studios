using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
                //Output
            Console.WriteLine("Pick A Door 1,2,3");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Behind Door 1 is a TRUCK");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Behind Door 2 is Space");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Behind Door 3 is a Cow");
            }
            else
            {
                Console.WriteLine("Empty Nothingness");
            }


            //Wait At End
            Console.ReadLine();
        }
    }
}
