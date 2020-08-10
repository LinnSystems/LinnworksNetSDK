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
		public String SKU { get; set; }

        /// <summary>
        /// Is main image 
        /// </summary>
		public Boolean IsMain { get; set; }

        /// <summary>
        /// Image row id 
        /// </summary>
		public Guid pkRowId { get; set; }

        /// <summary>
        /// Checksum 
        /// </summary>
		public String ChecksumValue { get; set; }

        /// <summary>
        /// Raw file checksum (original and unaltered) 
        /// </summary>
		public String RawChecksum { get; set; }

        /// <summary>
        /// Sort order 
        /// </summary>
		public Int32 SortOrder { get; set; }

        /// <summary>
        /// Stockitem id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Full image path 
        /// </summary>
		public String FullSource { get; set; }

        /// <summary>
        /// Thumbnail image path 
        /// </summary>
		public String FullSourceThumbnail { get; set; }
	} 
}