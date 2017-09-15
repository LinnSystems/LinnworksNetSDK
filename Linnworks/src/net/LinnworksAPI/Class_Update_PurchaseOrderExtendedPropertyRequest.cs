using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Update_PurchaseOrderExtendedPropertyRequest
    {
        public Guid PurchaseId;
        public List<Update_PurchaseOrderExtendedPropertyItem> ExtendedPropertyItems;
    }
}