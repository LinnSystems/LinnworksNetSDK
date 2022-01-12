using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Bin Rack Type 
    /// </summary>
    public class WarehouseBinRackType
	{
        /// <summary>
        /// Binrack type id - unique record identifier 
        /// </summary>
		public Int32 BinRackTypeId { get; set; }

        /// <summary>
        /// Custom name for bin rack type 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Binrack Standard Type  Id 
        /// 1 - Picking
        /// 2 - Special Access Picking
        /// 3 - Storage
        /// 4 - Deep Storage
        /// 5 - Putaway
        /// 6 - Quality Assurance
        /// 7 - Scrap / Quarantine
        /// 8 - Returns
        /// 0 - Flexible 
        /// </summary>
		public Int32 StandardType { get; set; }

        /// <summary>
        /// Identifies whether the bin rack type is bound to a specific location 
        /// </summary>
		public Guid? LocationBound { get; set; }

        /// <summary>
        /// Is type restricted to volumetric measurements only 
        /// </summary>
		public Boolean IsVolumetric { get; set; }
	} 
}