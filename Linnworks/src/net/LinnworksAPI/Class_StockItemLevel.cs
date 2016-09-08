using System;

namespace LinnworksAPI
{
    public class StockItemLevel
    {
        public StockLocation Location;
        public Int32 StockLevel;
        public Double StockValue;
        public Int32 MinimumLevel;
        public Int32 InOrderBook;
        public Int32 Due;
        public Int32 InOrders;
        public Int32 Available;
        public Double UnitCost;
        public String SKU;
        public Boolean AutoAdjust;
        public DateTime LastUpdateDate;
        public String LastUpdateOperation;
        public Guid rowid;
        public Boolean PendingUpdate;
        public Guid StockItemId;
    }
}