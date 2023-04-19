using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_PaymentStatementResponse : LinnObject
	{
        /// <summary>
        /// List of payment statements 
        /// </summary>
		public List<PurchaseOrderPaymentStatement> items { get; set; }
	} 
}