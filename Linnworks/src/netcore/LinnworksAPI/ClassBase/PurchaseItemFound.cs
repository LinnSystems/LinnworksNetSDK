using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PurchaseItemFound
	{
		public Guid pkStockItemId;

		public String ItemNumber;

		public String ItemTitle;

		public Int32 InventoryTrackingType;

		public Decimal TaxRate;

		public Decimal PurchasePrice;

		public Decimal? KnownPurchasePrice;

		public String SupplierCode;

		public Guid? fkSupplierId;

		public Int32? SupplierMinOrderQty;

		public Int32? SupplierPackSize;

		public Boolean ContainsComposites;

		public Int32 StockItemIntId;
	} 
}