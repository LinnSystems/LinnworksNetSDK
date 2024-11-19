using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseMoveRequest : LinnObject
	{
        /// <summary>
        /// Id of the stock move 
        /// </summary>
		public Int32 MoveId { get; set; }
	} 
}