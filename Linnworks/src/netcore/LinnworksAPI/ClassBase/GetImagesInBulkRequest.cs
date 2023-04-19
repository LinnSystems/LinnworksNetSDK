using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetImagesInBulkRequest : LinnObject
	{
		public List<Guid> StockItemIds { get; set; }

		public List<String> SKUS { get; set; }
	} 
}