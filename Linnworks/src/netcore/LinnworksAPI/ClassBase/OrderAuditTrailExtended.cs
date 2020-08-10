using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderAuditTrailExtended
	{
        /// <summary>
        /// Order id 
        /// </summary>
		public Guid pkOrderId { get; set; }

        /// <summary>
        /// List of OrderAuditTrail entities 
        /// </summary>
		public List<OrderAuditTrail> AuditTrail { get; set; }
	} 
}