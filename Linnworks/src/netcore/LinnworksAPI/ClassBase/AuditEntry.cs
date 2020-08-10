using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AuditEntry
	{
        /// <summary>
        /// Audit record ID 
        /// </summary>
		public Int32 sid_history { get; set; }

        /// <summary>
        /// Order ID (pkOrdeID) 
        /// </summary>
		public Guid fkOrderId { get; set; }

        /// <summary>
        /// Note text 
        /// </summary>
		public String HistoryNote { get; set; }

        /// <summary>
        /// Record type ID 
        /// </summary>
		public String fkOrderHistoryTypeId { get; set; }

        /// <summary>
        /// Record time and date 
        /// </summary>
		public DateTime DateStamp { get; set; }

        /// <summary>
        /// Audit record tag 
        /// </summary>
		public String Tag { get; set; }

        /// <summary>
        /// User who made audited change 
        /// </summary>
		public String UpdatedBy { get; set; }

        /// <summary>
        /// Audit trail record type 
        /// </summary>
		public String TypeDescription { get; set; }
	} 
}