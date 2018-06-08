using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetSuggestedBinRacksRequest
	{
		public Guid StockItemId;

		public Guid LocationId;

		public List<Int32> BinRackTypeIds;
	} 
}