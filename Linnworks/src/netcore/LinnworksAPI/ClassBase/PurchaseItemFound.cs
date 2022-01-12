using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PurchaseItemFound
	{
		public Guid pkStockItemId { get; set; }

		public String ItemNumber { get; set; }

		public String ItemTitle { get; set; }

		public Int32 InventoryTrackingType { get; set; }

		public Decimal TaxRate { get; set; }

		public Decimal PurchasePrice { get; set; }

		public Decimal? KnownPurchasePrice { get; set; }

		public String SupplierCode { get; set; }

		public String SupplierBarcode { get; set; }

		public Guid? fkSupplierId { get; set; }

		public Int32? SupplierMinOrderQty { get; set; }

		public Int32? SupplierPackSize { get; set; }

		public Boolean ContainsComposites { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}