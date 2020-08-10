using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseZoneTypesResponse
	{
        /// <summary>
        /// Warehouse zone types 
        /// </summary>
		public List<WarehouseZoneType> Types { get; set; }
	} 
}