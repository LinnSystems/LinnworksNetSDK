using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Update_AdditionalCostTypesResponse : LinnObject
	{
        /// <summary>
        /// Update additional cost type 
        /// </summary>
		public PurchaseOrderAdditionalCostType UpdatedAdditionalCostType { get; set; }
	} 
}