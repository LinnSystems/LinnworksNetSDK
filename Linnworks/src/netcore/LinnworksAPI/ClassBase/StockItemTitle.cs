using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemTitle
	{
        /// <summary>
        /// Record row id (generate random) 
        /// </summary>
		public Guid pkRowId { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// SubSource (EBAY1) 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String Title { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}