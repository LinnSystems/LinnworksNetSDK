using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GenericPagedResult<ScrapItem>
	{
		public Int32 PageNumber { get; set; }

		public Int32 EntriesPerPage { get; set; }

		public Int64 TotalEntries { get; set; }

		public Int32 TotalPages { get; set; }

		public List<ScrapItem> Data { get; set; }
	} 
}