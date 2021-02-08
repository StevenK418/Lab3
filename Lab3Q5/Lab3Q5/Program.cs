/*
 * Name:        Steven Kelly
 * Date:        05/02/2021
 * Exercise:    Lab3Q5
 * Description: "Write a program that read a word and print the number of vowels in that word.  
 *               For example if the user provides the word “Harry”, the program prints 2 vowels. 
 *               Hint: consider string x = “abc”; x.Length  returns the length of the string, 
 *               i.e 3 so we loop 3 times examining each letter "
*/
using System;

namespace Lab3Q5
{
    class Program
    {
        static string x = "Hey there! I am counting vowels!";
        static string y = "It was the best of times, it was the worst of times!";
        static string z = "Sasquatch";
        static void Main(string[] args)
        {
            //Call countvowels method and display results back to the user
            Console.WriteLine("Number of vowels in \"{0}\" is: {1}", x, CountVowels(x.ToLower()));
            Console.WriteLine("Number of vowels in \"{0}\" is: {1}", y, CountVowels(y.ToLower()));
            Console.WriteLine("Number of vowels in \"{0}\" is: {1}", z, CountVowels(z.ToLower()));
        }

        /// <summary>
        /// Counts the number of valid vowels in a given string. 
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns>Returns the number of vowels as an integer</returns>
        static int CountVowels(string sequence)
        {
            int counter = 0;
            foreach (char letter in sequence)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            return counter;
        }
    }
}
