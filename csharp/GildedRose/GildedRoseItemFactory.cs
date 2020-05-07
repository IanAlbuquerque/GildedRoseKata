using csharp.Extensions;
using csharp.GildedRose.GildedRoseItems;

namespace csharp.GildedRose
{
    public static class GildedRoseItemFactory
    {
        public static GildedRoseItem CreateFrom(Item item)
        {
            if (item.IsLegendary())
                return new LegendaryItem(item);
            if (item.IsEventPass())
                return new EventPassItem(item);
            if (item.IsAged())
                return new AgedItem(item);
            
            return new RegularItem(item);
        }
    }
}