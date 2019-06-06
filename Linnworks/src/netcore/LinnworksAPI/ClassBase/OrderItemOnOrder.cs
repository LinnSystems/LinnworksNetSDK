using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemOnOrder
	{
        /// <summary>
        /// Primary key of the bound 
        /// </summary>
		public Guid pkPurchaseItemId;

		public Guid Rowid;

		public Guid pkPurchaseId;

		public String ExternalInvoiceNumber;

		public Guid fkSupplierId;

		public DateTime DateOfDelivery;

		public DateTime QuotedDeliveryDate;

		public String SupplierName;

		public Guid fkLocationId;
	} 
}