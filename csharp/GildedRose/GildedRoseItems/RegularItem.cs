namespace csharp.GildedRose.GildedRoseItems
{
    public class RegularItem: GildedRoseItem
    {
        public RegularItem(Item item) : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            if (this.IsPastSellInDate)
                this.Quality -= 2;
            else
                this.Quality -= 1;
        }
    }
}