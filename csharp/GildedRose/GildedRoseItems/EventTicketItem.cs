namespace csharp.GildedRose.GildedRoseItems
{
    public class EventTicketItem: GildedRoseItem
    {
        public EventTicketItem(Item item) : base(item)
        {
        }

        private bool IsReallyCloseToSellInDate => this.SellIn <= 5;
        private bool IsCloseToSellInDate => this.SellIn <= 10;

        protected override void UpdateQuality()
        {
            if (this.IsPastSellInDate)
                this.Quality = 0;
            else if (this.IsReallyCloseToSellInDate)
                this.Quality += 3;
            else if (this.IsCloseToSellInDate)
                this.Quality += 2;
            else
                this.Quality += 1;
        }
    }
}