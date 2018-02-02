using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemPrice
	{
        /// <summary>
        /// Record row ID (generate random) 
        /// </summary>
		public Guid pkRowId;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// SubSource (e.g. EBAY1) 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Channel price 
        /// </summary>
		public Double Price;

		public UpdateStatusType UpdateStatus;

        /// <summary>
        /// Product price tag 
        /// </summary>
		public String Tag;

        /// <summary>
        /// Pricing rule 
        /// </summary>
		public List<StockItemPricingRule> Rules;

		public Guid StockItemId;
	} 
}