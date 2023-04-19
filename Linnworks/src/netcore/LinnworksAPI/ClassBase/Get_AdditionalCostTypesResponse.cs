using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_AdditionalCostTypesResponse : LinnObject
	{
        /// <summary>
        /// List of additional costs types 
        /// </summary>
		public List<PurchaseOrderAdditionalCostType> AdditionalTypes { get; set; }
	} 
}