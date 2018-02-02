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
		public Guid ChannelSKURowId;

        /// <summary>
        /// Product SKU number 
        /// </summary>
		public String SKU;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// Region code 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Current update status 
        /// </summary>
		public String UpdateStatus;

        /// <summary>
        /// Channel reference ID 
        /// </summary>
		public String ChannelReferenceId;

        /// <summary>
        /// Last update date and time 
        /// </summary>
		public DateTime LastUpdate;

        /// <summary>
        /// Maximum listed quantity 
        /// </summary>
		public Int32 MaxListedQuantity;

        /// <summary>
        /// End listing when stock level 
        /// </summary>
		public Int32 EndWhenStock;

        /// <summary>
        /// Submitted quantity 
        /// </summary>
		public Int32 SubmittedQuantity;

        /// <summary>
        /// Listed quantity 
        /// </summary>
		public Int32 ListedQuantity;

        /// <summary>
        /// Stock percentage 
        /// </summary>
		public Double StockPercentage;

        /// <summary>
        /// Ignore sync 
        /// </summary>
		public Boolean IgnoreSync;

        /// <summary>
        /// Ignore sync for multi location items 
        /// </summary>
		public Boolean? IgnoreSyncMultiLocation;

        /// <summary>
        /// Multi location 
        /// </summary>
		public Boolean IsMultiLocation;

		public Guid StockItemId;
	} 
}