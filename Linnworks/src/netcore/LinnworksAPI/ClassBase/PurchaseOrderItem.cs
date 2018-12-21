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
		public Guid pkPurchaseItemId;

        /// <summary>
        /// Unique system stock identifier. Use this id to query linnworks api for product information, stock levels etc 
        /// </summary>
		public Guid fkStockItemId;

        /// <summary>
        /// Quantity of unique stock items ordered 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Line Total cost of all the purchase order item inclusive of tax (unitcost * qty) + tax 
        /// </summary>
		public Decimal Cost;

        /// <summary>
        /// Number of items delivered on the PO. If this number is more than 1, purchase order item cannot be deleted from the PO. Cannot be decreased. 
        /// </summary>
		public Int32 Delivered;

        /// <summary>
        /// Tax rate as a whole number, for example 20 represents 20% 
        /// </summary>
		public Decimal TaxRate;

        /// <summary>
        /// Tax calculated from Cost * (TaxRate/100) 
        /// </summary>
		public Decimal Tax;

        /// <summary>
        /// Arbitary identifier of how many packs ordered. Number not used in any of the calculation and purely for visualization and minimum reorder quantity purposes only 
        /// </summary>
		public Int32 PackQuantity;

        /// <summary>
        /// Arbitary identifier of how many items in each pack. Number not used in any of the calculation and purely for visualization and minimum reorder quantity purposes only 
        /// </summary>
		public Int32 PackSize;

        /// <summary>
        /// Item SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Item Title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Stock item tracking type. 0 = none. 1 = Ordered by Sell by Date. 2 = Ordered by Priority Sequence 
        /// </summary>
		public Int32 InventoryTrackingType;

        /// <summary>
        /// Whether or not the stock item for this purchase order item has been deleted in the system 
        /// </summary>
		public Boolean IsDeleted;

        /// <summary>
        /// Order the item was added to PO. First item = 0 
        /// </summary>
		public Int32 SortOrder;

        /// <summary>
        /// Item height 
        /// </summary>
		public Decimal DimHeight;

        /// <summary>
        /// Item Width 
        /// </summary>
		public Decimal DimWidth;

        /// <summary>
        /// Item Depth 
        /// </summary>
		public Decimal DimDepth;
	} 
}