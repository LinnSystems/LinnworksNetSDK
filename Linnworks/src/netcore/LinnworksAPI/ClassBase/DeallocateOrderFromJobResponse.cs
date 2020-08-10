using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response - contains details of a the job 
    /// </summary>
    public class DeallocateOrderFromJobResponse
	{
        /// <summary>
        /// Updated job details 
        /// </summary>
		public Job Job { get; set; }
	} 
}