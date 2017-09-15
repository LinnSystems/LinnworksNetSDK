using System;

namespace LinnworksAPI
{
    public class GetInventoryItemBatchInformationRequest
    {
        public Guid StockItemId;
        public Guid? StockLocationId;
        public Boolean AvailableOnly;
    }
}