using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetScannableProductIdentifiersByOrderIdsRequest : LinnObject
	{
		public IEnumerable<Guid> OrderIds { get; set; }
	} 
}