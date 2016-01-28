using System;

namespace LinnworksAPI
{
    public class StockItemLevel
    {
        public StockLocation Location;
        public Int32 StockLevel;
        public Int32 InOrders;
        public Int32 Available;
        public Int32 Due;
        public Double UnitCost;
        public Guid StockItemId;
    }
}