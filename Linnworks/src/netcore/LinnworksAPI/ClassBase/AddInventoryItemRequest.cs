using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddInventoryItemRequest : LinnObject
	{
		public List<StockItemHeader> InventoryItems { get; set; }
	} 
}