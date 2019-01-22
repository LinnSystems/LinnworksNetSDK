using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionRMABookingResponse
	{
        /// <summary>
        /// If any errors occurred while accepting the RMA request, this field will be populated with them 
        /// </summary>
		public List<String> Errors;

        /// <summary>
        /// Any global validation information is included in this collection, along with a concatenation of any information found in an individual item 
        /// </summary>
		public List<String> Info;

        /// <summary>
        /// The header ID that was actioned 
        /// </summary>
		public Int32 RMAHeaderId;

        /// <summary>
        /// If a refund was created as part of accepting the return/exchange booking, this identifies the created header 
        /// </summary>
		public Int32? RefundHeaderId;

        /// <summary>
        /// For the header that was actioned, returns its status 
        /// </summary>
		public PostSaleStatus Status;
	} 
}