using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Simple stock item image record 
    /// </summary>
    public class StockItemImageSimple
	{
        /// <summary>
        /// Unique id of image 
        /// </summary>
		public Guid pkRowId { get; set; }

        /// <summary>
        /// Is the image the main image 
        /// </summary>
		public Boolean IsMain { get; set; }

        /// <summary>
        /// Sort order for the image 
        /// </summary>
		public Int32 SortOrder { get; set; }

        /// <summary>
        /// Internal checksum value 
        /// </summary>
		public String ChecksumValue { get; set; }

        /// <summary>
        /// Raw file checksum (Used for UI to determine if the image file is the same before submitting for upload) 
        /// </summary>
		public String RawChecksum { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}