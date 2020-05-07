using csharp.External;

namespace csharp.GildedRose.GildedRoseItems
{
    public class ConjuredItem: GildedRoseItem
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (this.IsPastSellInDate)
                this.Quality -= 4;
            else
                this.Quality -= 2;
            this.SellIn--;
        }
    }
}