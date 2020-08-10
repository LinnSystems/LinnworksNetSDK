using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GeneratePickingWaveResponse
	{
        /// <summary>
        /// Validation errors if generate fails. 
        /// </summary>
		public List<PickWaveAllocateCheckResult> ValidationResults;

		public List<PickingWaveDetailed> PickingWaves;

		public List<StockItemInfo> Skus;

		public List<BinRackStockItem> Bins;
	} 
}