using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PurchaseOrderWithStockItem
    {
        public Guid StockItemId;
        public List<Guid> LocationIds;
    }
}