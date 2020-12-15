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
		public Int32? RefundHeaderId { get; set; }

        /// <summary>
        /// For the header that was actioned, returns its status 
        /// </summary>
		public PostSaleStatus Status { get; set; }

        /// <summary>
        /// Determines whether the header was marked as actioned in the database 
        /// </summary>
		public Boolean SuccessfullyActioned { get; set; }

		public Int32? RMAHeaderId { get; set; }

		public List<VerifiedRMAItem> Items { get; set; }

		public List<String> Errors { get; set; }

		public List<String> Info { get; set; }
	} 
}