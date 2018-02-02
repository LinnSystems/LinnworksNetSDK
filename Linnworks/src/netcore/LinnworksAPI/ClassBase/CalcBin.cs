using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents split packaging bin 
    /// </summary>
    public class CalcBin
	{
        /// <summary>
        /// Bin Id 
        /// </summary>
		public Guid pkBinId;

        /// <summary>
        /// Bin Tracking number 
        /// </summary>
		public String TrackingNumber;

        /// <summary>
        /// Bin Label Id 
        /// </summary>
		public String LabelId;

        /// <summary>
        /// Bin total weight. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Weight;

        /// <summary>
        /// Label Print date 
        /// </summary>
		public DateTime? PrintDate;

        /// <summary>
        /// Label cost if available 
        /// </summary>
		public Decimal? Cost;

        /// <summary>
        /// Bin allocated packaging type 
        /// </summary>
		public Guid fkPackagingTypeId;

        /// <summary>
        /// Bin width. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Width;

        /// <summary>
        /// Bin height. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Height;

        /// <summary>
        /// Bin depth. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Depth;

        /// <summary>
        /// Bin packaging weight. If null, recalculation was not performed 
        /// </summary>
		public Decimal? PackagingWeight;

        /// <summary>
        /// Bin ItemWeight. If null, recalculation was not performed 
        /// </summary>
		public Decimal? ItemWeight;

        /// <summary>
        /// Indicates that the bin weights and dimensions have been manually adjusted by the user 
        /// </summary>
		public Boolean ManualAdjust;

        /// <summary>
        /// List of order item ids in the bin and their quantities 
        /// </summary>
		public List<CalcBinItem> Items;

        /// <summary>
        /// Object to data table mapping 
        /// </summary>
		public SqlDataRecord DataRecordMetaData;
	} 
}