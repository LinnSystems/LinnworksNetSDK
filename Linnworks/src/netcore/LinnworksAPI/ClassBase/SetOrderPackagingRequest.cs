using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for SetOrderPackaging method in Orders controller 
    /// </summary>
    public class SetOrderPackagingRequest
	{
        /// <summary>
        /// Packaging group Id 
        /// </summary>
		public Guid fkPackagingGroupId { get; set; }

        /// <summary>
        /// Packaging Type Id. It has to be one of types available for selected Group Id 
        /// </summary>
		public Guid fkPackagingTypeId { get; set; }

        /// <summary>
        /// Order Id to set the order packaging data 
        /// </summary>
		public Guid pkOrderId { get; set; }

        /// <summary>
        /// Total weight of order packaging 
        /// </summary>
		public Decimal TotalWeight { get; set; }

        /// <summary>
        /// Indicate if this data is manually adjusted with the rest of fields or is auto calculated 
        /// </summary>
		public Boolean ManualAdjust { get; set; }

        /// <summary>
        /// Indicates whether the order should be auto split. Usually via the 3D packaging methods. 
        /// </summary>
		public Boolean IsAutoSplit { get; set; }

        /// <summary>
        /// Total packaging depth 
        /// </summary>
		public Decimal TotalDepth { get; set; }

        /// <summary>
        /// Total Height 
        /// </summary>
		public Decimal TotalHeight { get; set; }

        /// <summary>
        /// Total Width 
        /// </summary>
		public Decimal TotalWidth { get; set; }
	} 
}