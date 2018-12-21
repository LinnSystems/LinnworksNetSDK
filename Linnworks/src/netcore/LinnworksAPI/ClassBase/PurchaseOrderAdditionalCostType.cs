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
		public Int32 AdditionalCostTypeId;

        /// <summary>
        /// Additional cost name 
        /// </summary>
		public String TypeName;

        /// <summary>
        /// Type of additional cost is shipping cost 
        /// </summary>
		public Boolean IsShippingType;

        /// <summary>
        /// Type must be 100% allocated to PO items 
        /// </summary>
		public Boolean IsPartialAllocation;

        /// <summary>
        /// Indicate if the additional costs of this type has to be printed 
        /// </summary>
		public Boolean Print;

        /// <summary>
        /// Indicate the method to calculate the allocation %  for each item 
        /// </summary>
		public AllocationMethods AllocationMethod;
	} 
}