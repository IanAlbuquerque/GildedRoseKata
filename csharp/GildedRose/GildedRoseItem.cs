using csharp.Extensions;
using csharp.External;

namespace csharp.GildedRose
{
    public abstract class GildedRoseItem
    {
        private readonly Item _item;
        
        protected GildedRoseItem(Item item)
        {
            this._item = item;
        }

        public virtual void UpdateQuality()
        {
        }
        
        protected int Quality
        {
            get => this._item.Quality;
            set => this._item.Quality = value.Clamped(0, Constants.MaxItemQuality);
        }
        
        protected int SellIn
        {
            get => this._item.SellIn;
            set => this._item.SellIn = value;
        }
        
        protected bool IsPastSellInDate => this.SellIn <= 0;
    }
}