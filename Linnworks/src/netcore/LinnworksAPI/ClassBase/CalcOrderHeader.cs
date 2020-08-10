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
		public Guid pkOrderID;

        /// <summary>
        /// Numeric order id 
        /// </summary>
		public Int32 nOrderId;

        /// <summary>
        /// Shipping service id 
        /// </summary>
		public Guid fkPostalServiceId;

        /// <summary>
        /// Country Id 
        /// </summary>
		public Guid fkCountryId;

        /// <summary>
        /// Country Name 
        /// </summary>
		public String cCountry;

        /// <summary>
        /// Total Item weight in the order 
        /// </summary>
		public Decimal ItemWeight;

        /// <summary>
        /// Packaging Group Id 
        /// </summary>
		public Guid fkPackagingGroupId;

        /// <summary>
        /// Calculated packaging type for the order 
        /// </summary>
		public Guid fkPackagingTypeId;

        /// <summary>
        /// Is the packaging split? 
        /// </summary>
		public Boolean IsSplitPackaging;

        /// <summary>
        /// Packaging weight 
        /// </summary>
		public Decimal PackagingWeight;

        /// <summary>
        /// Total weight, items + packaging weight 
        /// </summary>
		public Decimal TotalWeight;

        /// <summary>
        /// Total width of the order packaging. If null the recalculation was not performed yet. See documentation about how the dimensions of the order calculated. 
        /// </summary>
		public Decimal? TotalWidth;

        /// <summary>
        /// Total Height of the order packaging. If null the recalculation was not performed yet. See documentation about how the dimensions of the order calculated. 
        /// </summary>
		public Decimal? TotalHeight;

        /// <summary>
        /// Total Depth of the order packaging. If null the recalculation was not performed yet. See documentation about how the dimensions of the order calculated. 
        /// </summary>
		public Decimal? TotalDepth;

        /// <summary>
        /// Inidicates that order weights, packaging dimensions has been manually adjusted by the user and therefore automatic recalculation should not be performed for this order 
        /// </summary>
		public Boolean ManualAdjust;

		public Boolean CanAutoSplit;

        /// <summary>
        /// Was the packaging automatically split? Usually by the 3D Packaging method. 
        /// </summary>
		public Boolean IsAutoSplit;

        /// <summary>
        /// Indicates the number of split packaging bins. If null, or 0 - no split packaging 
        /// </summary>
		public Int32 SplitPackageCount;

        /// <summary>
        /// Is Label Printed 
        /// </summary>
		public Boolean LabelPrinted;

        /// <summary>
        /// Calculation comments. The recalculation routine will output some basic comments about how the calculation was performed in English. 
        /// </summary>
		public List<String> CalculationHints;

        /// <summary>
        /// List of order items (excluding composite parents) 
        /// </summary>
		public List<CalcOrderItem> Items;

        /// <summary>
        /// List of bins (split packaging) 
        /// </summary>
		public List<CalcBin> Bins;

        /// <summary>
        /// Result for volumetric packaging 
        /// </summary>
		public PackingResult ThreeDimPackaging;

        /// <summary>
        /// Dimension Calculation method 
        /// </summary>
		public CalcMethod DimMethod;
	} 
}