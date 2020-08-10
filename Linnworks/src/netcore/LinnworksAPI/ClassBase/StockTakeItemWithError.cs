using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockTakeItemWithError
	{
		public String BinRack { get; set; }

		public List<BatchPickingWaveStockItems> PickingWaveItems { get; set; }

        /// <summary>
        /// List of errors for specific stock take item 
        /// </summary>
		public List<String> Errors { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 Quantity { get; set; }

		public Int32? OriginalQuantity { get; set; }

		public Decimal? StockValue { get; set; }

		public Int32? BatchInventoryId { get; set; }
	} 
}