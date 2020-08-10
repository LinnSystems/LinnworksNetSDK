using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemBatch
	{
		public Int32 OrderItemBatchId { get; set; }

		public Guid OrderItemRowId { get; set; }

		public Int32 BatchInventoryId { get; set; }

		public Int32 Quantity { get; set; }

		public StockItemBatch Batch { get; set; }

		public Double DespatchUnitValue { get; set; }

		public OrderItemBatchAssignmentType AssignmentType { get; set; }
	} 
}