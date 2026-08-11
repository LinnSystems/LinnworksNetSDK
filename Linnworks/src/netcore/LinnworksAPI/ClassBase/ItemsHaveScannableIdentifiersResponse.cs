using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ItemsHaveScannableIdentifiersResponse : LinnObject
	{
		public Dictionary<Guid,Boolean> ItemScannableIdentifierMapping { get; set; }
	} 
}