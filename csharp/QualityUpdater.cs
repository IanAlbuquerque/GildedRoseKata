namespace csharp
{
    public class QualityUpdater
    {
        public void UpdateQualityOfItem(Item item)
        {
            if (item.IsSulfuras())
                this.UpdateAsSulfuras(item);
            else if (item.IsBackstagePasses())
                this.UpdateAsBackstagePasses(item);
            else if (item.IsAgedBrie())
                this.UpdateAsAgedBrie(item);
            else
                this.UpdateAsRegular(item);
        }

        private void UpdateAsBackstagePasses(Item item)
        {
            if (item.SellIn <= 0)
                item.Quality = 0;
            else if(item.SellIn <= 5)
                item.Quality += 3;
            else if (item.SellIn <= 10)
                item.Quality += 2;
            else
                item.Quality += 1;
            
            if (item.Quality < 0)
                item.Quality = 0;
            if (item.Quality > 50)
                item.Quality = 50;
            
            item.SellIn--;
        }

        private void UpdateAsAgedBrie(Item item)
        {
            if (item.SellIn <= 0)
                item.Quality += 2;
            else
                item.Quality += 1;
            if (item.Quality < 0)
                item.Quality = 0;
            if (item.Quality > 50)
                item.Quality = 50;
            item.SellIn--;
        }

        private void UpdateAsRegular(Item item)
        {
            if (item.SellIn <= 0)
                item.Quality -= 2;
            else
                item.Quality -= 1;
            if (item.Quality < 0)
                item.Quality = 0;
            if (item.Quality > 50)
                item.Quality = 50;
            item.SellIn--;
        }

        private void UpdateAsSulfuras(Item item)
        {
            
        }
    }
}