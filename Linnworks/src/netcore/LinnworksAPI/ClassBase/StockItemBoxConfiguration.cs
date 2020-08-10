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
		public Int32 BoxId;

		public Int32 StockItemIntId;

        /// <summary>
        /// Box name max 16 characters 
        /// </summary>
		public String BoxName;

        /// <summary>
        /// Width of the box 
        /// </summary>
		public Decimal Width;

        /// <summary>
        /// Height of the box 
        /// </summary>
		public Decimal Height;

        /// <summary>
        /// Depth of the box 
        /// </summary>
		public Decimal Length;

        /// <summary>
        /// Total weight of the box. 
        /// </summary>
		public Decimal Weight;

        /// <summary>
        /// Value break down percentage 
        /// </summary>
		public Decimal ValuePercentage;

        /// <summary>
        /// Box barcode, max 64 characters. 
        /// </summary>
		public String Barcode;

        /// <summary>
        /// Packaging type id 
        /// </summary>
		public Guid PackagingTypeId;
	} 
}