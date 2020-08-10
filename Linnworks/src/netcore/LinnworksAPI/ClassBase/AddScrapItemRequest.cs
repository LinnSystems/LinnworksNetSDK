using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddScrapItemRequest
	{
		public ScrapItem ScrapItem;

		public Guid LocationId;

        /// <summary>
        /// Consumption should not be recorded for this scrap request 
        /// </summary>
		public Boolean? IgnoreConsumption;
	} 
}