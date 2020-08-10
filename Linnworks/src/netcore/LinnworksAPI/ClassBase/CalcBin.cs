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
		public Guid pkBinId { get; set; }

        /// <summary>
        /// Bin Tracking number 
        /// </summary>
		public String TrackingNumber { get; set; }

        /// <summary>
        /// Bin Label Id 
        /// </summary>
		public String LabelId { get; set; }

        /// <summary>
        /// Bin total weight. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Weight { get; set; }

        /// <summary>
        /// Label Print date 
        /// </summary>
		public DateTime? PrintDate { get; set; }

        /// <summary>
        /// Label cost if available 
        /// </summary>
		public Decimal? Cost { get; set; }

        /// <summary>
        /// Bin allocated packaging type 
        /// </summary>
		public Guid fkPackagingTypeId { get; set; }

        /// <summary>
        /// Bin width. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Width { get; set; }

        /// <summary>
        /// Bin height. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Height { get; set; }

        /// <summary>
        /// Bin depth. If null, recalculation was not performed 
        /// </summary>
		public Decimal? Depth { get; set; }

        /// <summary>
        /// Bin packaging weight. If null, recalculation was not performed 
        /// </summary>
		public Decimal? PackagingWeight { get; set; }

        /// <summary>
        /// Bin ItemWeight. If null, recalculation was not performed 
        /// </summary>
		public Decimal? ItemWeight { get; set; }

        /// <summary>
        /// Indicates that the bin weights and dimensions have been manually adjusted by the user 
        /// </summary>
		public Boolean ManualAdjust { get; set; }

        /// <summary>
        /// List of order item ids in the bin and their quantities 
        /// </summary>
		public List<CalcBinItem> Items { get; set; }

        /// <summary>
        /// Object to data table mapping 
        /// </summary>
		public SqlDataRecord DataRecordMetaData { get; set; }
	} 
}