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
		public Guid pkPurchaseItemId { get; set; }

		public Guid Rowid { get; set; }

		public Guid pkPurchaseId { get; set; }

		public String ExternalInvoiceNumber { get; set; }

		public Guid fkSupplierId { get; set; }

		public DateTime DateOfDelivery { get; set; }

		public DateTime QuotedDeliveryDate { get; set; }

		public String SupplierName { get; set; }

		public Guid fkLocationId { get; set; }
	} 
}