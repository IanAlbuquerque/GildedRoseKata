using System.Collections.Generic;

namespace csharp.GildedRose
{
    public class GildedRose
    {
        private readonly IList<GildedRoseItem> _items;
        
        public GildedRose(IList<Item> items)
        {
            this._items = new List<GildedRoseItem>();
            for (int i = 0; i < items.Count; i++)
            {
                GildedRoseItem gildedRoseItem = GildedRoseItemFactory.CreateFrom(items[i]);
                this._items.Add(gildedRoseItem);
            }
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < this._items.Count; i++)
                this._items[i].UpdateQuality();
        }
    }
}
