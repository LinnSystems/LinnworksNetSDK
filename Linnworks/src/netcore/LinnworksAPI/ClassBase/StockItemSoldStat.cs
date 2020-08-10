using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemSoldStat
	{
        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Sold quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Total price stock was sold for 
        /// </summary>
		public Double Total { get; set; }

        /// <summary>
        /// Total cost of sold stock 
        /// </summary>
		public Double Cost { get; set; }

        /// <summary>
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin { get; set; }

        /// <summary>
        /// Sold stat inforamtion 
        /// </summary>
		public List<StockItemSoldStatDetail> Detail { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}