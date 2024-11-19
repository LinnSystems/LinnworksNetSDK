using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PurchaseOrderResponse : LinnObject
	{
		public Int32 NoteCount { get; set; }

		public PurchaseOrderHeader PurchaseOrderHeader { get; set; }

		public List<PurchaseOrderItem> PurchaseOrderItem { get; set; }

		public List<PurchaseOrderAdditionalCost> AdditionalCosts { get; set; }

		public List<PurchaseOrderPaymentStatement> PaymentStatements { get; set; }

		public List<PurchaseOrderDeliveredRecord> DeliveredRecords { get; set; }
	} 
}