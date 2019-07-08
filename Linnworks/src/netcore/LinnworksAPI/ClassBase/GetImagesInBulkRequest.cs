using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetImagesInBulkRequest
	{
		public List<Guid> StockItemIds;

		public List<String> SKUS;
	} 
}