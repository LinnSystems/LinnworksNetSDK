using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Add_PurchaseOrderExtendedPropertyRequest
    {
        public Guid PurchaseId;
        public List<Add_PurchaseOrderExtendedProperty_Item> ExtendedPropertyItems;
    }
}