using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Hand
    {
        List<Card> Cards = new List<Card>();

 

        public void TakeCards(Card sentCard)

        {

            Cards.Add(sentCard);

        }

 

        public void Show()

       {

            foreach (Card aCard in Cards)

            {

                Console.WriteLine(aCard);

            }

        }

 

        public int GetLength()

        {

            return Cards.Count;

        }

 

        public void ReturnCards(Deck deckToReturnTo)

        {

 

            for (int i = 0; i < GetLength(); i++)

            {

                deckToReturnTo.TakeCard(Cards[i]);

               

            }

            Cards.Clear();

 

 

 

        }

 

 

    }

}
    