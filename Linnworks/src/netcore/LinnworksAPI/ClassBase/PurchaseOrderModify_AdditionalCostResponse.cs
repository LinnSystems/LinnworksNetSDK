using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PurchaseOrderModify_AdditionalCostResponse : LinnObject
	{
        /// <summary>
        /// List of modified items, added or updated. Each item has Id which was provided in the request 
        /// </summary>
		public List<CommonModifiedAdditionalCostItem> ModifiedItems { get; set; }

        /// <summary>
        /// Purchase order header with recalculated total 
        /// </summary>
		public CommonPurchaseOrderHeader PurchaseOrderHeader { get; set; }
	} 
}