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
        public Double? RetailPrice;
        public Double? PurchasePrice;
        public String Barcode;
        public Int32 Available;
        public Int32 MinimumLevel;
        public Int32 InOrder;
        public Int32 StockLevel;
        public Double StockValue;
        public Int32 Due;
        public Boolean Tracked;
        public String BinRack;
        public Guid Category;
        public Boolean IsComposite;
        public String Image;
        public DateTime? CreatedDate;
        public DateTime? ModifiedDate;
        public Int32 TotalChangedProducts;
        public Boolean ContainsChanges;
    }
}