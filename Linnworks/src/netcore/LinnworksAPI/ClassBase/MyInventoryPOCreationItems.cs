using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Object passed to the API to describe whether the item, on the base class, should be added to a new PO or an existing PO 
    /// </summary>
    public class MyInventoryPOCreationItems : LinnObject
	{
        /// <summary>
        /// Denotes item should be added to a new PO 
        /// </summary>
		public Boolean IsNew { get; set; }

        /// <summary>
        /// If this is populated with a valid PurchaseOrderId, the item will be added to that PO 
        /// </summary>
		public Guid PurchaseOrderId { get; set; }

        /// <summary>
        /// List of open order items to be bound to the PO item 
        /// </summary>
		public List<Guid> OpenOrderItemsBound { get; set; }

		public Guid StockItemId { get; set; }

		public Guid SupplierId { get; set; }

		public String SupplierName { get; set; }

		public Int32 OustandingPOQuantity { get; set; }

		public Int32 SuggestedReorderAmount { get; set; }

		public Int32 QuantityInDraftPOs { get; set; }

		public String ItemTitle { get; set; }

		public String SKU { get; set; }

		public String ImageURL { get; set; }

		public Boolean SupplierAssigned { get; set; }

		public POQuantityCalulationType CalculationMethod { get; set; }

		public String ErrorMessage { get; set; }

		public Boolean CanBeOrdered { get; set; }

		public POSuggestedReorderAmountError? ErrorCode { get; set; }

		public Int32 SupplierPackSize { get; set; }

		public Int32 MinimumOrderQuantity { get; set; }

		public Guid? RequestedSupplierId { get; set; }
	} 
}