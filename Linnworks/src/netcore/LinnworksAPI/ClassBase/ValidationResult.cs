using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ValidationResult
	{
        /// <summary>
        /// Validation result 
        /// </summary>
		public ValidationResultTypes Type;

        /// <summary>
        /// List of affected items 
        /// </summary>
		public List<RefundItem> InvalidItems;

        /// <summary>
        /// Additional information 
        /// </summary>
		public String AdditionalInformation;
	} 
}