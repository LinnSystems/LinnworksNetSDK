using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// A request used to process an order by id or reference 
    /// </summary>
    public class ProcessOrderByOrderIdOrReferenceRequest
	{
        /// <summary>
        /// The order id or reference id 
        /// </summary>
		public String OrderOrReferenceId;

        /// <summary>
        /// The location to process the order from 
        /// </summary>
		public Guid LocationId;

        /// <summary>
        /// Defines if the batches have been scanned 
        /// </summary>
		public Boolean ScansPerformed;

        /// <summary>
        /// Have the processing notes been acknowledged 
        /// </summary>
		public Boolean OrderProcessingNotesAcknowledged;

        /// <summary>
        /// Workflow job id that the order is supposed to belong to 
        /// </summary>
		public Int32? WorkflowJobId;
	} 
}