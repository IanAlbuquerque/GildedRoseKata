namespace csharp.ItemExtensions
{
    public static class ItemDifferentRoutinesByTypeExtensions
    {
        public static void UpdateQuality(this Item item)
        {
            if (item.IsLegendary())
                item.UpdateAsLegendaryItem();
            else if (item.IsBackstagePasses())
                item.UpdateAsBackstagePasses();
            else if (item.IsAgedBrie())
                item.UpdateAsAgedBrie();
            else
                item.UpdateAsRegularItem();
        }
    }
}