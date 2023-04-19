using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class batchAssignment : LinnObject
	{
		public Guid orderItemRowId { get; set; }

		public Int32 batchInventoryId { get; set; }

		public Int32 quantity { get; set; }
	} 
}