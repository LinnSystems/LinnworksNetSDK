using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ProcessOrderByOrderIdOrReferenceResponse
    {
        public OrderProcessedState ProcessedState;
        public String Message;
        public Object Response;
        public Guid OrderId;
        public OrderSummary OrderSummary;
        public List<OrderItem> Items;
        public List<StockItemBatch> BatchInformation;
    }
}