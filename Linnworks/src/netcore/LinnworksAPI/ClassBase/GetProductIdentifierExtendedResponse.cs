using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProductIdentifierExtendedResponse : LinnObject
	{
		public List<ProductIdentifierInformation> Types { get; set; }
	} 
}