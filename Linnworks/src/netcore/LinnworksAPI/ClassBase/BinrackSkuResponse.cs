using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BinrackSkuResponse : LinnObject
	{
		public List<StockItemBatch> Skus { get; set; }
	} 
}