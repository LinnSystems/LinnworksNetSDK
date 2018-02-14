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
		public Int32 ChildOrderId;

        /// <summary>
        /// Child order ID 
        /// </summary>
		public Guid ChildOrderPkOrderId;

        /// <summary>
        /// Parent order number 
        /// </summary>
		public Int32 ParentOrderId;

        /// <summary>
        /// Parent order ID 
        /// </summary>
		public Guid ParentOrderPkOrderId;

        /// <summary>
        /// Relation type 
        /// </summary>
		public String RelationType;
	} 
}