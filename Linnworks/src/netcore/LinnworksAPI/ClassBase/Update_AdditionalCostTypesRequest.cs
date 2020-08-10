using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Update_AdditionalCostTypesRequest
	{
        /// <summary>
        /// Additional Cost type id to update 
        /// </summary>
		public Int32 AdditionalCostTypeId { get; set; }

        /// <summary>
        /// Additional cost name, if null the field is not updated 
        /// </summary>
		public String TypeName { get; set; }

        /// <summary>
        /// Type of additional cost is shipping cost, if null, the field is not updated 
        /// </summary>
		public Boolean? IsShippingType { get; set; }

        /// <summary>
        /// Type must be 100% allocated to PO items, if null, the field is not updated 
        /// </summary>
		public Boolean? IsPartialAllocation { get; set; }

        /// <summary>
        /// Type must appear on prints and emails 
        /// </summary>
		public Boolean? Print { get; set; }

		public AllocationMethods? AllocationMethod { get; set; }
	} 
}