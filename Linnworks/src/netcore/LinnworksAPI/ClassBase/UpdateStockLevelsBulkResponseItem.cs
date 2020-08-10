using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateStockLevelsBulkResponseItem
	{
        /// <summary>
        /// Errors assocaited with request item. 
        /// </summary>
		public List<String> Errors { get; set; }

		public String SKU { get; set; }

		public Guid? StockItemId { get; set; }

		public String StockLocationName { get; set; }

		public Guid? StockLocationId { get; set; }

		public Int32? StockLevel { get; set; }

		public Double? StockValue { get; set; }

		public Double? UnitCost { get; set; }

		public String Binrack { get; set; }

		public Int32? MinimumLevel { get; set; }

		public Int32 RowIndex { get; set; }
	} 
}