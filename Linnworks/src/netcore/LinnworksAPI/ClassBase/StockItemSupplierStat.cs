using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemSupplierStat
	{
        /// <summary>
        /// If supplier information is default 
        /// </summary>
		public Boolean IsDefault { get; set; }

        /// <summary>
        /// Supplier name 
        /// </summary>
		public String Supplier { get; set; }

        /// <summary>
        /// Supplier ID 
        /// </summary>
		public Guid SupplierID { get; set; }

        /// <summary>
        /// Supplier code 
        /// </summary>
		public String Code { get; set; }

        /// <summary>
        /// Supplier barcode 
        /// </summary>
		public String SupplierBarcode { get; set; }

        /// <summary>
        /// Supplier lead time 
        /// </summary>
		public Int32 LeadTime { get; set; }

        /// <summary>
        /// Supplier purchase price 
        /// </summary>
		public Double PurchasePrice { get; set; }

        /// <summary>
        /// Minimum price 
        /// </summary>
		public Double MinPrice { get; set; }

        /// <summary>
        /// Maximum price 
        /// </summary>
		public Double MaxPrice { get; set; }

        /// <summary>
        /// Average price 
        /// </summary>
		public Double AveragePrice { get; set; }

        /// <summary>
        /// Average lead time 
        /// </summary>
		public Double AverageLeadTime { get; set; }

        /// <summary>
        /// Minimum order quantity from this supplier 
        /// </summary>
		public Int32 SupplierMinOrderQty { get; set; }

        /// <summary>
        /// Supplier pack size 
        /// </summary>
		public Int32 SupplierPackSize { get; set; }

        /// <summary>
        /// Supplier's default currency 
        /// </summary>
		public String SupplierCurrency { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}