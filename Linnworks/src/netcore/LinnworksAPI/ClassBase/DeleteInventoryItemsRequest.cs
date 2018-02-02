using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteInventoryItemsRequest
	{
		public List<Guid> InventoryItemIds;

		public List<Tuple<Int32,Int32>> SelectedRegions;

		public Guid Token;
	} 
}