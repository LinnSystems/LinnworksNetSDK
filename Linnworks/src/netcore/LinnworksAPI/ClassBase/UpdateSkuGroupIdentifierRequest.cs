using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateSkuGroupIdentifierRequest : LinnObject
	{
		public List<UpdateSkuGroupIdentifierRequestItems> Identifiers { get; set; }
	} 
}