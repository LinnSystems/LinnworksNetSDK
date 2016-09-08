using System;

namespace LinnworksAPI
{
    public class StockLevelUpdate
    {
        public String SKU;
        public Guid LocationId;
        public Int32 Level;
    }
}