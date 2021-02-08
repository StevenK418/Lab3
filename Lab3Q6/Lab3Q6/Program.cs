/*
 * Name:        Steven Kelly
 * Date:        05/02/2021
 * Exercise:    Lab3Q6
 * Description: "Write a program to print the following celcius/Fahrenheit conversion table.
 *              C is Celsius
 *              F is Fahrenheit
 *              C = 5/9 (F-32)
 *              F = 9/5 (C+32)
 *            -------------------------- 
 *            | Celcius  |   Fahrenheit|
 *            --------------------------
 *            |  0	     |  32         |
 *            |  10      |	50         |
 *            |  20      |	68         |
 *            |  …	..   |             |
 *            |  …	..   |             |
 *            |  100	 |  211"       |
 *            --------------------------
*/
using System;

namespace Lab3Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0, -12} {1, 15}", "Celsius", "Fahrenheit");

            //Iterate through celsius values in increments of 10 
            for (int i = 0; i <= 100; i+=10)
            {
                //Call the convert method and print out the table of converted values.
                Console.WriteLine("{0, -12} {1, 15}", i, convertCelsiusToFahrenheit(i));
            }
        }

        /// <summary>
        /// Converts a given Celsius value to fahrenheit.
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns>Returns the value in Fahrenheit as a double.</returns>
        static double convertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 9/5 + 32;
            return fahrenheit;
        }
    }
}
