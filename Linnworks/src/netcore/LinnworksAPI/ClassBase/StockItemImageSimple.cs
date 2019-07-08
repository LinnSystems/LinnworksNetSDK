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
		public Guid pkRowId;

        /// <summary>
        /// Is the image the main image 
        /// </summary>
		public Boolean IsMain;

        /// <summary>
        /// Sort order for the image 
        /// </summary>
		public Int32 SortOrder;

        /// <summary>
        /// Internal checksum value 
        /// </summary>
		public String ChecksumValue;

        /// <summary>
        /// Raw file checksum (Used for UI to determine if the image file is the same before submitting for upload) 
        /// </summary>
		public String RawChecksum;

		public Guid StockItemId;
	} 
}