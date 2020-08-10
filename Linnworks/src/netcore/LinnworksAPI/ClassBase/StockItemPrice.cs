using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemPrice
	{
        /// <summary>
        /// Pricing rule 
        /// </summary>
		public List<StockItemPricingRule> Rules { get; set; }

		public Guid pkRowId { get; set; }

		public String Source { get; set; }

		public String SubSource { get; set; }

		public Double Price { get; set; }

		public String Tag { get; set; }

		public UpdateStatusType UpdateStatus { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}