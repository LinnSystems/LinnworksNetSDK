using System;

namespace LinnworksAPI
{
    public class OrderRelation
    {
        public Int32 ChildOrderId;
        public Guid ChildOrderPkOrderId;
        public Int32 ParentOrderId;
        public Guid ParentOrderPkOrderId;
        public String RelationType;
    }
}