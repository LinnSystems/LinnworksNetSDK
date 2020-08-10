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
		public String SKU;

        /// <summary>
        /// StockItemId - Optional if stock SKU is provided, calls will be faster if this is provided. 
        /// </summary>
		public Guid? StockItemId;

        /// <summary>
        /// Stock location name, optional if StockLocationId is provided. 
        /// </summary>
		public String StockLocationName;

        /// <summary>
        /// Stock Location Id, optional if StockLocationName is provided, calls will be faster if this is provided. 
        /// </summary>
		public Guid? StockLocationId;

        /// <summary>
        /// StockLevel - Optional 
        /// </summary>
		public Int32? StockLevel;

        /// <summary>
        /// StockValue - Optional, if unit cost is provided then value will be calculated from this, otherwise existing stock value or purchase price will be used. 
        /// </summary>
		public Double? StockValue;

        /// <summary>
        /// UnitCost - Optional, if stock value is provided then value will be calculated from this, otherwise existing stock value or purchase price will be used. 
        /// </summary>
		public Double? UnitCost;

        /// <summary>
        /// Binrack - Optional, if not provided or empty exisitng binrack will remain. 
        /// </summary>
		public String Binrack;

        /// <summary>
        /// Minimum level - Optional 
        /// </summary>
		public Int32? MinimumLevel;

        /// <summary>
        /// RowIndex - Optional, can be used to marry up request items with response items. 
        /// </summary>
		public Int32 RowIndex;
	} 
}