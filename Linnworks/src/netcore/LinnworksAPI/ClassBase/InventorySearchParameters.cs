using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InventorySearchParameters : LinnObject
	{
		public List<Tuple<Int32,Int32>> SelectedRegions { get; set; }

		public Guid Token { get; set; }

		public List<Guid> InventoryItemIds { get; set; }

		public Int32 ChannelId { get; set; }
	} 
}