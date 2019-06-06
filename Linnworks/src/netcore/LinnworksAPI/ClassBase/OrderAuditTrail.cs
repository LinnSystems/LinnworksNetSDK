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
		public DateTime Date;

        /// <summary>
        /// Note type 
        /// </summary>
		public String Type;

        /// <summary>
        /// Actual audit trail note 
        /// </summary>
		public String Note;

        /// <summary>
        /// User who left an audit trail record 
        /// </summary>
		public String User;

        /// <summary>
        /// Note type ID 
        /// </summary>
		public String fkOrderHistoryTypeId;

        /// <summary>
        /// Audit trail record tag 
        /// </summary>
		public String Tag;

        /// <summary>
        /// Note type description 
        /// </summary>
		public String TypeDescription;
	} 
}