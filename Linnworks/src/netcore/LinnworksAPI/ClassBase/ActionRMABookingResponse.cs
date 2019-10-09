using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionRMABookingResponse
	{
        /// <summary>
        /// If a refund was created as part of accepting the return/exchange booking, this identifies the created header 
        /// </summary>
		public Int32? RefundHeaderId;

        /// <summary>
        /// For the header that was actioned, returns its status 
        /// </summary>
		public PostSaleStatus Status;

		public Int32? RMAHeaderId;

		public List<VerifiedRMAItem> Items;

		public List<String> Errors;

		public List<String> Info;
	} 
}