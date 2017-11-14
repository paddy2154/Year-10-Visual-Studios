using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyBlackjack
{
    class Program
    {

        static void Main(string[] args)
        {
            float money = 20;
            playGame(ref money);

        }

        private static void playGame(ref float money)
        {
            Console.Clear();
            float betAmount = MakeBet(ref money);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The Dealer");
            bool playerWins = determinWinner(playerTotal, dealerTotal);
            PayOut(playerWins, betAmount, ref money);
            menu(ref money);
        }

        private static void menu(ref float money)
        {
            Console.Write("Would you like another game? y/n:  ");
            if (Console.ReadLine() == "y")
            {
                playGame(ref money);
            }
        }                                                  

        private static void PayOut(bool playerWins, float betAmount, ref float money)
        {
            if (playerWins)
            {
                money = money + (betAmount * 2);
            }
        }

        private static bool determinWinner(int playerTotal, int dealerTotal)
        {
            if (playerTotal > dealerTotal)
            {
                Console.WriteLine("You Win!");
                return true;
            }
            else if (playerTotal < dealerTotal)
            {
                Console.WriteLine("You Lose!");
                return false;
            }
            else
            {
                Console.WriteLine("Its A Draw! Dealer Still Wins!");
                return false;
            }
        } 

        private static int DealCards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.WriteLine(player + " draw " + card1 + " and " + card2 + " for a total of " + total);
            return total;
        }

        private static float MakeBet(ref float money)
        {
            float betAmont = 0;
            bool validBet = false;

            Console.WriteLine("Make a bet. You have $" + money);

            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmont);

                if (betAmont > money)
                {
                    Console.WriteLine("Sorry you do not have  enough. Try again.");
                    validBet = false;
                }
                else if (betAmont < 0)
                {
                    Console.WriteLine("Sorry you have a negative amount. Try again.");
                    validBet = false;
                }
                
            }

            money = money - betAmont;
            return betAmont;

        }                                             
    }
}
