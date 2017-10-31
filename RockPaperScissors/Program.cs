using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserScore = 0;
            int ComputerScore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw"
                PrintScore(ref UserScore, ref ComputerScore);                       //Print Scores
                string UserChoice = UserTurn();                                     //User's Turn
                string ComputerChoice = ComputerTurn();                             //Computer's Turn
                result = DeterminWinner(UserChoice, ComputerChoice);                //Determin Winner
                GiveFeedback(resule, UserChoice, ComputerChoice);                   //Provide Feedback
                updateScore(result, ref UserChoice, ref ComputerChoice);            //Update The Scores
                repeat = PlayAgain();                                               //Ask To PlayAgain

            }
        }
        private static updateScore(string result, ref int UserScore, ref int ComputerScore)
        {
            if (result == "win")
            {
                UserScore++;
            }
            else if (result == "lose")
            {
                ComputerScore ++;
            }
        }
        private static void PrintScore(ref int UserScore, ref int ComputerScore)
        {
            Console.Clear();
            Console.WriteLine("User: " + UserScore + "     Computer: " + ComputerScore );
        }
        private static void UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");                                                             //PAGE 25 OF SLIDES
                Console.WriteLine("3: Scissors");

            }


        }
        private static void ComputerTurn()
        {
            return "Paper";
        }
        private static void DeterminWinner(string UserChoice, string ComputerChoice)
        {
            if (UserChoice == "Rock")
            {
                if (ComputerChoice == "Rock")
                {
                    return "Draw";

                }
                else if (ComputerChoice == "Scissors")
                {
                    return "Win";
                }
                else
                {
                    return "win";
                }
            }
            if (UserChoice == "Paper")
            {
                if (ComputerChoice == "Rock")
                {
                    return "Win";

                }
                else if (ComputerChoice == "Scissors")
                {
                    return "Lose";
                }
                else
                {
                    return "Draw";
                }
            }
            if (UserChoice == "Scissors")
            {
                if (ComputerChoice == "Rock")
                {
                    return "Lose";

                }
                else if (ComputerChoice == "Scissors")
                {
                    return "Draw";
                }
                else
                {
                    return "Win";
                }
            }
        }
        private static void GiveFeedback(string result, string UserChoice, string ComputerChoice)
        {
            
        }
        private static bool PlayAgain()
        {
            Console.WriteLine("Do You Want To PlayAgain y/n");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y" || choice == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        
    }
}
