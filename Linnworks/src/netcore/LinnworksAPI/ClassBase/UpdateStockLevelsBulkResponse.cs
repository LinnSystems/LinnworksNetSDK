using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateStockLevelsBulkResponse : LinnObject
	{
		public List<UpdateStockLevelsBulkResponseItem> Items { get; set; }
	} 
}