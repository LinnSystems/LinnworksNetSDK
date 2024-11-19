using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Channel order item 
    /// </summary>
    public class ChannelOrderItem : LinnObject
	{
		public Boolean TaxCostInclusive { get; set; }

        /// <summary>
        /// Validate if the tax should be overwritten on the order item. 
        /// </summary>
		public Boolean UseChannelTax { get; set; }

        /// <summary>
        /// Individual price of the item 
        /// </summary>
		public Double PricePerUnit { get; set; }

        /// <summary>
        /// Postal service cost after discount 
        /// </summary>
		public Double PostalServiceCost { get; set; }

        /// <summary>
        /// Quantity customer ordered 
        /// </summary>
		public Int32 Qty { get; set; }

        /// <summary>
        /// Tax Rate as a whole number eg. 20 
        /// </summary>
		public Double TaxRate { get; set; }

        /// <summary>
        /// Discount percentage on the line as a whole number eg. 10 
        /// </summary>
		public Double LineDiscount { get; set; }

        /// <summary>
        /// The refund amount applied on the line, excluding shipping charges 
        /// </summary>
		public Decimal LineRefund { get; set; }

        /// <summary>
        /// The quantity of items refunded (can be decimalised) 
        /// </summary>
		public Decimal RefundQuantity { get; set; }

        /// <summary>
        /// The shipping refund for this line (if known) 
        /// </summary>
		public Decimal ShippingRefund { get; set; }

        /// <summary>
        /// The total refund amount applied on the line-level, including any shipping charges 
        /// </summary>
		public Decimal TotalRefund { get; set; }

        /// <summary>
        /// Unique line number 
        /// </summary>
		public String ItemNumber { get; set; }

		public String ChannelReferenceId { get; set; }

        /// <summary>
        /// SKU of the item ordered on the channel 
        /// </summary>
		public String ChannelSKU { get; set; }

		public Boolean IsService { get; set; }

        /// <summary>
        /// Title of the item ordered, or service name 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Options on the item ordered 
        /// </summary>
		public List<ChannelOrderItemOption> Options { get; set; }

		public List<ChannelOrderItemTax> Taxes { get; set; }
	} 
}