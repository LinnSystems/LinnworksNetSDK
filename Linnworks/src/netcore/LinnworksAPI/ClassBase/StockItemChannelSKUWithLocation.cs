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
		public Guid fkRowId { get; set; }

        /// <summary>
        /// Location ID 
        /// </summary>
		public Int32 LocationId { get; set; }

        /// <summary>
        /// Location name 
        /// </summary>
		public String LocationName { get; set; }

        /// <summary>
        /// Ignored on a sync 
        /// </summary>
		public Boolean? IgnoreSync { get; set; }

        /// <summary>
        /// Maximum listed quantity 
        /// </summary>
		public Int32? MaxListedQuantity { get; set; }

        /// <summary>
        /// End listing when stock level 
        /// </summary>
		public Int32? EndWhenStock { get; set; }

        /// <summary>
        /// Stock percantage 
        /// </summary>
		public Double? StockPercentage { get; set; }

        /// <summary>
        /// Last update date and time 
        /// </summary>
		public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Current update status 
        /// </summary>
		public String UpdateStatus { get; set; }

        /// <summary>
        /// Quantity submitted to the channel 
        /// </summary>
		public Int32 SubmittedQuantity { get; set; }

        /// <summary>
        /// Currently listed quantity 
        /// </summary>
		public Int32 ListedQuantity { get; set; }

        /// <summary>
        /// How many retries 
        /// </summary>
		public Int32 RetryCount { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}