using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemAuditTrail
	{
        /// <summary>
        /// Audit type 
        /// </summary>
		public String AuditType { get; set; }

        /// <summary>
        /// Record date and time 
        /// </summary>
		public DateTime AuditTrailDate { get; set; }

        /// <summary>
        /// Note text 
        /// </summary>
		public String AuditText { get; set; }

        /// <summary>
        /// Audit trail note author 
        /// </summary>
		public String UserName { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}