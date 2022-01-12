using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.ObjectModel;

namespace LinnworksAPI
{ 
    public class OrderItemIndicator
	{
		public ReadOnlyDictionary<SByte,PurchaseOrderState?> POStateMapping { get; set; }

		public ReadOnlyDictionary<SByte,FulfillmentState> FulfillmentStateMapping { get; set; }

		public SByte UnknownStock { get; set; }

		public SByte SufficientStock { get; set; }

		public Guid OrderItemId { get; set; }

		public Guid StockItemId { get; set; }

		public SByte Indicator { get; set; }

		public FulfillmentState FulfillmentState { get; set; }

		public PurchaseOrderState? PurchaseOrderState { get; set; }
	} 
}