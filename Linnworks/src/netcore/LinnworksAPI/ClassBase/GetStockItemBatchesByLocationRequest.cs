using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemBatchesByLocationRequest
	{
		public Guid StockItemId;

		public Guid LocationId;

		public Boolean OnlyAvailable;
	} 
}