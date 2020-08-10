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
		public List<PickWaveAllocateCheckResult> ValidationResults { get; set; }

		public List<PickingWaveDetailed> PickingWaves { get; set; }

		public List<StockItemInfo> Skus { get; set; }

		public List<BinRackStockItem> Bins { get; set; }
	} 
}