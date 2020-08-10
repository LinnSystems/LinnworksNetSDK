using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemDuePO
	{
        /// <summary>
        /// Supplier name 
        /// </summary>
		public String SupplierName { get; set; }

        /// <summary>
        /// Stock location to be delivered to 
        /// </summary>
		public InventoryStockLocation Location { get; set; }

        /// <summary>
        /// Supplier ID 
        /// </summary>
		public Guid SupplierId { get; set; }

        /// <summary>
        /// Date of PO purchase 
        /// </summary>
		public DateTime DateOfPurchase { get; set; }

        /// <summary>
        /// PO delivery date 
        /// </summary>
		public DateTime QuotedDeliveryDate { get; set; }

        /// <summary>
        /// Quantity to be delived 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Delivered quantity 
        /// </summary>
		public Int32 Delivered { get; set; }

        /// <summary>
        /// Unit cost 
        /// </summary>
		public Double UnitCost { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}