using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class InventoryItem
    {
        public Dictionary<String, ChannelDetails> Channels;
        public Guid Id;
        public String SKU;
        public String Title;
        public Double RetailPrice;
        public Double PurchasePrice;
        public String Barcode;
        public Int32 AvailableQuantity;
        public Int32 InStockQuantity;
        public Int32 MinimumLevelQuantity;
        public Int32 InOrderQuantity;
        public Int32 StockLevel;
        public Int32 Due;
        public String BinRack;
        public Guid Category;
        public String Name;
        public Int32 TotalChangedProducts;
        public Boolean ContainsChanges;
    }
}