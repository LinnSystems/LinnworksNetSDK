using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FindStockItemRequest : LinnObject
	{
		public List<String> Codes { get; set; }
	} 
}