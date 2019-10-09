using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BulkScrapBatchedItemsRequest
	{
		public Guid LocationId;

		public List<ScrapItemExtended> ScrapItems;
	} 
}