using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetRefundOptionsRequest : LinnObject
	{
        /// <summary>
        /// If included, will return the relevant refund header as part of the RefundOptions object in the response 
        /// </summary>
		public Int32? RefundHeaderId { get; set; }

		public Guid OrderId { get; set; }
	} 
}