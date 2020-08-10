using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for GetJobAudit method 
    /// </summary>
    public class GetJobAuditRequest
	{
        /// <summary>
        /// Job id for which you want to get audit trail 
        /// </summary>
		public Int32 JobId { get; set; }
	} 
}