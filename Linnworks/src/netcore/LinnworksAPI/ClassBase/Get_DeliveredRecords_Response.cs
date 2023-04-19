using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_DeliveredRecords_Response : LinnObject
	{
		public List<PurchaseOrderDeliveredRecord> Items { get; set; }
	} 
}