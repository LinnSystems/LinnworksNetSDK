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
		public String OrderOrReferenceId { get; set; }

        /// <summary>
        /// The location to process the order from 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Defines if the batches have been scanned 
        /// </summary>
		public Boolean ScansPerformed { get; set; }

        /// <summary>
        /// Have the processing notes been acknowledged 
        /// </summary>
		public Boolean OrderProcessingNotesAcknowledged { get; set; }

        /// <summary>
        /// Workflow job id that the order is supposed to belong to 
        /// </summary>
		public Int32? WorkflowJobId { get; set; }
	} 
}