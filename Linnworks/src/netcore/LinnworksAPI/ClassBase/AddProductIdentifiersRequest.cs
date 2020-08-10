using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddProductIdentifiersRequest
	{
		public IEnumerable<StockItemProductIdentifier> ProductIdentifiers { get; set; }
	} 
}