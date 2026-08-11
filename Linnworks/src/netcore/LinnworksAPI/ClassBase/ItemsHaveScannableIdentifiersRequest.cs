using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ItemsHaveScannableIdentifiersRequest : LinnObject
	{
		public List<Guid> StockItemIds { get; set; }
	} 
}