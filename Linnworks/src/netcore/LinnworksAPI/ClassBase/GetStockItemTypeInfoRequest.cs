using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemTypeInfoRequest
	{
		public List<String> SKUS { get; set; }

		public List<Int32> StockItemIntIds { get; set; }
	} 
}