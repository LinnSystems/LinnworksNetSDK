using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for getting purchase order payment statements 
    /// </summary>
    public class Get_PaymentStatementRequest
	{
        /// <summary>
        /// Purchase order unique identifier of a PO 
        /// </summary>
		public Guid PurchaseId { get; set; }
	} 
}