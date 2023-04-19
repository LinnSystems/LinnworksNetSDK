using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BulkScrapBatchedItemsRequest : LinnObject
	{
		public Guid LocationId { get; set; }

		public List<ScrapItemExtended> ScrapItems { get; set; }
	} 
}