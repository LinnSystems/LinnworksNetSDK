using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScrapBatchedItemRequest
	{
		public ScrapItem ScrapItem;

		public Guid LocationId;

		public Int32 BatchInventoryId;

        /// <summary>
        /// Consumption should not be recorded for this scrap request 
        /// </summary>
		public Boolean? IgnoreConsumption;
	} 
}