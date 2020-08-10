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
		public List<WarehouseZone> Zones;

        /// <summary>
        /// Warehouse Zone types 
        /// </summary>
		public List<WarehouseZoneType> ZoneTypes;

        /// <summary>
        /// Zone groups 
        /// </summary>
		public List<WarehouseZoneGroup> ZoneGroups;

        /// <summary>
        /// Zone groups to zones. 
        /// </summary>
		public List<WarehouseZoneGroupToZone> ZoneGroupsToZones;

        /// <summary>
        /// Zone binrack counts. Only returns zone if binrack is directly in zone. 
        /// </summary>
		public List<WarehouseZoneBinrackCount> ZonesBinracksCount;

        /// <summary>
        /// Zone to zones hierarchy 
        /// </summary>
		public List<WarehouseZoneToZone> ZonesToZonesHierarchy;
	} 
}