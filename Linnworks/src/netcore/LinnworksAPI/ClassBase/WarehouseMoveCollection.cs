using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseMoveCollection : LinnObject
	{
		public List<WarehouseMoveDetailed> Incoming { get; set; }

		public List<WarehouseMoveDetailed> Outgoing { get; set; }
	} 
}