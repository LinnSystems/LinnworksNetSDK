using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetRefundHeadersByOrderIdRequest : LinnObject
	{
		public Guid OrderId { get; set; }
	} 
}