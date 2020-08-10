using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for DeallocateOrderFromJob method 
    /// </summary>
    public class DeallocateOrderFromJobRequest
	{
        /// <summary>
        /// Job id from which the order will be removed 
        /// </summary>
		public Int32 JobId { get; set; }

        /// <summary>
        /// Order id you want to remove/deallocate from the job 
        /// </summary>
		public Guid OrderId { get; set; }
	} 
}