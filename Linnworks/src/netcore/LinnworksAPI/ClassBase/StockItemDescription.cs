using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemDescription
	{
        /// <summary>
        /// Record row ID (generate random GUID) 
        /// </summary>
		public Guid pkRowId { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Channel subsource (e.g EBAY1) 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Product description 
        /// </summary>
		public String Description { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}