using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Full stock item image record 
    /// </summary>
    public class StockItemImage
	{
        /// <summary>
        /// URL to thumnail image 
        /// </summary>
		public String Source;

        /// <summary>
        /// Url to full size image 
        /// </summary>
		public String FullSource;

        /// <summary>
        /// Image check sum 
        /// </summary>
		public String CheckSumValue;

		public Guid pkRowId;

		public Boolean IsMain;

		public Int32 SortOrder;

		public Guid StockItemId;
	} 
}