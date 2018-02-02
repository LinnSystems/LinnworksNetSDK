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
		public Int32? pkRowId;

        /// <summary>
        /// Stock pricing ID 
        /// </summary>
		public Guid fkStockPricingId;

        /// <summary>
        /// Type 
        /// </summary>
		public String Type;

        /// <summary>
        /// Lower level 
        /// </summary>
		public Int32 LowerBound;

        /// <summary>
        /// Value/Price level 
        /// </summary>
		public Double Value;
	} 
}