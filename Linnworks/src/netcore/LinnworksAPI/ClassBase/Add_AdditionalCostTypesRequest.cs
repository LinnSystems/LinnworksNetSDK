using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Add_AdditionalCostTypesRequest
	{
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
        /// Type must appear on prints and emails 
        /// </summary>
		public Boolean Print;

		public AllocationMethods AllocationMethod;
	} 
}