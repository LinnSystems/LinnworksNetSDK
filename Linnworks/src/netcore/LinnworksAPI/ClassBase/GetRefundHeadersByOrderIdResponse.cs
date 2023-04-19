using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetRefundHeadersByOrderIdResponse : LinnObject
	{
		public List<OrderRefundHeader> RefundHeaders { get; set; }
	} 
}