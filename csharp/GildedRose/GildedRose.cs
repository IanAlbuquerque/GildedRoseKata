using System.Collections.Generic;
using csharp.Extensions;

namespace csharp.GildedRose
{
    public class GildedRose
    {
        private readonly IEnumerable<GildedRoseItem> _items;
        
        public GildedRose(IEnumerable<Item> items)
        {
            this._items = items.AsGildedRoseItemList();
        }

        public void UpdateQuality()
        {
            foreach (GildedRoseItem item in this._items)
                item.UpdateQuality();
        }
    }
}
