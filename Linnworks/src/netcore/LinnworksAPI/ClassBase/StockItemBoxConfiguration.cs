using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Stock item box configuration, dimennsions 
    /// </summary>
    public class StockItemBoxConfiguration
	{
        /// <summary>
        /// Unique box id. 
        /// </summary>
		public Int32 BoxId { get; set; }

		public Int32 StockItemIntId { get; set; }

        /// <summary>
        /// Box name max 16 characters 
        /// </summary>
		public String BoxName { get; set; }

        /// <summary>
        /// Width of the box 
        /// </summary>
		public Decimal Width { get; set; }

        /// <summary>
        /// Height of the box 
        /// </summary>
		public Decimal Height { get; set; }

        /// <summary>
        /// Depth of the box 
        /// </summary>
		public Decimal Length { get; set; }

        /// <summary>
        /// Total weight of the box. 
        /// </summary>
		public Decimal Weight { get; set; }

        /// <summary>
        /// Value break down percentage 
        /// </summary>
		public Decimal ValuePercentage { get; set; }

        /// <summary>
        /// Box barcode, max 64 characters. 
        /// </summary>
		public String Barcode { get; set; }

        /// <summary>
        /// Packaging type id 
        /// </summary>
		public Guid PackagingTypeId { get; set; }

        /// <summary>
        /// IsDeleted flag. 
        /// </summary>
		public Boolean LogicalDelete { get; set; }
	} 
}