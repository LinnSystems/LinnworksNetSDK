using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Warehouse binrack 
    /// </summary>
    public class WarehouseBinRack
	{
        /// <summary>
        /// BinRack internal id 
        /// </summary>
		public Int32 BinRackId { get; set; }

        /// <summary>
        /// BinRack type id 
        /// </summary>
		public Int32 BinRackTypeId { get; set; }

        /// <summary>
        /// BinRack 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// Geograpic position of the BinRack 
        /// </summary>
		public GeoPosition GeoPosition { get; set; }

        /// <summary>
        /// Dimention of the BinRack 
        /// </summary>
		public Dimension Dimension { get; set; }

        /// <summary>
        /// Sequence in which the picking or stock movement should be done. Routing. 
        /// </summary>
		public Int32 RoutingSequence { get; set; }

        /// <summary>
        /// Max capacity volume 
        /// </summary>
		public Decimal MaxCapacityVolumetric { get; set; }

        /// <summary>
        /// Maximum volumetric capacity of the location WxDxH = volumetric 
        /// </summary>
		public Decimal CurrentFullPercentage { get; set; }

        /// <summary>
        /// How full the bin rack is in percentage 0 to 100, based on the max quantity or max volumetric capacity. Updated everytime stock is moved in or out. 
        /// </summary>
		public Int32 MaxQuantityCapacity { get; set; }

        /// <summary>
        /// Current total quantity of all items in the bin rack. Updated everytime stock is moved in or out. 
        /// </summary>
		public Int32 CurrentQuantity { get; set; }

        /// <summary>
        /// Current calculation of total volumetric total for all items in the binrack. Updated everytime stock is moved in or out. 
        /// </summary>
		public Decimal CurrentVolumetric { get; set; }

        /// <summary>
        /// Based on the fill percentage, indicates the bin rack as needs replenishment. Auto recalculated based on the consumption. 
        /// </summary>
		public Decimal OptimalReplenishFullPercentage { get; set; }

        /// <summary>
        /// User fixed fill percentage. When it reaches this level the binrack is considered for replenishment. 
        /// </summary>
		public Decimal CriticalReplenishFullPercentage { get; set; }

        /// <summary>
        /// Item Restriction 
        /// </summary>
		public Boolean ItemRestriction { get; set; }

        /// <summary>
        /// Group Restriction 
        /// </summary>
		public Boolean GroupRestriction { get; set; }

        /// <summary>
        /// Location of the binrack. 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Readonly value of the TypeName loaded from BinRackTypeId 
        /// </summary>
		public String TypeName { get; set; }

        /// <summary>
        /// Readonly value of the Standard type loaded from BinRackTypeId 
        /// </summary>
		public Int32 StandardType { get; set; }

        /// <summary>
        /// Readonly value indicates if the Type is Volumumetric 
        /// </summary>
		public Boolean IsVolumetric { get; set; }

        /// <summary>
        /// Direction the item should be accessed from. 
        /// </summary>
		public String AccessOrientation { get; set; }

        /// <summary>
        /// List of storage groups either for the whole binrack or relevant to specific stock item. 
        /// </summary>
		public HashSet<String> StorageGroups { get; set; }

        /// <summary>
        /// Unique skus in binrack. 
        /// </summary>
		public Int32 UniqueSkus { get; set; }

		public WarehouseBinRackItemsInfo ItemsInfo { get; set; }

        /// <summary>
        /// Binrack type 
        /// </summary>
		public WarehouseBinRackType BinrackType { get; set; }

        /// <summary>
        /// Indicates if the binrack is valid for the supplied stockitem. 
        /// </summary>
		public Boolean? IsValidForStockItem { get; set; }
	} 
}