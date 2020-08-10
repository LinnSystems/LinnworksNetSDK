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
		public Boolean IsDefault;

        /// <summary>
        /// Supplier name 
        /// </summary>
		public String Supplier;

        /// <summary>
        /// Supplier ID 
        /// </summary>
		public Guid SupplierID;

        /// <summary>
        /// Supplier code 
        /// </summary>
		public String Code;

        /// <summary>
        /// Supplier barcode 
        /// </summary>
		public String SupplierBarcode;

        /// <summary>
        /// Supplier lead time 
        /// </summary>
		public Int32 LeadTime;

        /// <summary>
        /// Supplier purchase price 
        /// </summary>
		public Double PurchasePrice;

        /// <summary>
        /// Minimum price 
        /// </summary>
		public Double MinPrice;

        /// <summary>
        /// Maximum price 
        /// </summary>
		public Double MaxPrice;

        /// <summary>
        /// Average price 
        /// </summary>
		public Double AveragePrice;

        /// <summary>
        /// Average lead time 
        /// </summary>
		public Double AverageLeadTime;

        /// <summary>
        /// Minimum order quantity from this supplier 
        /// </summary>
		public Int32 SupplierMinOrderQty;

        /// <summary>
        /// Supplier pack size 
        /// </summary>
		public Int32 SupplierPackSize;

        /// <summary>
        /// Supplier's default currency 
        /// </summary>
		public String SupplierCurrency;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}