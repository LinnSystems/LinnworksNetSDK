using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PagedResult<StockItemAuditTrail> : LinnObject
	{
		public List<StockItemAuditTrail> Items { get; set; }

		public Int32 TotalItems { get; set; }

		public Int32 CurrentPage { get; set; }

		public Int32 EntriesPerPage { get; set; }
	} 
}