using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents a single instance of an order and its header packaging information. Note that if the order contains split packaging fkPackagingTypeId will be Empty Guid 
    /// </summary>
    public class CalcOrderHeader
	{
        /// <summary>
        /// Order id 
        /// </summary>
		public Guid pkOrderID { get; set; }

        /// <summary>
        /// Numeric order id 
        /// </summary>
		public Int32 nOrderId { get; set; }

        /// <summary>
        /// Shipping service id 
        /// </summary>
		public Guid fkPostalServiceId { get; set; }

        /// <summary>
        /// Country Id 
        /// </summary>
		public Guid fkCountryId { get; set; }

        /// <summary>
        /// Country Name 
        /// </summary>
		public String cCountry { get; set; }

        /// <summary>
        /// Total Item weight in the order 
        /// </summary>
		public Decimal ItemWeight { get; set; }

        /// <summary>
        /// Packaging Group Id 
        /// </summary>
		public Guid fkPackagingGroupId { get; set; }

        /// <summary>
        /// Calculated packaging type for the order 
        /// </summary>
		public Guid fkPackagingTypeId { get; set; }

        /// <summary>
        /// Is the packaging split? 
        /// </summary>
		public Boolean IsSplitPackaging { get; set; }

        /// <summary>
        /// Packaging weight 
        /// </summary>
		public Decimal PackagingWeight { get; set; }

        /// <summary>
        /// Total weight, items + packaging weight 
        /// </summary>
		public Decimal TotalWeight { get; set; }

        /// <summary>
        /// Total width of the order packaging. If null the recalculation was not performed yet. See documentation about how the dimensions of the order calculated. 
        /// </summary>
		public Decimal? TotalWidth { get; set; }

        /// <summary>
        /// Total Height of the order packaging. If null the recalculation was not performed yet. See documentation about how the dimensions of the order calculated. 
        /// </summary>
		public Decimal? TotalHeight { get; set; }

        /// <summary>
        /// Total Depth of the order packaging. If null the recalculation was not performed yet. See documentation about how the dimensions of the order calculated. 
        /// </summary>
		public Decimal? TotalDepth { get; set; }

        /// <summary>
        /// Inidicates that order weights, packaging dimensions has been manually adjusted by the user and therefore automatic recalculation should not be performed for this order 
        /// </summary>
		public Boolean ManualAdjust { get; set; }

		public Boolean CanAutoSplit { get; set; }

        /// <summary>
        /// Was the packaging automatically split? Usually by the 3D Packaging method. 
        /// </summary>
		public Boolean IsAutoSplit { get; set; }

        /// <summary>
        /// Indicates the number of split packaging bins. If null, or 0 - no split packaging 
        /// </summary>
		public Int32 SplitPackageCount { get; set; }

        /// <summary>
        /// Is Label Printed 
        /// </summary>
		public Boolean LabelPrinted { get; set; }

        /// <summary>
        /// Calculation comments. The recalculation routine will output some basic comments about how the calculation was performed in English. 
        /// </summary>
		public List<String> CalculationHints { get; set; }

        /// <summary>
        /// List of order items (excluding composite parents) 
        /// </summary>
		public List<CalcOrderItem> Items { get; set; }

        /// <summary>
        /// List of bins (split packaging) 
        /// </summary>
		public List<CalcBin> Bins { get; set; }

        /// <summary>
        /// Result for volumetric packaging 
        /// </summary>
		public PackingResult ThreeDimPackaging { get; set; }

        /// <summary>
        /// Dimension Calculation method 
        /// </summary>
		public CalcMethod DimMethod { get; set; }
	} 
}