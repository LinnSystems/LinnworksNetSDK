using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteRefundRequest
	{
        /// <summary>
        /// Identifies the refund header to be deleted 
        /// </summary>
		public Int32 RefundHeaderId { get; set; }
	} 
}