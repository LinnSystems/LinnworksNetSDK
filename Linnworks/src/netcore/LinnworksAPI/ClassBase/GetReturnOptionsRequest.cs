using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetReturnOptionsRequest
	{
		public Guid OrderId { get; set; }

		public Int32? RMAHeaderId { get; set; }
	} 
}