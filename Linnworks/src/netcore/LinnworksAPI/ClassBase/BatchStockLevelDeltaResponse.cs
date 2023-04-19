using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchStockLevelDeltaResponse : LinnObject
	{
		public List<BatchStockLevelDelta> ProcessedDeltas { get; set; }

		public Boolean ProcessedContainsErrors { get; set; }
	} 
}