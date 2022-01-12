using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderRelation
	{
        /// <summary>
        /// Parent order GUID 
        /// </summary>
		public Guid ParentOrderId { get; set; }

        /// <summary>
        /// Child order GUID 
        /// </summary>
		public Guid ChildOrderId { get; set; }

        /// <summary>
        /// Parent order ID 
        /// </summary>
		public Int32 Parent { get; set; }

        /// <summary>
        /// Child order ID 
        /// </summary>
		public Int32 Child { get; set; }

        /// <summary>
        /// Relation type 
        /// </summary>
		public String Type { get; set; }
	} 
}