using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate Random Number
            Random rnd = new System.Random();
            int RandomNumber = rnd.Next(1, 101);

            //Set Guess Number To Out Of Guess Range
            int guess = -1;

            //Start Loop
            while (guess != RandomNumber)
            {
                //Input
                guess = int.Parse(Console.ReadLine());

                //Selection
                if (guess > RandomNumber)
                {
                    Console.WriteLine("Too High");
                }
                else if (guess < RandomNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else 
                {
                    Console.WriteLine("Correct");
                }

            }
            //Wait
            Console.ReadKey();
        }   
    }
}
