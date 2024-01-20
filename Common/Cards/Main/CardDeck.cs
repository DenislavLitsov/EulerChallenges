namespace Common.Cards.Main
{
    public class CardDeck
    {
        public CardDeck(ICollection<Card> cards)
        {
            this.Cards = cards;
        }

        public ICollection<Card> Cards { get; set; }

        public void Shuffle()
        {
            Random rnd = new Random();
            List<Card> shuffledCards = new List<Card>();

            while (this.Cards.Count > 0)
            {
                int index = rnd.Next(this.Cards.Count);
                var card = this.Cards.ElementAt(index);
                shuffledCards.Add(card);
                this.Cards.Remove(card);
            }

            this.Cards = shuffledCards;
        }
    }
}
