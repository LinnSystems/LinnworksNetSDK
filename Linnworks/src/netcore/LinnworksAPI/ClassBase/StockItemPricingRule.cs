using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemPricingRule
	{
        /// <summary>
        /// Record row ID (optional) 
        /// </summary>
		public Int32? pkRowId { get; set; }

        /// <summary>
        /// Stock pricing ID 
        /// </summary>
		public Guid fkStockPricingId { get; set; }

        /// <summary>
        /// Type 
        /// </summary>
		public String Type { get; set; }

        /// <summary>
        /// Lower level 
        /// </summary>
		public Int32 LowerBound { get; set; }

        /// <summary>
        /// Value/Price level 
        /// </summary>
		public Double Value { get; set; }
	} 
}