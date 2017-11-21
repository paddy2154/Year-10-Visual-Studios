using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Sit();
            p.Stand();
            p.Birthday();
            p.PrintInfo();

            Console.ReadKey();

        }
    }

    class Person
    {
        private string FirstName;
        private string LastName;
        private int age;
        private bool sitting;
        private int steps;


        public Person(string FirstName, string LastName, int age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.age = age;
            sitting = true;
            steps = 0;
        }
        public void Birthday()
        {
            age++;
        }

        public void PrintInfo()
        {
            if (sitting)
            {
                Console.WriteLine($"{FirstName} {LastName} is {age} years old, is currently sitting " + 
                    $"and has taken {steps} steps. ");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} is {age} years old, is currently standing " +
                    $"and has taken {steps} steps. ");
            }
        }

        public void Sit()
        {
            if (sitting)
            {
                Console.WriteLine($"{FirstName} {LastName} is already sitting");
            }
            else
            {
                sitting = true;
            }
        }

        public void Stand()
        {
            if (sitting)
            {
                sitting = false;
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} is already standing");
            }
        }
    }

    
}
