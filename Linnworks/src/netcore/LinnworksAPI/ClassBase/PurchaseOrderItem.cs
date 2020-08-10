using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents purchase order item. 
    /// </summary>
    public class PurchaseOrderItem
	{
        /// <summary>
        /// Unique record identifier. Use this id to update quantity, cost, deliver item etc 
        /// </summary>
		public Guid pkPurchaseItemId { get; set; }

        /// <summary>
        /// Unique system stock identifier. Use this id to query linnworks api for product information, stock levels etc 
        /// </summary>
		public Guid fkStockItemId { get; set; }

        /// <summary>
        /// Unique system stock integer identifier. Use this id to query linnworks api for product information, stock levels etc 
        /// </summary>
		public Int32 StockItemIntId { get; set; }

        /// <summary>
        /// Quantity of unique stock items ordered 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Line Total cost of all the purchase order item inclusive of tax (unitcost * qty) + tax 
        /// </summary>
		public Decimal Cost { get; set; }

        /// <summary>
        /// Number of items delivered on the PO. If this number is more than 1, purchase order item cannot be deleted from the PO. Cannot be decreased. 
        /// </summary>
		public Int32 Delivered { get; set; }

        /// <summary>
        /// Tax rate as a whole number, for example 20 represents 20% 
        /// </summary>
		public Decimal TaxRate { get; set; }

        /// <summary>
        /// Tax calculated from Cost * (TaxRate/100) 
        /// </summary>
		public Decimal Tax { get; set; }

        /// <summary>
        /// Arbitary identifier of how many packs ordered. Number not used in any of the calculation and purely for visualization and minimum reorder quantity purposes only 
        /// </summary>
		public Int32 PackQuantity { get; set; }

        /// <summary>
        /// Arbitary identifier of how many items in each pack. Number not used in any of the calculation and purely for visualization and minimum reorder quantity purposes only 
        /// </summary>
		public Int32 PackSize { get; set; }

        /// <summary>
        /// Item SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Item Title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Stock item tracking type. 0 = none. 1 = Ordered by Sell by Date. 2 = Ordered by Priority Sequence 
        /// </summary>
		public Int32 InventoryTrackingType { get; set; }

        /// <summary>
        /// Whether or not the stock item for this purchase order item has been deleted in the system 
        /// </summary>
		public Boolean IsDeleted { get; set; }

        /// <summary>
        /// Order the item was added to PO. First item = 0 
        /// </summary>
		public Int32 SortOrder { get; set; }

        /// <summary>
        /// Item height 
        /// </summary>
		public Decimal DimHeight { get; set; }

        /// <summary>
        /// Item Width 
        /// </summary>
		public Decimal DimWidth { get; set; }

        /// <summary>
        /// Barcode 
        /// </summary>
		public String BarcodeNumber { get; set; }

        /// <summary>
        /// Item Depth 
        /// </summary>
		public Decimal DimDepth { get; set; }

        /// <summary>
        /// Number of open order items this item is bound 
        /// </summary>
		public Int32 BoundToOpenOrdersItems { get; set; }

        /// <summary>
        /// Bin rack 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// Sum of quantity of items bound to open order items 
        /// </summary>
		public Int32 QuantityBoundToOpenOrdersItems { get; set; }

        /// <summary>
        /// Supplier Code 
        /// </summary>
		public String SupplierCode { get; set; }

		public String SupplierBarcode { get; set; }

        /// <summary>
        /// Sku group id assocaited with purchase item. Used for containerisation. 
        /// </summary>
		public List<Int32> SkuGroupIds { get; set; }
	} 
}