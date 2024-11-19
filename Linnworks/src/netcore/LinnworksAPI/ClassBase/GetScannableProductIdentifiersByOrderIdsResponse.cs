using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetScannableProductIdentifiersByOrderIdsResponse : LinnObject
	{
		public Dictionary<Guid,Dictionary<Guid,List<ProductIdentifierInformation>>> ScannableProductIdentifiersForStockItemsByOrderId { get; set; }
	} 
}