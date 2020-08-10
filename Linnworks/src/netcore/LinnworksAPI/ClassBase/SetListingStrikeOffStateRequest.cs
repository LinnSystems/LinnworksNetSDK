using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SetListingStrikeOffStateRequest
	{
        /// <summary>
        /// Listing audit details 
        /// </summary>
		public List<EbayListingAudit> ListingAudits { get; set; }

        /// <summary>
        /// Channel Listings 
        /// </summary>
		public List<eBayItem> Listings { get; set; }

        /// <summary>
        /// Reason of strike off 
        /// </summary>
		public String StrikeReason { get; set; }

        /// <summary>
        /// Listing strike off state 
        /// </summary>
		public Boolean StrikeOffState { get; set; }

        /// <summary>
        /// Status of listings search 
        /// </summary>
		public ListingStatus ListingsStatus { get; set; }
	} 
}