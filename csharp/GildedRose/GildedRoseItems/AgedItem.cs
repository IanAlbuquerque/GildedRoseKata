using csharp.External;

namespace csharp.GildedRose.GildedRoseItems
{
    public class AgedItem: GildedRoseItem
    {
        public AgedItem(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (this.IsPastSellInDate)
                this.Quality += 2;
            else
                this.Quality += 1;
            this.SellIn--;
        }
    }
}