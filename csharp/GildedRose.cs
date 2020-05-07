using System.Collections.Generic;
using csharp.ItemExtensions;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;
        
        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < this._items.Count; i++)
                this._items[i].UpdateQuality();
        }
    }
}
