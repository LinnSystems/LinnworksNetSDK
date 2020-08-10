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
		public List<OrderItemReturnInfo> ChildItems { get; set; }

        /// <summary>
        /// Order Item Batches 
        /// </summary>
		public OrderItemReturnInfoBatched[] Batches { get; set; }

		public Guid OrderId { get; set; }

		public Guid fkOrderItemRowId { get; set; }

		public Guid ParentRowId { get; set; }

		public Int32 ReturnableQty { get; set; }

		public Int32 OrderQty { get; set; }

		public Int32 ReturnedQty { get; set; }

		public String SKU { get; set; }

		public String ItemTitle { get; set; }

		public Double UnitValue { get; set; }

		public Double TaxRate { get; set; }

		public Boolean TaxCostInclusive { get; set; }

		public String Currency { get; set; }

		public Boolean IsCompositeParent { get; set; }

		public Boolean IsPartialCompositeReturn { get; set; }

		public Int32 ParentRatio { get; set; }

		public Guid? pkStockItemId { get; set; }

		public Int32 ResentQty { get; set; }

		public Guid fkRefundRowId { get; set; }
	} 
}