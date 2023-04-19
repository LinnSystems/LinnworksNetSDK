using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockLevelByLocationRequest : LinnObject
	{
		public Guid StockItemId { get; set; }

		public Guid LocationId { get; set; }
	} 
}