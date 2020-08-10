using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// comment class 
    /// </summary>
    public class OpenOrder
	{
		public String ORDER_NOT_FOUND_ERROR;

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 NumOrderId;

        /// <summary>
        /// General information about an order 
        /// </summary>
		public OrderGeneralInfo GeneralInfo;

        /// <summary>
        /// Order shipping information 
        /// </summary>
		public OrderShippingInfo ShippingInfo;

        /// <summary>
        /// Order customer information 
        /// </summary>
		public OrderCustomerInfo CustomerInfo;

        /// <summary>
        /// Linnworks order totals information 
        /// </summary>
		public OrderTotalsInfo TotalsInfo;

		public OrderTaxInfo TaxInfo;

        /// <summary>
        /// Folder name of an order if any assigned 
        /// </summary>
		public List<String> FolderName;

		public Boolean IsPostFilteredOut;

		public Boolean CanFulfil;

		public StockAllocationType StockAllocationType;

		public List<OrderItem> Items;

		public Boolean HasItems;

		public Int32 TotalItemsSum;

		public Guid OrderId;
	} 
}