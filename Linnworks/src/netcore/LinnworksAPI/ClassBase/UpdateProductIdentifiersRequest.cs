using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateProductIdentifiersRequest
	{
		public IEnumerable<StockItemProductIdentifier> ProductIdentifiers { get; set; }
	} 
}