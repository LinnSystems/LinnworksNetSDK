using System;

namespace LinnworksAPI
{
    public class StockItemChannelSKU
    {
        public Guid ChannelSKURowId;
        public String SKU;
        public String Source;
        public String SubSource;
        public String UpdateStatus;
        public String ChannelReferenceId;
        public DateTime LastUpdate;
        public Int32 MaxListedQuantity;
        public Int32 EndWhenStock;
        public Int32 SubmittedQuantity;
        public Int32 ListedQuantity;
        public Double StockPercentage;
        public Boolean IgnoreSync;
        public Boolean? IgnoreSyncMultiLocation;
        public Boolean IsMultiLocation;
        public Guid StockItemId;
    }
}