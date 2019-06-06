using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemsFullByIdsRequest
	{
		public List<Guid> StockItemIds;

		public List<StockItemFullExtendedDataRequirement> DataRequirements;
	} 
}