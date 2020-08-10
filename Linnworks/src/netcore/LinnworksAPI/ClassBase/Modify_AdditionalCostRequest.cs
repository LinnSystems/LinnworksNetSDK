using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Modify_AdditionalCostRequest
	{
        /// <summary>
        /// list of additional cost items to add. Each item has Id which will be returned to you to match the item you are adding to array on your side 
        /// </summary>
		public List<AddAdditionalCostItem> itemsToAdd { get; set; }

        /// <summary>
        /// List of items to update. Each line is identified by 
        /// </summary>
		public List<UpdateAdditionalCostItem> itemsToUpdate { get; set; }

        /// <summary>
        /// List of items to delete, provide list of PurchaseAdditionalCostItemId's 
        /// </summary>
		public List<Int32> itemsToDelete { get; set; }

        /// <summary>
        /// Purchase order id 
        /// </summary>
		public Guid PurchaseId { get; set; }
	} 
}