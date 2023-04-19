using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_PurchaseOrderItem_OpenOrdersResponse : LinnObject
	{
		public List<PurchaseOrderItemOpenOrder> OpenOrders { get; set; }
	} 
}