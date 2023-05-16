using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreatePOsFromInventoryResponse : LinnObject
	{
        /// <summary>
        /// A dictionary where the key is supplier Id and the tuple represents the purchase order id and the external invoice number for that PO 
        /// </summary>
		public Dictionary<Guid,Tuple<Guid,String>> PurchaseOrders { get; set; }

		public List<Guid> SkippedStockItems { get; set; }
	} 
}