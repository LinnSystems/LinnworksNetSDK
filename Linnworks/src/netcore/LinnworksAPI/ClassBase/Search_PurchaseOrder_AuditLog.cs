using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class that represents parameters when searching the Audit Log 
    /// </summary>
    public class Search_PurchaseOrder_AuditLog
	{
        /// <summary>
        /// Purchase Order Unique Identifier 
        /// </summary>
		public Guid pkPurchaseId { get; set; }
	} 
}