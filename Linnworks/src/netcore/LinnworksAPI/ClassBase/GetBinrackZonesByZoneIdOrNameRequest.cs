using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBinrackZonesByZoneIdOrNameRequest
	{
		public Int32 StockLocationIntId { get; set; }

		public List<String> ZoneNames { get; set; }

		public List<Int32> ZoneIds { get; set; }
	} 
}