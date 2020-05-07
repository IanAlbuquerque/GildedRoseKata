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
        
        public static bool IsEventTicket(this Item item)
        {
            return item.IsBackstagePasses();
        }

        public static bool IsConjured(this Item item)
        {
            return item.IsConjuredManaCake();
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
        
        private static bool IsConjuredManaCake(this Item item)
        {
            return item.Name == Constants.ConjuredManaCake;
        }
        
        public static GildedRoseItem AsGildedRoseItem(this Item item)
        {
            return GildedRoseItemFactory.CreateFrom(item);
        }
    }
}