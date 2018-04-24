using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteVariationItemsRequest
	{
		public Guid VariationItemId;

		public List<Guid> StockItemIds;
	} 
}