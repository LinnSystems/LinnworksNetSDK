using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseMoveCompleteRequest : LinnObject
	{
		public Int32 MoveId { get; set; }

		public Int32? FinalBinrackId { get; set; }
	} 
}