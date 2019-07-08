using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssignStockToOrderRequest
	{
		public Guid OrderId;

		public List<Guid> OrderItemRows;

        /// <summary>
        /// The way in which batches should be assigned 
        /// </summary>
		public BatchAssignmentMode BatchAssignmentMode;
	} 
}