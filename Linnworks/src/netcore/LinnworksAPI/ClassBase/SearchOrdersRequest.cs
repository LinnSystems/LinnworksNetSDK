using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchOrdersRequest : LinnObject
	{
		public Guid? LocationId { get; set; }

		public String SearchTerm { get; set; }

		public Boolean? IncludeProcessed { get; set; }
	} 
}