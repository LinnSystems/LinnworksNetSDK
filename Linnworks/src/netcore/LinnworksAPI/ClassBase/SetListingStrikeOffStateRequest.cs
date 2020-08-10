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
		public List<EbayListingAudit> ListingAudits;

        /// <summary>
        /// Channel Listings 
        /// </summary>
		public List<eBayItem> Listings;

        /// <summary>
        /// Reason of strike off 
        /// </summary>
		public String StrikeReason;

        /// <summary>
        /// Listing strike off state 
        /// </summary>
		public Boolean StrikeOffState;

        /// <summary>
        /// Status of listings search 
        /// </summary>
		public ListingStatus ListingsStatus;
	} 
}