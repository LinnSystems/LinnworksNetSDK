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
		public Guid fkStockItemId { get; set; }

        /// <summary>
        /// Unique row identifier of the order item 
        /// </summary>
		public Guid fkOrderItemId { get; set; }

		public Int32 StockItemIntId { get; set; }

        /// <summary>
        /// SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Quantity of items 
        /// </summary>
		public Int32 nQty { get; set; }

        /// <summary>
        /// Item weight 
        /// </summary>
		public Decimal ItemWeight { get; set; }

        /// <summary>
        /// Item height 
        /// </summary>
		public Decimal DimHeight { get; set; }

        /// <summary>
        /// Item width 
        /// </summary>
		public Decimal DimWidth { get; set; }

        /// <summary>
        /// item depth 
        /// </summary>
		public Decimal DimDepth { get; set; }

        /// <summary>
        /// Prefered Packaging group 
        /// </summary>
		public Guid PackageGroup { get; set; }

        /// <summary>
        /// Indicates whether the item is a child of a composite, if EmptyGuid or Null not a child 
        /// </summary>
		public Guid? fkCompositeParentRowId { get; set; }

		public Boolean IsCompositeChild { get; set; }

		public List<StockItemBoxConfiguration> Boxes { get; set; }
	} 
}