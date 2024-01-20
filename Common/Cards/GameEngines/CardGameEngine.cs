using Common.Cards.Main;

namespace Common.Cards.GameEngines
{
    public abstract class CardGameEngine
    {
        protected CardDeck CardDeck { get; set; }

        public abstract void CreateCardDeck();

        public abstract int WhoWins(IEnumerable<Hand> hands, TableHand tableHand);

        public Card GetNextCardAndRemove()
        {
            var card = this.CardDeck.Cards.Last();
            this.CardDeck.Cards.Remove(card);

            return card;
        }
    }
}
