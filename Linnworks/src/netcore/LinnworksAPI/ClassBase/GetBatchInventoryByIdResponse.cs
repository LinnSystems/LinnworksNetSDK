using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBatchInventoryByIdResponse : LinnObject
	{
		public List<StockItemBatch> Batches { get; set; }
	} 
}