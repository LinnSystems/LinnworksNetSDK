using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderRelation
	{
        /// <summary>
        /// Parent order ID 
        /// </summary>
		public Int32 Parent;

        /// <summary>
        /// Child order ID 
        /// </summary>
		public Int32 Child;

        /// <summary>
        /// Relation type 
        /// </summary>
		public String Type;
	} 
}