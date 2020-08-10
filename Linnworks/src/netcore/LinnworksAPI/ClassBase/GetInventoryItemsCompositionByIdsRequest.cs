using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInventoryItemsCompositionByIdsRequest
	{
		public List<Guid> InventoryItemIds { get; set; }
	} 
}