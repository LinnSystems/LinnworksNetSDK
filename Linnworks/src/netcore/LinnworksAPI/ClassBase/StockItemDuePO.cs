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
		public String SupplierName;

        /// <summary>
        /// Stock location to be delivered to 
        /// </summary>
		public StockLocation Location;

        /// <summary>
        /// Supplier ID 
        /// </summary>
		public Guid SupplierId;

        /// <summary>
        /// Date of PO purchase 
        /// </summary>
		public DateTime DateOfPurchase;

        /// <summary>
        /// PO delivery date 
        /// </summary>
		public DateTime QuotedDeliveryDate;

        /// <summary>
        /// Quantity to be delived 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Delivered quantity 
        /// </summary>
		public Int32 Delivered;

        /// <summary>
        /// Unit cost 
        /// </summary>
		public Double UnitCost;

		public Guid StockItemId;
	} 
}