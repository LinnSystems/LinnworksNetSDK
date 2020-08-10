using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetEbayListingAuditRequest
	{
		public String ItemNumber { get; set; }

		public Int32 PageNumber { get; set; }

		public Int32 EntriesPerPage { get; set; }
	} 
}