/*
 * Name:        Steven Kelly
 * Date:        04/02/2021
 * Exercise:    Lab3Q2
 * Description: "Write a program using a switch statement to determine the total cost of an order, where the user enters a product code and a quantity.
 *               If an invalid product code is entered , signal this as an error.If the total value of the order is greater than 500 a discount of 10% 
 *               is applied"
*/
using System;

namespace Lab3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configure output encoding for currency values
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Array of predefined item codes. Enum would be preferable but array will do for this exercise. 
            string[] itemCodes = new string[11] { "ASD","THF","TYG","GHT","YUR","UIT","HIT","UIP","RRT","JJK","IOP"};

            string productCode;
            int quantity;

            //Prompt user for the product code
            Console.Write("Enter product code: ");
            productCode = Console.ReadLine().ToUpper();
            int counter = 0;

            if(CheckIsValidCode(productCode, itemCodes))
            {
                //Prompt user for the quantity
                Console.Write("Enter Quantity Required: ");
                bool isValidQuantity = int.TryParse(Console.ReadLine(), out quantity);
                if (isValidQuantity)
                {
                    //Call the Calculate method and display the formatted results back to the user
                    Console.WriteLine("For item {0} x {1}, the total cost is {2:C}", productCode, quantity, CalculateCost(productCode, quantity));
                }
                else
                {
                    Console.WriteLine("Invalid Quantity entered.");
                }
            }
            else
            {
                Console.WriteLine("Invalid code entered!");
            }
        }

        /// <summary>
        /// Calculates the cost of an item which corresponds with a given Item Code. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        static double CalculateCost(string code, double quantity)
        {
            double cost = 0;
            switch (code)
            {
                case "ASD":
                    cost = 67.95;
                    break;
                case "THF":
                    cost = 68.90;
                    break;
                case "TYG":
                    cost = 34.95;
                    break;
                case "GHT":
                    cost = 88.90;
                    break;
                case "YUR":
                    cost = 23.80;
                    break;
                case "UIT":
                    cost = 9.90;
                    break;
                case "HIT":
                   
                case "UIP":
                    
                case "RRT":
                    
                case "JJK":
                    
                case "IOP":
                    cost = 10.00;
                    break;
                default:
                    break;
            }
            cost *= quantity;
            if (cost > 500)
            {
                double discountAmount = cost * .10;
                cost -= discountAmount;
            }
            return cost;
        }

        /// <summary>
        /// Checks a given code against all valid codes. 
        /// </summary>
        /// <param name="itemCode"></param>
        /// <param name="codes"></param>
        /// <returns>Returns true or false if the code is found.</returns>
        static bool CheckIsValidCode(string itemCode, string[] codes)
        {
            bool isValid = false;
            foreach (string code in codes)
            {
                if(itemCode == code)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
