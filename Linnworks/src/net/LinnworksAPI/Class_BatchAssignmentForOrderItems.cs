using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class BatchAssignmentForOrderItems
    {
        public Guid orderId;
        public List<batchAssignment> batchToItemMapping;
    }
}