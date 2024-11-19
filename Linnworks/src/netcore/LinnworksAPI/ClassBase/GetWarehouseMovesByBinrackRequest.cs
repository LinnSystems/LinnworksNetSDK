using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseMovesByBinrackRequest : LinnObject
	{
        /// <summary>
        /// The Id of the binrack to get stock moves for 
        /// </summary>
		public Int32 BinrackId { get; set; }
	} 
}