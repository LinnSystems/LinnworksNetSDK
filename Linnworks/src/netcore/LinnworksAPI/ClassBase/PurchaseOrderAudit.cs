using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PurchaseOrderAudit
	{
        /// <summary>
        /// Purchase audit trail ID 
        /// </summary>
		public Guid pkPurchaseAuditTrailId { get; set; }

        /// <summary>
        /// When purchase order audit record was made 
        /// </summary>
		public DateTime AuditTrailDateTimeStamp { get; set; }

        /// <summary>
        /// Purchase order ID 
        /// </summary>
		public Guid fkPurchaseId { get; set; }

        /// <summary>
        /// Audit record type 
        /// </summary>
		public String AuditTrailType { get; set; }

        /// <summary>
        /// Audit record type 
        /// </summary>
		public String AuditTrailTag { get; set; }

        /// <summary>
        /// Purchase audit record text 
        /// </summary>
		public String AuditTrailNote { get; set; }

        /// <summary>
        /// User whose actions are being audited 
        /// </summary>
		public String UserName { get; set; }

        /// <summary>
        /// Date when purchase order audit record was created 
        /// </summary>
		public String AuditTrailDate { get; set; }

        /// <summary>
        /// Time when purchase order audit record was created 
        /// </summary>
		public String AuditTrailTime { get; set; }
	} 
}