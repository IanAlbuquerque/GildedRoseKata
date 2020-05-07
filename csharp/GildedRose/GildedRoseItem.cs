using System;
using csharp.ItemExtensions;

namespace csharp.GildedRose
{
    public abstract class GildedRoseItem
    {
        private readonly Item _item;

        protected int Quality
        {
            get => this._item.Quality;
            set
            {
                if (this._item.IsLegendary())
                    return;
                int newValue = value;
                newValue = Math.Min(newValue, Constants.MaxItemQuality);
                newValue = Math.Max(newValue, Constants.MinItemQuality);
                this._item.Quality = newValue;
            }
        }
        
        protected int SellIn
        {
            get => this._item.SellIn;
            set
            {
                if (this._item.IsLegendary())
                    return;
                this._item.SellIn = value;
            }
        }

        protected void DepleteItemQuality()
        {
            this._item.Quality = Constants.MinItemQuality;
        }

        protected GildedRoseItem(Item item)
        {
            this._item = item;
        }
        
        public virtual void UpdateQuality()
        {
            
        }
    }
}