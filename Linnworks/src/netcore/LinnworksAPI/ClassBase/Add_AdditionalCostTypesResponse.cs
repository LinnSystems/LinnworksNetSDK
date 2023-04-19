using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Add_AdditionalCostTypesResponse : LinnObject
	{
        /// <summary>
        /// Added AdditionalCostType 
        /// </summary>
		public PurchaseOrderAdditionalCostType NewAdditionalCostType { get; set; }
	} 
}