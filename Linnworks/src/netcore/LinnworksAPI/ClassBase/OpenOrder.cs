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
        /// Order ID (pkOrderID) 
        /// </summary>
		public Guid OrderId;

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

        /// <summary>
        /// Folder name of an order if any assigned 
        /// </summary>
		public List<String> FolderName;

        /// <summary>
        /// List of order items 
        /// </summary>
		public List<OrderItem> Items;
	} 
}