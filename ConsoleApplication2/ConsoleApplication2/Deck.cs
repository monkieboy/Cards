using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Deck
    {
        public List<Card> Cards = new List<Card>();

 

        public Deck()

        {

        for (var j = 0; j < 4; j++)

                {

            for (var i = 0; i < 13; i++)

            {

               

                    switch (j)

                    {

                        case 0:

                            Cards.Add(new Card(i + 2,"Diamonds" ));

                            break;

                        case 1:

                            Cards.Add(new Card(i + 2, "Spades"));

                            break;

                        case 2:

                            Cards.Add(new Card(i + 2, "Hearts"));

                            break;

                        case 3:

                            Cards.Add(new Card(i + 2, "Clubs"));

                            break;

                    }

                }

            }

           

        }

 

        public void Deal(Hand handToDealTo)

        {

 

            if (GetLength() > 0)

            {

                for (var i = 0; i < 5; i++)

                {

                    if (GetLength() - i < 0)

                    {

                        break;

                    }

                    handToDealTo.TakeCards(Cards[0]);

                    Cards.Remove(Cards[0]);

 

 

                }

            }

 

        }

 

        public void TakeCard(Card sentCard)

        {

            Cards.Add(sentCard);

        }

 

 

        public int GetLength()

        {

            return Cards.Count;

        }

 

        public void Shuffle()

        {

           

            for (int i = Cards.Count; i > 1; i--)

            {

                var shuffleRand = Rand;

                // Pick random element to swap.

                int j = shuffleRand.Next(i); // 0 <= j <= i-1

                // Swap.

                Card tmp = Cards[j];

                Cards[j] = Cards[i - 1];

                Cards[i - 1] = tmp;

            }

        }

 

        public void Show()

        {

            foreach (Card aCard in Cards)

            {

                Console.WriteLine(aCard);

            }

            Console.ReadKey();

        }

 

        public static Random Rand = new Random();

    }

}
