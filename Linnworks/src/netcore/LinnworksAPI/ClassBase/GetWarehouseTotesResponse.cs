using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseTotesResponse : LinnObject
	{
		public List<WarehouseTOTE> Totes { get; set; }
	} 
}