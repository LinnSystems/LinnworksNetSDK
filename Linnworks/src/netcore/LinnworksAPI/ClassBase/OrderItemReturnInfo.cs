using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemReturnInfo
	{
        /// <summary>
        /// List of child items (populated if the return is a composite item) 
        /// </summary>
		public List<OrderItemReturnInfo> ChildItems;

        /// <summary>
        /// Order Item Batches 
        /// </summary>
		public OrderItemReturnInfoBatched[] Batches;

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