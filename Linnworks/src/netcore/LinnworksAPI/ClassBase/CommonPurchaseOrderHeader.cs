using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CommonPurchaseOrderHeader : LinnObject
	{
		public Guid pkPurchaseID { get; set; }

		public Guid fkSupplierId { get; set; }

		public Guid fkLocationId { get; set; }

		public String ExternalInvoiceNumber { get; set; }

		public PurchaseOrderStatus Status { get; set; }

		public String Currency { get; set; }

		public String SupplierReferenceNumber { get; set; }

		public Boolean Locked { get; set; }

		public Int32 LineCount { get; set; }

		public Int32 DeliveredLinesCount { get; set; }

		public Int32 UnitAmountTaxIncludedType { get; set; }

		public DateTime DateOfPurchase { get; set; }

		public DateTime DateOfDelivery { get; set; }

		public DateTime QuotedDeliveryDate { get; set; }

		public Decimal PostagePaid { get; set; }

		public Decimal TotalCost { get; set; }

		public Decimal taxPaid { get; set; }

		public Decimal ShippingTaxRate { get; set; }

		public Decimal ConversionRate { get; set; }

		public Decimal ConvertedShippingCost { get; set; }

		public Decimal ConvertedShippingTax { get; set; }

		public Decimal ConvertedOtherCost { get; set; }

		public Decimal ConvertedOtherTax { get; set; }

		public Decimal ConvertedGrandTotal { get; set; }
	} 
}