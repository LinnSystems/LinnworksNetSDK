using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseBinrackToZoneRequestItem
	{
		public Int32 RowIndex { get; set; }

		public Int32 ZoneId { get; set; }

		public Int32 BinrackId { get; set; }
	} 
}