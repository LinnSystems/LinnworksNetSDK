using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetEbayListingOperationsRequest : LinnObject
	{
		public Guid LocationId { get; set; }

		public Int32 PageNumber { get; set; }

		public Int32 EntriesPerPage { get; set; }

		public IEnumerable<Int32> ChannelIds { get; set; }
	} 
}