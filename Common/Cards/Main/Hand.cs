namespace Common.Cards.Main
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            this.Cards = cards;
        }

        public IEnumerable<Card> Cards { get; set; }
    }
}
