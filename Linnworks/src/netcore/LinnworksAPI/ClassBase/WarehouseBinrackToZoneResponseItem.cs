using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseBinrackToZoneResponseItem
	{
		public String[] Errors { get; set; }

		public Int32 RowIndex { get; set; }

		public Int32 ZoneId { get; set; }

		public Int32 BinrackId { get; set; }
	} 
}