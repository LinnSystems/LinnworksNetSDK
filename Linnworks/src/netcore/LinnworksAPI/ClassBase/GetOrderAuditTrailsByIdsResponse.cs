using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderAuditTrailsByIdsResponse
	{
		public List<OrderAuditTrailExtended> AuditTrails { get; set; }
	} 
}