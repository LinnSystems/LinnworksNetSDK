using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferAudit
	{
		public Guid PkTransferAuditId { get; set; }

		public AuditType AuditType { get; set; }

		public Int32 nAuditType { get; set; }

		public DateTime AuditDate { get; set; }

		public String AuditNote { get; set; }
	} 
}