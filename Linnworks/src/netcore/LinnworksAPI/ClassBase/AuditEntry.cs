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
		public Int32 sid_history;

        /// <summary>
        /// Order ID (pkOrdeID) 
        /// </summary>
		public Guid fkOrderId;

        /// <summary>
        /// Note text 
        /// </summary>
		public String HistoryNote;

        /// <summary>
        /// Record type ID 
        /// </summary>
		public String fkOrderHistoryTypeId;

        /// <summary>
        /// Record time and date 
        /// </summary>
		public DateTime DateStamp;

        /// <summary>
        /// Audit record tag 
        /// </summary>
		public String Tag;

        /// <summary>
        /// User who made audited change 
        /// </summary>
		public String UpdatedBy;

        /// <summary>
        /// Audit trail record type 
        /// </summary>
		public String TypeDescription;
	} 
}