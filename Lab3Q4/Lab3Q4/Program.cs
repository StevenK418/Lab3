/*
 * Name:        Steven Kelly
 * Date:        05/02/2021
 * Exercise:    Lab3Q4
 * Description: "Write a program that takes user input describing playing cards in the following shorthand notation"
*/
using System;

namespace Lab3Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardCode = "";
            Console.WriteLine("Please enter in the card code in the form (<rank><suit>)");
            cardCode = Console.ReadLine();

            Console.WriteLine("Your code \"{0}\" has returned the card: \"{1}\"", cardCode, GetCard(cardCode));
        }

        /// <summary>
        /// Gets the name of a card based on a given code
        /// </summary>
        /// <param name="cardCode"></param>
        /// <returns>Returns the card name as a string.</returns>
        static string GetCard(string cardCode)
        {
            string cardName = "";
            string cardClass = cardCode.Substring(0, 1).ToUpper();
            string cardSuit = cardCode.Substring(1, 1).ToUpper();
            int cardNumber1 = 0;
            int cardNumber2 = 0;
            string cardNumber = "";
            bool classIsNumber = false;
            bool suitIsNumber = false;

            if (cardCode.Length == 3)
            {
                cardSuit = cardCode.Substring(2, 1).ToUpper();
                classIsNumber = int.TryParse(cardClass, out cardNumber1);
                suitIsNumber = int.TryParse(cardSuit, out cardNumber2);
                if (classIsNumber)
                {
                    cardNumber = cardNumber1.ToString() + cardNumber2.ToString();
                    int number = int.Parse(cardNumber);
                    switch (number)
                    {
                        case 10:
                            cardName += "Ten";
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {

                classIsNumber = int.TryParse(cardClass, out cardNumber1);
                if (classIsNumber)
                {
                    switch (cardNumber1)
                    {
                        case 1:
                            cardName += "One";
                            break;
                        case 2:
                            cardName += "Two";
                            break;
                        case 3:
                            cardName += "Three";
                            break;
                        case 4:
                            cardName += "four";
                            break;
                        case 5:
                            cardName += "Five";
                            break;
                        case 6:
                            cardName += "Six";
                            break;
                        case 7:
                            cardName += "Seven";
                            break;
                        case 8:
                            cardName += "Eight";
                            break;
                        case 9:
                            cardName += "Nine";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (cardClass)
                    {
                        case "A":
                            cardName += "Ace";
                            break;
                        case "J":
                            cardName += "Jack";
                            break;
                        case "Q":
                            cardName += "Queen";
                            break;
                        case "K":
                            cardName += "King";
                            break;
                        default:
                            break;
                    }
                }
            }

            //Append the common middle "of"
            cardName += " of ";

            //Check the suit and append the correct full suit title
            switch (cardSuit)
            {
                case "D":
                    cardName += "Diamonds";
                    break;
                case "H":
                    cardName += "Hearts";
                    break;
                case "S":
                    cardName += "Spades";
                    break;
                case "C":
                    cardName += "Clubs";
                    break;
                default:
                    break;
            }

            return cardName;
        }
    }
}