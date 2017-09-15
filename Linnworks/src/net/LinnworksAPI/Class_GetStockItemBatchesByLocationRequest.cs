using System;

namespace LinnworksAPI
{
    public class GetStockItemBatchesByLocationRequest
    {
        public Guid StockItemId;
        public Guid LocationId;
        public Boolean OnlyAvailable;
    }
}