using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInventoryItemsCompositionByIdsResponse : LinnObject
	{
		public Dictionary<Guid,List<StockItemComposition>> InventoryItemsCompositionByIds { get; set; }
	} 
}