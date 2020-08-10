using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetItemBinracksRequest
	{
        /// <summary>
        /// Stock item Id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Linnworks stock location Id 
        /// </summary>
		public Guid StockLocationId { get; set; }

        /// <summary>
        /// The name of the location that is currently set to pick from 
        /// </summary>
		public String CurrentBinRackSuggestion { get; set; }

        /// <summary>
        /// If true, the response will also contain binracks that cannot be selected to pick from 
        /// </summary>
		public Boolean IncludeNonPickLocations { get; set; }
	} 
}