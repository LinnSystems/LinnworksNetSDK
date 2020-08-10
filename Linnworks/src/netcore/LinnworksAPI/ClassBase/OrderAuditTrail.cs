using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderAuditTrail
	{
        /// <summary>
        /// Date and time when audit record was added 
        /// </summary>
		public DateTime Date { get; set; }

        /// <summary>
        /// Note type 
        /// </summary>
		public String Type { get; set; }

        /// <summary>
        /// Actual audit trail note 
        /// </summary>
		public String Note { get; set; }

        /// <summary>
        /// User who left an audit trail record 
        /// </summary>
		public String User { get; set; }

        /// <summary>
        /// Note type ID 
        /// </summary>
		public String fkOrderHistoryTypeId { get; set; }

        /// <summary>
        /// Audit trail record tag 
        /// </summary>
		public String Tag { get; set; }

        /// <summary>
        /// Note type description 
        /// </summary>
		public String TypeDescription { get; set; }
	} 
}