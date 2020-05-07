namespace csharp.GildedRose.GildedRoseItems
{
    public class AgedBrie: GildedRoseItem
    {
        public AgedBrie(Item item) : base(item)
        {
        }
        
        public override void UpdateQuality()
        {
            if (this.SellIn <= 0)
                this.Quality += 2;
            else
                this.Quality += 1;
            
            this.SellIn--;
        }
    }
}