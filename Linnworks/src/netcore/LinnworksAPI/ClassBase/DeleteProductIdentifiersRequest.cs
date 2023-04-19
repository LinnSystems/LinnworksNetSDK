using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteProductIdentifiersRequest : LinnObject
	{
		public IEnumerable<Int64> ProductIdentifierIds { get; set; }
	} 
}