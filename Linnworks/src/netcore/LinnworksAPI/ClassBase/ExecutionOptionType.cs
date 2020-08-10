using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Import execution options 
    /// </summary>
    public class ExecutionOptionType
	{
        /// <summary>
        /// Data type 
        /// </summary>
		public String Type { get; set; }

        /// <summary>
        /// Key to be used in procedures 
        /// </summary>
		public String Key { get; set; }

        /// <summary>
        /// Zero stock levels if it a row is not provided 
        /// </summary>
		public ExecutionOptionType StockLevelBySupplierCode_ZeroWhenNotProvided { get; set; }

        /// <summary>
        /// When an item has a fulfilment sku that is different to the stock item number, but both sku's appear within the import,
        /// 
        /// If false, match by either fulfilment sku or item number.
        /// If true, match by just fulfilment sku. 
        /// </summary>
		public ExecutionOptionType FulfilmentCenterInventoryImport_OnlyMatchByFulfilmentSku { get; set; }
	} 
}