using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetRMAHeadersByOrderIdRequest : LinnObject
	{
		public Guid OrderId { get; set; }
	} 
}