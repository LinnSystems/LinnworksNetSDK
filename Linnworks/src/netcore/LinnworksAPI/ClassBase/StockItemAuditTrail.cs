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
		public String AuditType;

        /// <summary>
        /// Record date and time 
        /// </summary>
		public DateTime AuditTrailDate;

        /// <summary>
        /// Note text 
        /// </summary>
		public String AuditText;

        /// <summary>
        /// Audit trail note author 
        /// </summary>
		public String UserName;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}