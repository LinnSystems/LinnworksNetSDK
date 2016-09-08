using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class OrderItem
    {
        public Guid OrderId;
        public Guid ItemId;
        public Guid StockItemId;
        public String ItemNumber;
        public String SKU;
        public String ItemSource;
        public String Title;
        public Int32 Quantity;
        public String CategoryName;
        public Int32? CompositeAvailablity;
        public Guid RowId;
        public Boolean StockLevelsSpecified;
        public Int32 OnOrder;
        public Int32? InOrderBook;
        public Int32 Level;
        public Int32? MinimumLevel;
        public Int32 AvailableStock;
        public Double PricePerUnit;
        public Double UnitCost;
        public Double Discount;
        public Double Tax;
        public Double TaxRate;
        public Double Cost;
        public Double CostIncTax;
        public List<OrderItem> CompositeSubItems;
        public Boolean IsService;
        public Double SalesTax;
        public Boolean TaxCostInclusive;
        public Boolean PartShipped;
        public Double Weight;
        public String BarcodeNumber;
        public Int32 Market;
        public String ChannelSKU;
        public String ChannelTitle;
        public Boolean HasImage;
        public Guid? ImageId;
        public List<OrderItemOption> AdditionalInfo;
        public Int32 StockLevelIndicator;
        public String BinRack;
    }
}