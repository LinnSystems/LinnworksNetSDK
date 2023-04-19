using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetEbayListingAuditResponse : LinnObject
	{
		public List<EbayListingAudit> AuditTrail { get; set; }
	} 
}