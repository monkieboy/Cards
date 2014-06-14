using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Card
    {
          public int CardValue { get; set; }

 

        public string CardSuit { get; set; }

 

        public override string ToString()

        {

            if (CardValue < 11)

            {

                return "The " + CardValue + " of " + CardSuit;

            }

            switch (CardValue)

            {

                case 11:

                    return "The Jack of " + CardSuit;

                case 12:

                    return "The Queen of " + CardSuit;

                case 13:

                    return "The King of " + CardSuit;

                default:

                    return "The Ace of " + CardSuit;

            }

        }

 

        public Card(int sentCardValue, string sentCardSuit)

        {

 

            if (sentCardValue > 1 && sentCardValue < 15)

            {

                if (sentCardSuit == "Spades" || sentCardSuit == "Clubs" || sentCardSuit == "Hearts" || sentCardSuit == "Diamonds")

                {

                    CardValue = sentCardValue;

                    CardSuit = sentCardSuit;

                }

                else

                {

                    Console.WriteLine("Suit Input Error Occured");

                 

                }

            }

            else

            {

                Console.WriteLine("Card Value Error Occurred");

            }

 

 

        }

 

      

 

    }

}
    

