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
		public String Source { get; set; }

        /// <summary>
        /// Url to full size image 
        /// </summary>
		public String FullSource { get; set; }

        /// <summary>
        /// Image check sum 
        /// </summary>
		public String CheckSumValue { get; set; }

		public Guid pkRowId { get; set; }

		public Boolean IsMain { get; set; }

		public Int32 SortOrder { get; set; }

		public String ChecksumValue { get; set; }

		public String RawChecksum { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}