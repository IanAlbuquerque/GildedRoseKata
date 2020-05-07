namespace csharp.GildedRose.GildedRoseItems
{
    public class EventPassItem: GildedRoseItem
    {
        public EventPassItem(Item item) : base(item)
        {
        }
        
        public override void UpdateQuality()
        {
            if (this.SellIn <= 0)
                this.DepleteItemQuality();
            else if (this.SellIn <= 5)
                this.Quality += 3;
            else if (this.SellIn <= 10)
                this.Quality += 2;
            else
                this.Quality += 1;

            this.SellIn--;
        }
    }
}