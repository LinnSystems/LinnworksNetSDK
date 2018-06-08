using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GenericPagedResult<ScrapItem>
	{
		public Int32 PageNumber;

		public Int32 EntriesPerPage;

		public Int64 TotalEntries;

		public Int32 TotalPages;

		public List<ScrapItem> Data;
	} 
}