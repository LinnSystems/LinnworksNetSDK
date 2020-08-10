using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class ListingsController : BaseController, IListingsController
    {
        public ListingsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// End eBay listings pending relist 
        /// </summary>
        public void EndListingsPendingRelist(EndListingsPendingRelistRequest request)
		{
			GetResponse("Listings/EndListingsPendingRelist", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Get eBay Listing Audit 
        /// </summary>
        public GetEbayListingAuditResponse GetEbayListingAudit(GetEbayListingAuditRequest request)
		{
			var response = GetResponse("Listings/GetEbayListingAudit", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetEbayListingAuditResponse>(response);
		}

		/// <summary>
        /// Set eBay Listing Strike State 
        /// </summary>
        public void SetListingStrikeOffState(SetListingStrikeOffStateRequest request)
		{
			GetResponse("Listings/SetListingStrikeOffState", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		} 
    }
}