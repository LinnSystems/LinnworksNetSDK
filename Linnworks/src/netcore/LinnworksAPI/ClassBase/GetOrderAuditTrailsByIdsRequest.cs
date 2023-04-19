using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderAuditTrailsByIdsRequest : LinnObject
	{
        /// <summary>
        /// List of order ids 
        /// </summary>
		public List<Guid> OrderIds { get; set; }
	} 
}