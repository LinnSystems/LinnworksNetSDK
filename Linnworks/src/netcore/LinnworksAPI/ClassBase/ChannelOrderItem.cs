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
		public Boolean TaxCostInclusive;

        /// <summary>
        /// Validate if the tax should be overwritten on the orderitem. 
        /// </summary>
		public Boolean UseChannelTax;

        /// <summary>
        /// Indivdual price of the item 
        /// </summary>
		public Double PricePerUnit;

        /// <summary>
        /// Quantity customer ordered 
        /// </summary>
		public Int32 Qty;

        /// <summary>
        /// Tax Rate as a whole number eg. 20 
        /// </summary>
		public Double TaxRate;

        /// <summary>
        /// Discount on the line as a whole number eg. 10 
        /// </summary>
		public Double LineDiscount;

        /// <summary>
        /// Unique line number 
        /// </summary>
		public String ItemNumber;

        /// <summary>
        /// SKU of the item ordered on the channel 
        /// </summary>
		public String ChannelSKU;

        /// <summary>
        /// Indicates the item is a service and not a physical item 
        /// </summary>
		public Boolean IsService;

        /// <summary>
        /// Title of the item ordered, or service name 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Options on the item ordered 
        /// </summary>
		public List<ChannelOrderItemOption> Options;
	} 
}