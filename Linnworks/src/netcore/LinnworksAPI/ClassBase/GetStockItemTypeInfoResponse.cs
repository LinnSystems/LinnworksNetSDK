using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemTypeInfoResponse : LinnObject
	{
		public List<StockItemTypeInfo> StockItemInfo { get; set; }
	} 
}