using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AvailableOrderItemBatchsInfo : LinnObject
	{
        /// <summary>
        /// Order ID 
        /// </summary>
		public Guid pkOrderId { get; set; }
	} 
}