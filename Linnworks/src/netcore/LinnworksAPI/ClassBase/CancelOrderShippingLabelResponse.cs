using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class used for getting shipping label cancelation parameter 
    /// </summary>
    public class CancelOrderShippingLabelResponse
	{
        /// <summary>
        /// Identifies that the label is canceled successfully in the courier system 
        /// </summary>
		public Boolean LabelCanceled { get; set; }

        /// <summary>
        /// Identifies that the label is canceled in Linnworks Only and must also be canceled manually with the courier. This normally indicates that the courier does not support label cancelation. 
        /// </summary>
		public Boolean MustCancelManually { get; set; }

        /// <summary>
        /// Is error 
        /// </summary>
		public Boolean IsError { get; set; }

        /// <summary>
        /// Error Message if IsError is true 
        /// </summary>
		public String ErrorMessage { get; set; }
	} 
}