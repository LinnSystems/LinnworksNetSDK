using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseBinrackToZone : LinnObject
	{
		public Int32 ZoneId { get; set; }

		public Int32 BinrackId { get; set; }
	} 
}