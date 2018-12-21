using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request contains items for modifyin, deleting and adding additional cost allocation items 
    /// </summary>
    public class Modify_AdditionalCostAllocationRequest
	{
        /// <summary>
        /// Purchase order id 
        /// </summary>
		public Guid PurchaseId;

        /// <summary>
        /// Items to add 
        /// </summary>
		public List<AddAdditionalCostAllocationItem> itemsToAdd;

        /// <summary>
        /// Items to update 
        /// </summary>
		public List<UpdateAdditionalCostAllocationItem> itemsToUpdate;

        /// <summary>
        /// Items to delete by CostAllocationId 
        /// </summary>
		public List<Int32> itemsToDelete;
	} 
}