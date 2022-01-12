using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOpenOrdersRequest
	{
		public Int32 ViewId { get; set; }

		public Guid LocationId { get; set; }

		public Int32 EntriesPerPage { get; set; }

		public Int32 PageNumber { get; set; }

		public Guid[] OrderIds { get; set; }
	} 
}