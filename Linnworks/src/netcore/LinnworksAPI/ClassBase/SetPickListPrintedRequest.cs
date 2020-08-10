using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SetPickListPrintedRequest
	{
        /// <summary>
        /// A list of orders that should be assigned the IsPrinted value 
        /// </summary>
		public Guid[] OrderIds { get; set; }

        /// <summary>
        /// If stock batches needs to be assigned this defines how they should be assigned 
        /// </summary>
		public BatchAssignmentMode BatchAssignmentMode { get; set; }
	} 
}