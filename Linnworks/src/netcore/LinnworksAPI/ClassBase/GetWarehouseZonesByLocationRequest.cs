using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseZonesByLocationRequest : LinnObject
	{
		public Int32 StockLocationIntId { get; set; }

		public Boolean OnlyBinrackAssignable { get; set; }
	} 
}