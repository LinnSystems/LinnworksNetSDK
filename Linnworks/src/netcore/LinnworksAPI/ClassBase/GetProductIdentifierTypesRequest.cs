using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProductIdentifierTypesRequest : LinnObject
	{
		public Dictionary<String,String> Types { get; set; }
	} 
}