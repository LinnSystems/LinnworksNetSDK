using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PagedStockCategoryLocationProductResult
	{
		public Int64 TotalResults { get; set; }

		public List<StockCategoryLocationProduct> Results { get; set; }
	} 
}