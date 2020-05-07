using csharp.GildedRose;

namespace csharp.Extensions
{
    public static class ItemExtensions
    {
        public static bool IsLegendary(this Item item)
        {
            return item.IsSulfuras();
        }
        
        public static bool IsAged(this Item item)
        {
            return item.IsAgedBrie();
        }
        
        public static bool IsEventPass(this Item item)
        {
            return item.IsBackstagePasses();
        }
        
        private static bool IsSulfuras(this Item item)
        {
            return item.Name == Constants.Sulfuras;
        }
        
        private static bool IsBackstagePasses(this Item item)
        {
            return item.Name == Constants.BackstagePasses;
        }
        
        private static bool IsAgedBrie(this Item item)
        {
            return item.Name == Constants.AgedBrie;
        }
        
        public static GildedRoseItem AsGildedRoseItem(this Item item)
        {
            return GildedRoseItemFactory.CreateFrom(item);
        }
    }
}