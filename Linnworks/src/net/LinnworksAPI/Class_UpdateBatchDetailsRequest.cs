using System;

namespace LinnworksAPI
{
    public class UpdateBatchDetailsRequest
    {
        public Guid StockItemId;
        public Int32 InventoryTrackingType;
        public Boolean BatchNumberScanRequired;
    }
}