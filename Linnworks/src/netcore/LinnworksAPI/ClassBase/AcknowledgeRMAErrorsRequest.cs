using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRMAErrorsRequest
	{
        /// <summary>
        /// The unique identifier for the RMA header whose errors will be acknowledged 
        /// </summary>
		public Int32 RMAHeaderId;

        /// <summary>
        /// A list of row ids to acknowledge errors for 
        /// </summary>
		public List<Int32> RMARowIds;
	} 
}