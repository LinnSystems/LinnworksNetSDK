using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateWarehouseBinrackBinrackToZoneRequest
	{
        /// <summary>
        /// Binrack to zones collection, a BinRackId of zero will assume the Binrack should be removed from the zone. 
        /// </summary>
		public List<WarehouseBinrackToZoneRequestItem> BinrackToZones { get; set; }
	} 
}