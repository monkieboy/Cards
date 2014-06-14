namespace CardGames
{
    public class PlayingCard
    {
        public PlayingCard(string value, string suit)
        {
            FaceValue = value;
            Suit = suit;
        }

        public string FaceValue { get; set; }

        public string Suit { get; set; }
    }
}