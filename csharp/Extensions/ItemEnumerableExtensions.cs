using System.Collections.Generic;
using csharp.External;
using csharp.GildedRose;

namespace csharp.Extensions
{
    public static class ItemEnumerableExtensions
    {
        public static IEnumerable<GildedRoseItem> AsGildedRoseItemList(this IEnumerable<Item> list)
        {
            List<GildedRoseItem> transformedList = new List<GildedRoseItem>();
            foreach (Item item in list)
                transformedList.Add(item.AsGildedRoseItem());
            return transformedList;
        }
    }
}