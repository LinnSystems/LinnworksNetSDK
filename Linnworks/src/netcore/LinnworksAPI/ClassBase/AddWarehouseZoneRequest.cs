using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddWarehouseZoneRequest
	{
        /// <summary>
        /// Zone type Id 
        /// </summary>
		public Int32 ZoneTypeId;

        /// <summary>
        /// Zone name, unique to location 
        /// </summary>
		public String Name;

        /// <summary>
        /// Parent zone id (immediate parent in hierarchy) 
        /// </summary>
		public Int32 ParentZoneId;

        /// <summary>
        /// Hierarchy level from top most parent. 
        /// </summary>
		public Int32 HierarchyLevel;

        /// <summary>
        /// Stock location interger id 
        /// </summary>
		public Int32 StockLocationIntId;
	} 
}