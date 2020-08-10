using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateStockLevelsBulkRequest
	{
		public List<UpdateStockLevelsBulkRequestItem> Items { get; set; }
	} 
}