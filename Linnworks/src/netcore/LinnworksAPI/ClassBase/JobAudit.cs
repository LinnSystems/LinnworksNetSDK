using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class JobAudit
	{
		public Int32 JobAuditId { get; set; }

		public Int32 JobId { get; set; }

		public JobAuditType Type { get; set; }

		public DateTime Date { get; set; }

		public String Note { get; set; }

		public String User { get; set; }
	} 
}