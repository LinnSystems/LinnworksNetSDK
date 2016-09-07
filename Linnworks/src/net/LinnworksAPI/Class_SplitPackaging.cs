using System;

namespace LinnworksAPI
{
    public class SplitPackaging
    {
        public Int32 BinIndex;
        public String ItemTitle;
        public String PackageTitle;
        public Guid pkBinId;
        public Guid fkOrderItemRowId;
        public Int32 Quantity;
        public String SKU;
        public String TrackingNumber;
        public Double Weight;
    }
}