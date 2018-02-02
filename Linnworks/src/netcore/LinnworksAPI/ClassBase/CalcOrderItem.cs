using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents order item for package calculation purposes only 
    /// </summary>
    public class CalcOrderItem
	{
        /// <summary>
        /// Unique stock item identifier 
        /// </summary>
		public Guid fkStockItemId;

        /// <summary>
        /// Unique row identifier of the order item 
        /// </summary>
		public Guid fkOrderItemId;

        /// <summary>
        /// SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Quantity of items 
        /// </summary>
		public Int32 nQty;

        /// <summary>
        /// Item weight 
        /// </summary>
		public Double ItemWeight;

        /// <summary>
        /// Item height 
        /// </summary>
		public Double DimHeight;

        /// <summary>
        /// Item width 
        /// </summary>
		public Double DimWidth;

        /// <summary>
        /// item depth 
        /// </summary>
		public Double DimDepth;

        /// <summary>
        /// Prefered Packaging group 
        /// </summary>
		public Guid PackageGroup;

        /// <summary>
        /// Indicates whether the item is a child of a composite, if EmptyGuid or Null not a child 
        /// </summary>
		public Guid? fkCompositeParentRowId;
	} 
}