namespace csharp.ItemExtensions
{
    public static class ItemUpdateStrategiesExtensions
    {
        public static void UpdateAsBackstagePasses(this Item item)
        {
            if (item.SellIn <= 0)
                item.DepleteItemQuality();
            else if(item.SellIn <= 5)
                item.IncreaseQuality(3);
            else if (item.SellIn <= 10)
                item.IncreaseQuality(2);
            else
                item.IncreaseQuality(1);

            item.SellIn--;
        }

        public static void UpdateAsAgedBrie(this Item item)
        {
            if (item.SellIn <= 0)
                item.IncreaseQuality(2);
            else
                item.IncreaseQuality(1);
            
            item.SellIn--;
        }

        public static void UpdateAsRegularItem(this Item item)
        {
            if (item.SellIn <= 0)
                item.DecreaseQuality(2);
            else
                item.DecreaseQuality(1);
            
            item.SellIn--;
        }

        public static void UpdateAsLegendaryItem(this Item item)
        {
            
        }
    }
}