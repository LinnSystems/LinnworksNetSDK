using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateWarehouseBinrackBinrackToZoneResponse : LinnObject
	{
		public List<WarehouseBinrackToZoneResponseItem> BinrackToZones { get; set; }
	} 
}