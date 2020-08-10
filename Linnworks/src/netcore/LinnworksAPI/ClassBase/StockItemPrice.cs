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
		public List<StockItemPricingRule> Rules;

		public Guid pkRowId;

		public String Source;

		public String SubSource;

		public Double Price;

		public String Tag;

		public UpdateStatusType UpdateStatus;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}