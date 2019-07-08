using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Image response item. 
    /// </summary>
    public class GetImagesInBulkResponseImage
	{
        /// <summary>
        /// SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Is main image 
        /// </summary>
		public Boolean IsMain;

        /// <summary>
        /// Image row id 
        /// </summary>
		public Guid pkRowId;

        /// <summary>
        /// Checksum 
        /// </summary>
		public String ChecksumValue;

        /// <summary>
        /// Raw file checksum (original and unaltered) 
        /// </summary>
		public String RawChecksum;

        /// <summary>
        /// Sort order 
        /// </summary>
		public Int32 SortOrder;

        /// <summary>
        /// Stockitem id 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Full image path 
        /// </summary>
		public String FullSource;

        /// <summary>
        /// Thumbnail image path 
        /// </summary>
		public String FullSourceThumbnail;
	} 
}