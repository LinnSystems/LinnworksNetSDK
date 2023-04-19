using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PagedStockCategoryLocationProductResult : LinnObject
	{
		public Int64 TotalResults { get; set; }

		public List<StockCategoryLocationProduct> Results { get; set; }
	} 
}