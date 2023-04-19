using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemBatchesByLocationResponse : LinnObject
	{
		public List<StockItemBatch> Batches { get; set; }
	} 
}