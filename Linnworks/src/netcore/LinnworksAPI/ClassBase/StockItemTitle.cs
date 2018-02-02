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
		public Guid pkRowId;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// SubSource (EBAY1) 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Item title 
        /// </summary>
		public String Title;

		public Guid StockItemId;
	} 
}