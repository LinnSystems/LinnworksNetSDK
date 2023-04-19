using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteWarehouseZoneRequest : LinnObject
	{
        /// <summary>
        /// Zone id to delete. 
        /// </summary>
		public Int32 ZoneId { get; set; }
	} 
}