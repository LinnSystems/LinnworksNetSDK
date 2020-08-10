using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Modify_AdditionalCostResponse
	{
        /// <summary>
        /// List of modified items, added or updated. Each item has Id which was provided in the request 
        /// </summary>
		public List<ModifiedAdditionalCostItem> ModifiedItems { get; set; }

        /// <summary>
        /// Purchase order header with recalculated total 
        /// </summary>
		public PurchaseOrderHeader PurchaseOrderHeader { get; set; }
	} 
}