using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderDetails
	{
        /// <summary>
        /// Order ID (pkOrderId) 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 NumOrderId { get; set; }

        /// <summary>
        /// If order is processed 
        /// </summary>
		public Boolean Processed { get; set; }

        /// <summary>
        /// Date and time when order was processed 
        /// </summary>
		public DateTime? ProcessedDateTime { get; set; }

        /// <summary>
        /// Location ID 
        /// </summary>
		public Guid FulfilmentLocationId { get; set; }

        /// <summary>
        /// General information about order 
        /// </summary>
		public OrderGeneralInfo GeneralInfo { get; set; }

        /// <summary>
        /// Order shipping information 
        /// </summary>
		public OrderShippingInfo ShippingInfo { get; set; }

        /// <summary>
        /// Order Customer information (Name, email etc) 
        /// </summary>
		public OrderCustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// Order totals information 
        /// </summary>
		public OrderTotalsInfo TotalsInfo { get; set; }

        /// <summary>
        /// Extended properties of an order 
        /// </summary>
		public List<ExtendedProperty> ExtendedProperties { get; set; }

        /// <summary>
        /// Folder names assigned to an order 
        /// </summary>
		public List<String> FolderName { get; set; }

        /// <summary>
        /// List of order items 
        /// </summary>
		public List<OrderItem> Items { get; set; }

        /// <summary>
        /// List of order notes 
        /// </summary>
		public List<OrderNote> Notes { get; set; }

        /// <summary>
        /// Date and time when the order was marked as paid 
        /// </summary>
		public DateTime? PaidDateTime { get; set; }

        /// <summary>
        /// Buyer's tax number. 
        /// </summary>
		public String TaxId { get; set; }
	} 
}