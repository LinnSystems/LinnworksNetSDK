using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Channel order item 
    /// </summary>
    public class ChannelOrderItem
	{
		public Boolean TaxCostInclusive { get; set; }

        /// <summary>
        /// Validate if the tax should be overwritten on the orderitem. 
        /// </summary>
		public Boolean UseChannelTax { get; set; }

        /// <summary>
        /// Indivdual price of the item 
        /// </summary>
		public Double PricePerUnit { get; set; }

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
        /// Unique line number 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// SKU of the item ordered on the channel 
        /// </summary>
		public String ChannelSKU { get; set; }

        /// <summary>
        /// Indicates the item is a service and not a physical item 
        /// </summary>
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