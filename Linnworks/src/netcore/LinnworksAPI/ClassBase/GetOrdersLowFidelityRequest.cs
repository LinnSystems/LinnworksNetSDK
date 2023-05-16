using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrdersLowFidelityRequest : LinnObject
	{
        /// <summary>
        /// (Optional) Fulfilment location id. Defaults to Default location 
        /// </summary>
		public Guid? LocationId { get; set; }
	} 
}