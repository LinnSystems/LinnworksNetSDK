using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchAssignmentForOrderItems
	{
        /// <summary>
        /// Identifies the order to be updated 
        /// </summary>
		public Guid orderId;

        /// <summary>
        /// Maps order items to batches 
        /// </summary>
		public List<batchAssignment> batchToItemMapping;
	} 
}