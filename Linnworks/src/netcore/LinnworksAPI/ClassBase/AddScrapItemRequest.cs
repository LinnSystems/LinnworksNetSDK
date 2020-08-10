using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddScrapItemRequest
	{
		public ScrapItem ScrapItem { get; set; }

		public Guid LocationId { get; set; }

        /// <summary>
        /// Consumption should not be recorded for this scrap request 
        /// </summary>
		public Boolean? IgnoreConsumption { get; set; }
	} 
}