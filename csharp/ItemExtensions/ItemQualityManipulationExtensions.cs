using System;

namespace csharp.ItemExtensions
{
    public static class ItemQualityManipulationExtensions
    {
        public static void IncreaseQuality(this Item item, int value)
        {
            item.Quality = Math.Min(item.Quality + value, Constants.MaxItemQuality);
        }


        public static void DecreaseQuality(this Item item, int value)
        {
            item.Quality = Math.Max(item.Quality - value, Constants.MinItemQuality);
        }
        
        
        public static void DepleteItemQuality(this Item item)
        {
            item.Quality = Constants.MinItemQuality;
        }
    }
}