using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockTakeItemWithError
	{
		public String BinRack;

		public List<BatchPickingWaveStockItems> PickingWaveItems;

        /// <summary>
        /// List of errors for specific stock take item 
        /// </summary>
		public List<String> Errors;

		public Guid StockItemId;

		public Int32 Quantity;

		public Int32? OriginalQuantity;

		public Decimal? StockValue;

		public Int32? BatchInventoryId;
	} 
}