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
		public List<String> Errors;

		public String SKU;

		public Guid? StockItemId;

		public String StockLocationName;

		public Guid? StockLocationId;

		public Int32? StockLevel;

		public Double? StockValue;

		public Double? UnitCost;

		public String Binrack;

		public Int32? MinimumLevel;

		public Int32 RowIndex;
	} 
}