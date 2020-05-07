using csharp.Extensions;
using csharp.External;
using csharp.GildedRose.GildedRoseItems;

namespace csharp.GildedRose
{
    public static class GildedRoseItemFactory
    {
        public static GildedRoseItem CreateFrom(Item item)
        {
            if (item.IsLegendary())
                return new LegendaryItem(item);
            if (item.IsEventTicket())
                return new EventTicketItem(item);
            if (item.IsAged())
                return new AgedItem(item);
            if (item.IsConjured())
                return new ConjuredItem(item);
            
            return new RegularItem(item);
        }
    }
}