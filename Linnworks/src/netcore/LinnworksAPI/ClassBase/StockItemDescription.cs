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
		public Guid pkRowId;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// Channel subsource (e.g EBAY1) 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Product description 
        /// </summary>
		public String Description;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}