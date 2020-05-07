namespace csharp.GildedRose.GildedRoseItems
{
    public class EventTicketItem: GildedRoseItem
    {
        public EventTicketItem(Item item) : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            if (this.SellIn <= 0)
                this.Quality = 0;
            else if (this.SellIn <= 5)
                this.Quality += 3;
            else if (this.SellIn <= 10)
                this.Quality += 2;
            else
                this.Quality += 1;
        }
    }
}