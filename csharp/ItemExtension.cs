namespace csharp
{
    public static class ItemExtension
    {
        public static bool IsSulfuras(this Item item)
        {
            return item.Name == Constants.Sulfuras;
        }
        
        public static bool IsBackstagePasses(this Item item)
        {
            return item.Name == Constants.BackstagePasses;
        }
        
        public static bool IsAgedBrie(this Item item)
        {
            return item.Name == Constants.AgedBrie;
        }
    }
}