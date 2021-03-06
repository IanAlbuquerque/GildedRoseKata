﻿using System.Collections.Generic;
using csharp.External;
using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTests
    {
        [Test]
        public void Given_RegularItem_Should_DecreaseSellInAndQuality()
        {
            IList<Item> items = ListWithItem("foo", 2, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("foo", items[0].Name);
            Assert.AreEqual(1, items[0].SellIn);
            Assert.AreEqual(1, items[0].Quality);
        }
        
        [Test]
        public void Given_RegularItem_Should_NotDecreaseQualityBelowZero()
        {
            IList<Item> items = ListWithItem("foo", 5, 1);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test]
        public void Given_RegularItem_Should_DecreaseQualityTwiceAfterSellIn()
        {
            IList<Item> items = ListWithItem("foo", 0, 10);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(8, items[0].Quality);
        }
        
        [Test]
        public void Given_RegularItem_Should_DecreaseQualityOnceWhenSellInIsOne()
        {
            IList<Item> items = ListWithItem("foo", 1, 10);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(9, items[0].Quality);
        }
        
        [Test]
        public void Given_AgedBrie_Should_IncreaseQualityAfterUpdate()
        {
            IList<Item> items = ListWithItem("Aged Brie", 2, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(3, items[0].Quality);
        }
        
        [Test]
        public void Given_AgedBrie_Should_IncreaseQualityTwiceAfterSellIn()
        {
            IList<Item> items = ListWithItem("Aged Brie", 0, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].Quality);
        }
        
        [Test]
        public void Given_AgedBrie_Should_NotPass50Quality()
        {
            IList<Item> items = ListWithItem("Aged Brie", 10, 50);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test]
        public void Given_Sulfuras_Should_KeepQuality80()
        {
            IList<Item> items = ListWithItem("Sulfuras, Hand of Ragnaros", 10, 80);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
        }
        
        [Test]
        public void Given_Sulfuras_Should_KeepSellIn()
        {
            IList<Item> items = ListWithItem("Sulfuras, Hand of Ragnaros", 10, 80);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(10, items[0].SellIn);
        }
        
        [Test]
        public void Given_Sulfuras_Should_KeepSellAndQualityEvenWhenAfterSellIn()
        {
            IList<Item> items = ListWithItem("Sulfuras, Hand of Ragnaros", 0, 80);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
        }
        
        [Test]
        public void Given_BackstagePasses_Should_IncreaseInQuality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 50, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(3, items[0].Quality);
        }
        
        [Test]
        public void Given_BackstagePasses_WithSellIn10_Should_Increase2InQuality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 10, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].Quality);
        }
        
        [Test]
        public void Given_BackstagePasses_WithSellIn6_Should_Increase2InQuality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 6, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].Quality);
        }
        
        [Test]
        public void Given_BackstagePasses_WithSellIn5_Should_Increase3InQuality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 5, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].Quality);
        }
        
        [Test]
        public void Given_BackstagePasses_WithSellIn1_Should_Increase3InQuality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 1, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].Quality);
        }
        
                
        [Test]
        public void Given_BackstagePasses_WithSellIn0_Should_DropToZeroQuality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 0, 2);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test]
        public void Given_BackstagePasses_WithRegularSellIn_Should_NotPass50Quality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 99, 50);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test]
        public void Given_BackstagePasses_WithDoubleSellIn_Should_NotPass50Quality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 9, 49);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test]
        public void Given_BackstagePasses_WithTripleSellIn_Should_NotPass50Quality()
        {
            IList<Item> items = ListWithItem("Backstage passes to a TAFKAL80ETC concert", 4, 48);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test]
        public void Given_ConjuredItem_Should_DegradeInQualityTwiceAsFastRegularly()
        {
            IList<Item> items = ListWithItem("Conjured Mana Cake", 4, 10);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(8, items[0].Quality);
        }
        
        [Test]
        public void Given_ConjuredItem_Should_DegradeInQualityTwiceAsFastAlsoPastSellIn()
        {
            IList<Item> items = ListWithItem("Conjured Mana Cake", 0, 10);
            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(6, items[0].Quality);
        }

        private static IList<Item> ListWithItem(string name, int sellIn, int quality)
        {
            IList<Item> list = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            return list;
        }
    }
}
