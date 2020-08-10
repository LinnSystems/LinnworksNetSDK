using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateStockLevelsBulkRequestItem
	{
        /// <summary>
        /// SKU - Optional if stock item id is provided 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// StockItemId - Optional if stock SKU is provided, calls will be faster if this is provided. 
        /// </summary>
		public Guid? StockItemId { get; set; }

        /// <summary>
        /// Stock location name, optional if StockLocationId is provided. 
        /// </summary>
		public String StockLocationName { get; set; }

        /// <summary>
        /// Stock Location Id, optional if StockLocationName is provided, calls will be faster if this is provided. 
        /// </summary>
		public Guid? StockLocationId { get; set; }

        /// <summary>
        /// StockLevel - Optional 
        /// </summary>
		public Int32? StockLevel { get; set; }

        /// <summary>
        /// StockValue - Optional, if unit cost is provided then value will be calculated from this, otherwise existing stock value or purchase price will be used. 
        /// </summary>
		public Double? StockValue { get; set; }

        /// <summary>
        /// UnitCost - Optional, if stock value is provided then value will be calculated from this, otherwise existing stock value or purchase price will be used. 
        /// </summary>
		public Double? UnitCost { get; set; }

        /// <summary>
        /// Binrack - Optional, if not provided or empty exisitng binrack will remain. 
        /// </summary>
		public String Binrack { get; set; }

        /// <summary>
        /// Minimum level - Optional 
        /// </summary>
		public Int32? MinimumLevel { get; set; }

        /// <summary>
        /// RowIndex - Optional, can be used to marry up request items with response items. 
        /// </summary>
		public Int32 RowIndex { get; set; }
	} 
}