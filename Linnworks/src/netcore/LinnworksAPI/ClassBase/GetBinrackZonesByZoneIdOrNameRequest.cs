using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBinrackZonesByZoneIdOrNameRequest
	{
		public Int32 StockLocationIntId;

		public List<String> ZoneNames;

		public List<Int32> ZoneIds;
	} 
}