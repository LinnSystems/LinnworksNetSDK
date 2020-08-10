using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateSkuGroupIdentifierRequestItems
	{
		public Int32 SkuGroupId { get; set; }

		public SkuGroupIdentifierType SkuGroupIdentifierType { get; set; }

		public String Identifier { get; set; }
	} 
}