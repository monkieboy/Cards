using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CardGames
{
    public class Deck
    {

        public List<PlayingCard> DeckOfCards()
        {
            var cardDeck = new List<PlayingCard>();

            for (var s = 0; s < 4; s++)
            {
                for (var i = 2; i < 15; i++)
                {
                    var cardValue = i.ToString(CultureInfo.InvariantCulture);
                    
                    if (i > 10 && i <= 14)
                    {
                        GetPictureCardName(cardValue);
                    }

                    var cardSuit = GetSuit(s);
                    cardDeck.Add(new PlayingCard(cardValue, cardSuit));
                }
            }
            return cardDeck;
        }
     
        public static string GetPictureCardName(string cardValue)
        {
            switch (cardValue)
            {
                case "11":
                    cardValue = "Jack";
                    return cardValue;

                case "12":
                    cardValue = "Queen";
                    return cardValue;

                case "13":
                    cardValue = "King";
                    return cardValue;

                default:
                    cardValue = "Ace";
                    return cardValue;
            }
        }

        public static string GetSuit(int suitItration)
        {
            switch (suitItration)
            {
                case 0:
                    return "Diamond";

                case 1:
                    return "Hearts";

                case 2:
                    return "Clubs";

                default :
                    return "Spades";
            }
        }


        readonly Random _random = new Random();

        public int RandomiseACard(int amount)
        {
            var random = _random;
            var cardPosition = random.Next(amount);
            return cardPosition;
        }

        public void RemoveDealtCard(List<PlayingCard> cards, int locationInDeck)
        {
            cards.RemoveAt(locationInDeck);
        }

        public object Deal()
        {
            var amount = DeckOfCards().Count;
            var cards = DeckOfCards();
            var dealtCardPosition = RandomiseACard(amount);
            object playersCard = cards[dealtCardPosition];
            var hands = new Hand();
           // hands.FaceValue =  ;
            RemoveDealtCard(cards, dealtCardPosition);
            Thread.Sleep(50);
            return playersCard;
        }
        

       

    }
}



