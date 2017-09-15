using System;

namespace LinnworksAPI
{
    public class StockItemChannelSKUWithLocation
    {
        public Guid fkRowId;
        public Int32 LocationId;
        public String LocationName;
        public Boolean? IgnoreSync;
        public Int32? MaxListedQuantity;
        public Int32? EndWhenStock;
        public Double? StockPercentage;
        public DateTime LastUpdate;
        public String UpdateStatus;
        public Int32 SubmittedQuantity;
        public Int32 ListedQuantity;
        public Int32 RetryCount;
        public Guid StockItemId;
    }
}