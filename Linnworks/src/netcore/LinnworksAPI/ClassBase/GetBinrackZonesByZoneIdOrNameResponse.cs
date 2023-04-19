using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBinrackZonesByZoneIdOrNameResponse : LinnObject
	{
		public List<WarehouseZone> WarehouseZones { get; set; }
	} 
}