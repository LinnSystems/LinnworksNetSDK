using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetJobErrorsResponse : LinnObject
	{
        /// <summary>
        /// List of errors for a job 
        /// </summary>
		public List<JobError> JobErrors { get; set; }
	} 
}