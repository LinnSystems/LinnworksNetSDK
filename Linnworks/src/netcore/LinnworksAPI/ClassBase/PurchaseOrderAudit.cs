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
		public Guid pkPurchaseAuditTrailId;

        /// <summary>
        /// When purchase order audit record was made 
        /// </summary>
		public DateTime AuditTrailDateTimeStamp;

        /// <summary>
        /// Purchase order ID 
        /// </summary>
		public Guid fkPurchaseId;

        /// <summary>
        /// Audit record type 
        /// </summary>
		public String AuditTrailType;

        /// <summary>
        /// Audit record type 
        /// </summary>
		public String AuditTrailTag;

        /// <summary>
        /// Purchase audit record text 
        /// </summary>
		public String AuditTrailNote;

        /// <summary>
        /// User whose actions are being audited 
        /// </summary>
		public String UserName;

        /// <summary>
        /// Date when purchase order audit record was created 
        /// </summary>
		public String AuditTrailDate;

        /// <summary>
        /// Time when purchase order audit record was created 
        /// </summary>
		public String AuditTrailTime;
	} 
}