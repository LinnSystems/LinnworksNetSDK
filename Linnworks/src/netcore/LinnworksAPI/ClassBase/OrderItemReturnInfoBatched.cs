using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemReturnInfoBatched
	{
		public Int32 OrderItemBatchId;

		public Int32 BatchInventoryId;

		public String BatchNumber;

		public Double DespatchUnitValue;

		public Guid OrderId;

		public Guid fkOrderItemRowId;

		public Guid ParentRowId;

		public Int32 ReturnableQty;

		public Int32 OrderQty;

		public Int32 ReturnedQty;

		public String SKU;

		public String ItemTitle;

		public Double UnitValue;

		public Double TaxRate;

		public Boolean TaxCostInclusive;

		public String Currency;

		public Boolean IsCompositeParent;

		public Boolean IsPartialCompositeReturn;

		public Int32 ParentRatio;

		public Guid? pkStockItemId;

		public Int32 ResentQty;

		public Guid fkRefundRowId;
	} 
}