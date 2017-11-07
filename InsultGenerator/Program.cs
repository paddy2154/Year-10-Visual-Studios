using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        private static object rnd;

        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Ask Name
            string name = GetName();

            //Generate A Random Insult
            GenerateInsult(name, rnd);
        }
        private static string GetName()
        {
            Console.WriteLine("Welcome to my insult generator. What is your name? ");
            return Console.ReadLine();
        }
        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine("");
            Console.WriteLine(name + ", you are " + GetAdjuctive(rnd) + " " + GetCompoundAdjuctive(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }

        private static string GetObject(Random rnd)
        {
            throw new NotImplementedException();
        }

        private static string GetCompoundAdjuctive(Random rnd)
        {
            throw new NotImplementedException();
        }

        private static string GetAdjuctive(Random rnd)
        {
            throw new NotImplementedException();
        }

        private static void Menu(string name, Random rnd)
        {
            Console.Write("would you like another insult y/n: ");
            if(Console.ReadLine() == "y")
            {
                GenerateInsult(name, rnd);
            }
        }
        private static string GetAdjuctive()
        {
            string[] Adjuctives = {"a hairy", "an obnoxious", "a smelly", "a crusty",
                                    "an arragent", "a funky", "a lame", "a stinky"};
            return Adjuctives[rnd.Next(8)];
        }
        private static string GetCompoundAdjuctive()
        {
            string[] CompoundAdjuctives = {"no-good", "self-loathing", "trump-loving", "big-headed", "foul-mouthed",
                                           "cold-harted", "pimply-faced", "rage-inducing"};
            return CompoundAdjuctives[rnd.Next(8)];
        }
        private static string GetObject()
        {
            string[] Objects = {"turtle", "crab", "child", "sloth", "monkey", "stormtrooper",
                                "ice cream", "nugget", "simpleton", "lunatic", "dirtbag"};
            return Objects[rnd.Next(11)];
        }

    }
}
