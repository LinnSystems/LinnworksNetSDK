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
		public Guid fkPackagingGroupId;

        /// <summary>
        /// Packaging Type Id. It has to be one of types available for selected Group Id 
        /// </summary>
		public Guid fkPackagingTypeId;

        /// <summary>
        /// Order Id to set the order packaging data 
        /// </summary>
		public Guid pkOrderId;

        /// <summary>
        /// Total weight of order packaging 
        /// </summary>
		public Decimal TotalWeight;

        /// <summary>
        /// Indicate if this data is manually adjusted with the rest of fields or is auto calculated 
        /// </summary>
		public Boolean ManualAdjust;

        /// <summary>
        /// Indicates whether the order should be auto split. Usually via the 3D packaging methods. 
        /// </summary>
		public Boolean IsAutoSplit;

        /// <summary>
        /// Total packaging depth 
        /// </summary>
		public Decimal TotalDepth;

        /// <summary>
        /// Total Height 
        /// </summary>
		public Decimal TotalHeight;

        /// <summary>
        /// Total Width 
        /// </summary>
		public Decimal TotalWidth;
	} 
}