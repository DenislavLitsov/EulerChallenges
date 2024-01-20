namespace Common.Cards.Main
{
    public class TableHand
    {
        public TableHand(IEnumerable<Card> cards)
        {
            this.Cards = cards;
        }

        public IEnumerable<Card> Cards { get; set; }
    }
}
