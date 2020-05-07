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
                this._item.Quality = value.Clamped(0, Constants.MaxItemQuality);
            }
        }
        
        protected int SellIn
        {
            get => this._item.SellIn;
            private set
            {
                if (this._item.IsLegendary())
                    return;
                this._item.SellIn = value;
            }
        }
        
        public void TickDay()
        {
            this.UpdateQuality();
            this.SellIn--;
        }

        protected bool IsPastSellInDate => this.SellIn <= 0;

        protected GildedRoseItem(Item item)
        {
            this._item = item;
        }

        protected virtual void UpdateQuality()
        {
            
        }
    }
}