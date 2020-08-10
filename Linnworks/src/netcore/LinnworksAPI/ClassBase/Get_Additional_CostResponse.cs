using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_Additional_CostResponse
	{
        /// <summary>
        /// List of additional cost items 
        /// </summary>
		public List<PurchaseOrderAdditionalCost> items { get; set; }
	} 
}