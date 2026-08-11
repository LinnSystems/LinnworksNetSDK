using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelMappingCreateInfo : LinnObject
	{
        /// <summary>
        /// RowId of channel SKU, will be created if not in the request 
        /// </summary>
		public Guid? Id { get; set; }

        /// <summary>
        /// The stock item id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// The SKU as exists on the channel 
        /// </summary>
		public String ChannelSKU { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Region code 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Channel reference ID 
        /// </summary>
		public String ChannelReferenceId { get; set; }

        /// <summary>
        /// Maximum listed quantity 
        /// </summary>
		public Int32 MaxListedQuantity { get; set; }

        /// <summary>
        /// End listing when stock level 
        /// </summary>
		public Int32 EndWhenStock { get; set; }

        /// <summary>
        /// Stock percentage 
        /// </summary>
		public Double StockPercentage { get; set; }

        /// <summary>
        /// Ignore sync, defaults to false 
        /// </summary>
		public Boolean IgnoreSync { get; set; }
	} 
}