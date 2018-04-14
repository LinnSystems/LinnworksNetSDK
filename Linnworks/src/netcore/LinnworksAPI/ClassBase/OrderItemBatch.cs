using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemBatch
	{
		public Int32 OrderItemBatchId;

		public Guid OrderItemRowId;

		public Int32 BatchInventoryId;

		public Int32 Quantity;

		public StockItemBatch Batch;

		public Double DespatchUnitValue;

		public OrderItemBatchAssignmentType AssignmentType;
	} 
}