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
        
        public override string ToString()
        {
            return string.Format("The {0} of {1}", FaceValue, Suit)
        }
    }
}
