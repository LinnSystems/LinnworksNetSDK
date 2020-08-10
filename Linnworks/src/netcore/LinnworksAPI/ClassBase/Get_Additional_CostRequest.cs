using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for getting purchase order additional costs 
    /// </summary>
    public class Get_Additional_CostRequest
	{
        /// <summary>
        /// Purchase order unique identifier of a PO 
        /// </summary>
		public Guid PurchaseId { get; set; }
	} 
}