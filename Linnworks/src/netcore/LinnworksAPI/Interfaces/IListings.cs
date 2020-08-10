using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IListingsController
	{
		void EndListingsPendingRelist(EndListingsPendingRelistRequest request);
		GetEbayListingAuditResponse GetEbayListingAudit(GetEbayListingAuditRequest request);
		void SetListingStrikeOffState(SetListingStrikeOffStateRequest request);
	} 
}