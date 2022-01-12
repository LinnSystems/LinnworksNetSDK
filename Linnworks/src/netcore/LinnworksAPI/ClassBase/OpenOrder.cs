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
		public String ORDER_NOT_FOUND_ERROR { get; set; }

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 NumOrderId { get; set; }

        /// <summary>
        /// General information about an order 
        /// </summary>
		public OrderGeneralInfo GeneralInfo { get; set; }

        /// <summary>
        /// Order shipping information 
        /// </summary>
		public OrderShippingInfo ShippingInfo { get; set; }

        /// <summary>
        /// Order customer information 
        /// </summary>
		public OrderCustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// Linnworks order totals information 
        /// </summary>
		public OrderTotalsInfo TotalsInfo { get; set; }

		public OrderTaxInfo TaxInfo { get; set; }

        /// <summary>
        /// Folder name of an order if any assigned 
        /// </summary>
		public List<String> FolderName { get; set; }

		public Boolean IsPostFilteredOut { get; set; }

		public Boolean CanFulfil { get; set; }

		public OrderFulfillmentState Fulfillment { get; set; }

		public List<OrderItem> Items { get; set; }

		public Boolean HasItems { get; set; }

		public Int32 TotalItemsSum { get; set; }

		public Guid OrderId { get; set; }
	} 
}