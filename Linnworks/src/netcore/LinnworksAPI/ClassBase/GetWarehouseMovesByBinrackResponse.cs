using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseMovesByBinrackResponse : LinnObject
	{
        /// <summary>
        /// A list of warehouse moves for a binrack; both incoming and outgoing 
        /// </summary>
		public WarehouseMoveCollection WarehouseMoves { get; set; }
	} 
}