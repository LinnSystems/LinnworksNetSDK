using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Modify_PaymentStatementRequest
	{
        /// <summary>
        /// list of payment statements to add. Each item has Id which will be returned to you to match the item you are adding to array on your side 
        /// </summary>
		public List<AddPaymentStatementItem> itemsToAdd { get; set; }

        /// <summary>
        /// List of payment statements to update. Each line is identified by 
        /// </summary>
		public List<UpdatePaymentStatementItem> itemsToUpdate { get; set; }

        /// <summary>
        /// List of payment statements to delete, provide list of PurchasePaymentStatementId's 
        /// </summary>
		public List<Int32> itemsToDelete { get; set; }

        /// <summary>
        /// Purchase order id 
        /// </summary>
		public Guid PurchaseId { get; set; }
	} 
}