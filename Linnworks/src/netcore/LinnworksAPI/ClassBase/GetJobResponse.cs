using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetJobResponse
	{
        /// <summary>
        /// Single instance of a job returned with list of orders, status and available attachments 
        /// </summary>
		public Job Job { get; set; }

		public List<JobError> JobErrors { get; set; }
	} 
}