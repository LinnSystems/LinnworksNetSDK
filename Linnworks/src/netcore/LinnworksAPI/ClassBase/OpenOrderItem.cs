using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Open Order Item - Low fidelity 
    /// </summary>
    public class OpenOrderItem : LinnObject
	{
		public List<OrderItemBase> CompositeChild { get; set; }

		public List<ProductIdentifier> ProductIdentifiers { get; set; }

		public Boolean ContainsComposites { get; set; }

		public Guid StockItemId { get; set; }

		public String SKU { get; set; }

		public String BarcodeNumber { get; set; }

		public String ItemTitle { get; set; }

		public Int32 Quantity { get; set; }
	} 
}