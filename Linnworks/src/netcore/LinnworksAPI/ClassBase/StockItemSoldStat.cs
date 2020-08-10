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
		public String Source;

        /// <summary>
        /// Sold quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Total price stock was sold for 
        /// </summary>
		public Double Total;

        /// <summary>
        /// Total cost of sold stock 
        /// </summary>
		public Double Cost;

        /// <summary>
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin;

        /// <summary>
        /// Sold stat inforamtion 
        /// </summary>
		public List<StockItemSoldStatDetail> Detail;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}