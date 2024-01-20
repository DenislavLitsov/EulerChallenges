namespace Common.Cards.Main
{
    public class Card
    {
        public Card(CardValues cardValue, CardTypes cardType)
        {
            this.CardValue = cardValue;
            this.CardType = cardType;
        }

        public CardValues CardValue { get; private set; }

        public CardTypes CardType { get; private set; }
    }
}
