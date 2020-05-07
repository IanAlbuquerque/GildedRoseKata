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
                this.ZeroOutQuality(item);
            else if(item.SellIn <= 5)
                this.IncreaseQuality(item, 3);
            else if (item.SellIn <= 10)
                this.IncreaseQuality(item, 2);
            else
                this.IncreaseQuality(item, 1);

            item.SellIn--;
        }

        private void UpdateAsAgedBrie(Item item)
        {
            if (item.SellIn <= 0)
                this.IncreaseQuality(item, 2);
            else
                this.IncreaseQuality(item, 1);
            
            item.SellIn--;
        }

        private void UpdateAsRegular(Item item)
        {
            if (item.SellIn <= 0)
                this.DecreaseQuality(item, 2);
            else
                this.DecreaseQuality(item, 1);
            
            item.SellIn--;
        }

        private void UpdateAsSulfuras(Item item)
        {
            
        }
        
        private void IncreaseQuality(Item item, int value)
        {
            int newQuality = item.Quality + value;
            if (newQuality > 50)
                newQuality = 50;
            item.Quality = newQuality;
        }
        
                
        private void DecreaseQuality(Item item, int value)
        {
            int newQuality = item.Quality - value;
            if (newQuality < 0)
                newQuality = 0;
            item.Quality = newQuality;
        }
        
        
        private void ZeroOutQuality(Item item)
        {
            item.Quality = 0;
        }
    }
}