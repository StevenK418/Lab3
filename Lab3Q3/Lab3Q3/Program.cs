/*
 * Name:        Steven Kelly
 * Date:        05/02/2021
 * Exercise:    Lab3Q3
 * Description: "Write a program which will read in the score a gamer got in a game and determines their corresponding ranking, 
 *               given the following – you must use a switch statement (but Not with 100 cases! – hint think integer division)"
*/
using System;

namespace Lab3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            //Prompt user to enter a score:
            Console.Write("Enter the score: ");
            score = int.Parse(Console.ReadLine());

            //Display the result back to the user
            Console.WriteLine("Ranking for score of {0} is \"{1}\"", score, ComputeRank(score));
        }


        /// <summary>
        /// Determines a gamer's rank based on a given score value. 
        /// </summary>
        /// <param name="score"></param>
        /// <returns>Returns the rank as a string message.</returns>
        static string ComputeRank(int score)
        {
            string rank = "";
            int adjustedScore = score / 10;
            switch (adjustedScore)
            {
                case 4:
                    rank = "don’t give up the day job dude";
                    break;
                case 5:
                    rank = "back to the training ground dude";
                    break;
                case 6:
                    rank = "some potential here dude";
                    break;
                case 7:
                    rank = "Your good dude";
                    break;
                case 8:
                case 9:
                case 10:
                    rank = "Awesome dude";
                    break;
                default:
                    break;
            }
            return rank;
        }
    }
}
