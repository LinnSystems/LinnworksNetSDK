using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FindStockItem_Response : LinnObject
	{
		public List<PurchaseItemFound> Items { get; set; }
	} 
}