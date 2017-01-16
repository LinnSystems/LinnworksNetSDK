using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class OrderItemReturnInfo
    {
        public Guid fkOrderItemRowId;
        public Guid ParentRowId;
        public Int32 ReturnableQty;
        public Int32 OrderQty;
        public Int32 ReturnedQty;
        public String SKU;
        public String ItemTitle;
        public Double UnitValue;
        public Double TaxRate;
        public Boolean TaxCostInclusive;
        public String Currency;
        public Boolean IsCompositeParent;
        public Boolean IsPartialCompositeReturn;
        public Int32 ParentRatio;
        public List<OrderItemReturnInfo> ChildItems;
        public Guid? pkStockItemId;
        public Int32 ResentQty;
    }
}