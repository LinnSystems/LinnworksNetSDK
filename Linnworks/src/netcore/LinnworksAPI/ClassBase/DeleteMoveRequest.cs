using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteMoveRequest : LinnObject
	{
        /// <summary>
        /// Id of the stock move to delete 
        /// </summary>
		public Int32 MoveId { get; set; }
	} 
}