using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetRMAHeadersByOrderIdResponse : LinnObject
	{
		public List<OrderRMAHeader> RMAHeaders { get; set; }
	} 
}