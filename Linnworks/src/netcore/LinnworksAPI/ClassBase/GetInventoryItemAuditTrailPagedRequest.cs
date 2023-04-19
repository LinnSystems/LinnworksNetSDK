using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInventoryItemAuditTrailPagedRequest : LinnObject
	{
		public String Action { get; set; }

		public DateTime FromDate { get; set; }

		public DateTime ToDate { get; set; }

		public Int32 PageSize { get; set; }

		public Int32 PageNumber { get; set; }
	} 
}