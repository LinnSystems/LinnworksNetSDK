using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ProcessedOrderRelation
	{
        /// <summary>
        /// Child order number 
        /// </summary>
		public Int32 ChildOrderId { get; set; }

        /// <summary>
        /// Child order ID 
        /// </summary>
		public Guid ChildOrderPkOrderId { get; set; }

        /// <summary>
        /// Parent order number 
        /// </summary>
		public Int32 ParentOrderId { get; set; }

        /// <summary>
        /// Parent order ID 
        /// </summary>
		public Guid ParentOrderPkOrderId { get; set; }

        /// <summary>
        /// Relation type 
        /// </summary>
		public String RelationType { get; set; }
	} 
}