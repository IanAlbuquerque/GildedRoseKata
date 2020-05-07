using csharp.GildedRose.GildedRoseItems;
using csharp.ItemExtensions;

namespace csharp.GildedRose
{
    public static class GildedRoseItemFactory
    {
        public static GildedRoseItem CreateFrom(Item item)
        {
            if (item.IsLegendary())
                return new LegendaryItem(item);
            if (item.IsBackstagePasses())
                return new BackstagePasses(item);
            if (item.IsAgedBrie())
                return new AgedBrie(item);
            
            return new RegularItem(item);
        }
    }
}