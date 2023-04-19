using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderIdentifierRequest : LinnObject
	{
		public Guid[] OrderIds { get; set; }
	} 
}