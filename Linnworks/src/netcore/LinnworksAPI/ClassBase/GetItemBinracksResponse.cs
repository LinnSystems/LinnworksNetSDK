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
		public List<StockItemBatch> AlternateLocations;

        /// <summary>
        /// A list of stock that is available to pick from 
        /// </summary>
		public List<BinRackStockItem> PickableBins;

        /// <summary>
        /// A list of stock that cannot directly be picked from 
        /// </summary>
		public List<BinRackStockItem> NonPickableBins;
	} 
}