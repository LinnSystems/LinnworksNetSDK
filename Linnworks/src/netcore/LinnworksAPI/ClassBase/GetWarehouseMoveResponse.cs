using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseMoveResponse : LinnObject
	{
        /// <summary>
        /// Move details 
        /// </summary>
		public WarehouseMoveDetailed WarehouseMove { get; set; }
	} 
}