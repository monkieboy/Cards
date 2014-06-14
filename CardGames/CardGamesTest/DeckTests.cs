using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGames;
using NUnit.Framework;


namespace CardGamesTest
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void Should_attach_a_suit_value_to_card()
        {
            const int suitItration = 2;
            var suit = Deck.GetSuit(suitItration);
            Assert.That(suit, Is.EqualTo("Clubs"));
        }

        [Test]
        public void Should_replace_a_card_whos_value_is_greater_than_ten_with_its_picture_card_value()
        {
            const string cardValue = "13";
            var cardName = Deck.GetPictureCardName(cardValue);
            Assert.That(cardName , Is.EqualTo("Queen"));
        }
    }
}
