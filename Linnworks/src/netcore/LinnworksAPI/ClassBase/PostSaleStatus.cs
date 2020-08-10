using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PostSaleStatus
	{
        /// <summary>
        /// Identifies whether the refund is open, processed, or in an erroneous state 
        /// </summary>
		public PostSaleStatusType StatusHeader { get; set; }

        /// <summary>
        /// Further identifies the state the refund is in, along with whether it can be actioned 
        /// </summary>
		public PostSaleSubStatus StatusDetail { get; set; }
	} 
}