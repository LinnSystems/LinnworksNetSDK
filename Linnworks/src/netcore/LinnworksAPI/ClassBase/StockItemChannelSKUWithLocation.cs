using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemChannelSKUWithLocation
	{
        /// <summary>
        /// Record row ID 
        /// </summary>
		public Guid fkRowId;

        /// <summary>
        /// Location ID 
        /// </summary>
		public Int32 LocationId;

        /// <summary>
        /// Location name 
        /// </summary>
		public String LocationName;

        /// <summary>
        /// Ignored on a sync 
        /// </summary>
		public Boolean? IgnoreSync;

        /// <summary>
        /// Maximum listed quantity 
        /// </summary>
		public Int32? MaxListedQuantity;

        /// <summary>
        /// End listing when stock level 
        /// </summary>
		public Int32? EndWhenStock;

        /// <summary>
        /// Stock percantage 
        /// </summary>
		public Double? StockPercentage;

        /// <summary>
        /// Last update date and time 
        /// </summary>
		public DateTime LastUpdate;

        /// <summary>
        /// Current update status 
        /// </summary>
		public String UpdateStatus;

        /// <summary>
        /// Quantity submitted to the channel 
        /// </summary>
		public Int32 SubmittedQuantity;

        /// <summary>
        /// Currently listed quantity 
        /// </summary>
		public Int32 ListedQuantity;

        /// <summary>
        /// How many retries 
        /// </summary>
		public Int32 RetryCount;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}