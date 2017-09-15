using System;

namespace LinnworksAPI
{
    public class BatchedBookIn
    {
        public String SKU;
        public String BatchNumber;
        public Guid LocationId;
        public String BinRack;
        public Int32 Quantity;
        public Decimal StockValue;
        public String BatchStatus;
        public Int16? PrioritySequence;
        public DateTime? ExpiresOn;
        public DateTime? SellBy;
    }
}