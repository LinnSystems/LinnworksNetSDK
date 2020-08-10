using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetItemBinracksResponse
	{
        /// <summary>
        /// A list of other batches that are available in the given linnworks stock location 
        /// </summary>
		public List<StockItemBatch> AlternateLocations { get; set; }

        /// <summary>
        /// A list of stock that is available to pick from 
        /// </summary>
		public List<BinRackStockItem> PickableBins { get; set; }

        /// <summary>
        /// A list of stock that cannot directly be picked from 
        /// </summary>
		public List<BinRackStockItem> NonPickableBins { get; set; }
	} 
}