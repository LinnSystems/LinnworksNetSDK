using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScrapBatchedItemRequest
	{
		public ScrapItem ScrapItem { get; set; }

		public Guid LocationId { get; set; }

		public Int32 BatchInventoryId { get; set; }

        /// <summary>
        /// Consumption should not be recorded for this scrap request 
        /// </summary>
		public Boolean? IgnoreConsumption { get; set; }
	} 
}