using System;

namespace LinnworksAPI
{
    public class ScrapBatchedItemRequest
    {
        public ScrapItem ScrapItem;
        public Guid LocationId;
        public Int32 BatchInventoryId;
    }
}