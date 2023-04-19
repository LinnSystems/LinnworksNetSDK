using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBinrackZonesByBinrackIdOrNameResponse : LinnObject
	{
        /// <summary>
        /// Warehouse Zones 
        /// </summary>
		public List<WarehouseZone> Zones { get; set; }

        /// <summary>
        /// Warehosue binrack to zones. 
        /// </summary>
		public List<WarehouseBinrackToZone> BinrackToZones { get; set; }
	} 
}