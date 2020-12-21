using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChangeOrderIdentifierRequest
	{
		public Guid[] OrderIds { get; set; }

		public String Tag { get; set; }
	} 
}