using System;
using csharp.Extensions;

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
                this._item.Quality = value.Clamped(Constants.MinItemQuality, Constants.MaxItemQuality);
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