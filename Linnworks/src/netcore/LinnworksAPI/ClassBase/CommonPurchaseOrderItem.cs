using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CommonPurchaseOrderItem : LinnObject
	{
		public Guid pkPurchaseItemId { get; set; }

		public Guid fkStockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }

		public Int32 Quantity { get; set; }

		public Decimal Cost { get; set; }

		public Int32 Delivered { get; set; }

		public Decimal TaxRate { get; set; }

		public Decimal Tax { get; set; }

		public Int32 PackQuantity { get; set; }

		public Int32 PackSize { get; set; }

		public String SKU { get; set; }

		public String ItemTitle { get; set; }

		public Int32 InventoryTrackingType { get; set; }

		public Boolean IsDeleted { get; set; }

		public Int32 SortOrder { get; set; }

		public Decimal DimHeight { get; set; }

		public Decimal DimWidth { get; set; }

		public String BarcodeNumber { get; set; }

		public Decimal DimDepth { get; set; }

		public Int32 BoundToOpenOrdersItems { get; set; }

		public String BinRack { get; set; }

		public Int32 QuantityBoundToOpenOrdersItems { get; set; }

		public String SupplierCode { get; set; }

		public String SupplierBarcode { get; set; }

		public List<Int32> SkuGroupIds { get; set; }
	} 
}