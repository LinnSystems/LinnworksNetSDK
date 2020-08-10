using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetJobAuditResponse
	{
        /// <summary>
        /// List of audit trail rows 
        /// </summary>
		public List<JobAudit> AuditItems { get; set; }
	} 
}