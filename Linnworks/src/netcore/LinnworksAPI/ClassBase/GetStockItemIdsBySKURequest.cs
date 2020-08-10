using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Get stock itemids by sku request 
    /// </summary>
    public class GetStockItemIdsBySKURequest
	{
        /// <summary>
        /// List of SKU's to search for 
        /// </summary>
		public List<String> SKUS { get; set; }
	} 
}