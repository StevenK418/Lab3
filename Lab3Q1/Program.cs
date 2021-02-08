/*
 * Name:        Steven Kelly
 * Date:        03/02/2021
 * Exercise:    Lab3Q1
 * Description: "Write a program using a switch statement to determine the day of the week given a day number, 
 *               the user will enter a number is the range 1-7 and output the name of the day ( 1 = Monday, 2 = Tuesday etc)
 *               
 *               If an invalid day number is entered , signal this with an error message."
*/
using System;

namespace Lab3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber;
            Console.Write("Enter day number: ");
            dayNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} = {1}", dayNumber, GetDayOfWeek(dayNumber));
        }

        /// <summary>
        /// Gets the day of the week based on a given index. 
        /// </summary>
        /// <param name="dayIndex"></param>
        /// <returns>Returns day of the week as a string</returns>
        static string GetDayOfWeek(int dayIndex)
        {
            string dayName = ""; 
            switch (dayIndex)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day Entered";
                    break;
            }
            return dayName;
        }
    }

    
}
