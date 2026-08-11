using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScrapBatchedItemRequest : LinnObject
	{
		public ScrapItem ScrapItem { get; set; }

        /// <summary>
        /// Deprecated: no longer used by ScrapBatchedItem. Location is derived from the batch record identified by BatchInventoryId. 
        /// </summary>
		public Guid LocationId { get; set; }

		public Int32 BatchInventoryId { get; set; }

        /// <summary>
        /// Consumption should not be recorded for this scrap request 
        /// </summary>
		public Boolean? IgnoreConsumption { get; set; }
	} 
}