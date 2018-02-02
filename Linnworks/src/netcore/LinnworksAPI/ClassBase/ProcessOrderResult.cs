using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ProcessOrderResult
	{
        /// <summary>
        /// Order ID (pkOrderId) 
        /// </summary>
		public Guid OrderId;

        /// <summary>
        /// Order was processed 
        /// </summary>
		public Boolean Processed;

        /// <summary>
        /// There was ab error during processing 
        /// </summary>
		public String Error;
	} 
}