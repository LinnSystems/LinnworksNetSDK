using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddProductIdentifiersRequest : LinnObject
	{
		public IEnumerable<StockItemProductIdentifier> ProductIdentifiers { get; set; }
	} 
}