using System.Collections.Generic;
using csharp.Extensions;

namespace csharp.GildedRose
{
    public class GildedRose
    {
        private readonly IList<GildedRoseItem> _items;
        
        public GildedRose(IList<Item> items)
        {
            this._items = new List<GildedRoseItem>();
            for (int i = 0; i < items.Count; i++)
                this._items.Add(items[i].AsGildedRoseItem());
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < this._items.Count; i++)
                this._items[i].TickDay();
        }
    }
}
