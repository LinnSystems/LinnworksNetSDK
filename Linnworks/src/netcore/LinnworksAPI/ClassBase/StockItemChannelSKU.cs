using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemChannelSKU
	{
        /// <summary>
        /// RowId of channel SKU 
        /// </summary>
		public Guid ChannelSKURowId { get; set; }

        /// <summary>
        /// Product SKU number 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Region code 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Current update status 
        /// </summary>
		public String UpdateStatus { get; set; }

        /// <summary>
        /// Channel reference ID 
        /// </summary>
		public String ChannelReferenceId { get; set; }

        /// <summary>
        /// Last update date and time 
        /// </summary>
		public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Maximum listed quantity 
        /// </summary>
		public Int32 MaxListedQuantity { get; set; }

        /// <summary>
        /// End listing when stock level 
        /// </summary>
		public Int32 EndWhenStock { get; set; }

        /// <summary>
        /// Submitted quantity 
        /// </summary>
		public Int32 SubmittedQuantity { get; set; }

        /// <summary>
        /// Listed quantity 
        /// </summary>
		public Int32 ListedQuantity { get; set; }

        /// <summary>
        /// Stock percentage 
        /// </summary>
		public Double StockPercentage { get; set; }

        /// <summary>
        /// Ignore sync 
        /// </summary>
		public Boolean IgnoreSync { get; set; }

        /// <summary>
        /// Ignore sync for multi location items 
        /// </summary>
		public Boolean? IgnoreSyncMultiLocation { get; set; }

        /// <summary>
        /// Multi location 
        /// </summary>
		public Boolean IsMultiLocation { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}