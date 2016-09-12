using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    [Serializable]
    public class OpenOrder
    {
        public String ORDER_NOT_FOUND_ERROR;
        public Guid OrderId;
        public Int32 NumOrderId;
        public OrderGeneralInfo GeneralInfo;
        public OrderShippingInfo ShippingInfo;
        public OrderCustomerInfo CustomerInfo;
        public OrderTotalsInfo TotalsInfo;
        public List<String> FolderName;
        public List<OrderItem> Items;
    }
}