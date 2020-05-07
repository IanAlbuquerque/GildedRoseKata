using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;
        private readonly QualityUpdater _updater;
        
        public GildedRose(IList<Item> items)
        {
            this._items = items;
            this._updater = new QualityUpdater();
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < this._items.Count; i++)
                this._updater.UpdateQualityOfItem(this._items[i]);
        }
    }
}
