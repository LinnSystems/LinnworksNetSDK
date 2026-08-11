using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseMoveCollection : LinnObject
	{
        /// <summary>
        /// List of stock moves coming into the binrack 
        /// </summary>
		public List<WarehouseMoveDetailed> Incoming { get; set; }

        /// <summary>
        /// List of stock moves leaving the binrack 
        /// </summary>
		public List<WarehouseMoveDetailed> Outgoing { get; set; }
	} 
}