using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseZonesByLocationResponse
	{
        /// <summary>
        /// Warehouse Zones 
        /// </summary>
		public List<WarehouseZone> Zones { get; set; }

        /// <summary>
        /// Warehouse Zone types 
        /// </summary>
		public List<WarehouseZoneType> ZoneTypes { get; set; }

        /// <summary>
        /// Zone groups 
        /// </summary>
		public List<WarehouseZoneGroup> ZoneGroups { get; set; }

        /// <summary>
        /// Zone groups to zones. 
        /// </summary>
		public List<WarehouseZoneGroupToZone> ZoneGroupsToZones { get; set; }

        /// <summary>
        /// Zone binrack counts. Only returns zone if binrack is directly in zone. 
        /// </summary>
		public List<WarehouseZoneBinrackCount> ZonesBinracksCount { get; set; }

        /// <summary>
        /// Zone to zones hierarchy 
        /// </summary>
		public List<WarehouseZoneToZone> ZonesToZonesHierarchy { get; set; }
	} 
}