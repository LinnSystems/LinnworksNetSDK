using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase order additional cost type. 
    /// </summary>
    public class PurchaseOrderAdditionalCostType
	{
        /// <summary>
        /// Additional Cost type id 
        /// </summary>
		public Int32 AdditionalCostTypeId { get; set; }

        /// <summary>
        /// Additional cost name 
        /// </summary>
		public String TypeName { get; set; }

        /// <summary>
        /// Type of additional cost is shipping cost 
        /// </summary>
		public Boolean IsShippingType { get; set; }

        /// <summary>
        /// Type must be 100% allocated to PO items 
        /// </summary>
		public Boolean IsPartialAllocation { get; set; }

        /// <summary>
        /// Indicate if the additional costs of this type has to be printed 
        /// </summary>
		public Boolean Print { get; set; }

        /// <summary>
        /// Indicate the method to calculate the allocation %  for each item 
        /// </summary>
		public AllocationMethods AllocationMethod { get; set; }
	} 
}